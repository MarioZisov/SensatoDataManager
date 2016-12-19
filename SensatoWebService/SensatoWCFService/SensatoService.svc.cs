namespace SensatoDBService
{
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using Faults;
    using SensatoWebService.Models;
    using System.Data.Entity.Validation;
    using System;
    using SensatoWebService.Data;
    using DataTransferObjects;

    public class SensatoService : ISensatoService
    {
        private SensatoContext context;

        public SensatoService()
        {
            this.context = new SensatoContext();
        }

        public bool CheckUserExists(string username)
        {
            var user = this.GetUserByUsername(username);
            if (user == null)
            {
                throw new FaultException<UsernameValidationFault>(new UsernameValidationFault("Invalid Username"));
            }

            return true;
        }

        public bool CheckPassowrdMatch(string passwordHash, string username)
        {
            var pass = this.GetUserByUsername(username).Password;
            if (pass != passwordHash)
            {
                throw new FaultException<PasswordValidationFault>(new PasswordValidationFault("Wrong Password"));
            }

            return true;
        }

        public IEnumerable<string> GetUserHivesByUsername(string username)
        {
            var user = GetUserByUsername(username);
            var hiveNames = user.Hives
                .Where(h => h.User.Username == username && !h.IsRemoved)
                .Select(h => h.Name)
                .ToArray();           

            return hiveNames;
        }        

        public void AddHive(string username, string hiveName)
        {
            var user = this.GetUserByUsername(username);
            var hiveNames = user.Hives.Where(h => !h.IsRemoved).Select(h => h.Name);
            if (hiveNames.Contains(hiveName))
            {
                throw new FaultException<AlreadyExistFault>(new AlreadyExistFault("Name is already taken"));
            }

            try
            {
                Hive hive = new Hive
                {
                    Name = hiveName,
                    IsRemoved = false,
                    Frames = this.InitializeFrames(),
                    DateOfCreation = DateTime.Now
                };

                user.Hives.Add(hive);
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException)
            {
                throw new FaultException<AlreadyExistFault>(new AlreadyExistFault("Invalid name"));
            }
        }

        public bool RenameHive(string username, string newHiveName, string hiveName)
        {
            var user = this.GetUserByUsername(username);
            var hiveNames = user.Hives.Select(h => h.Name);

            if (hiveNames.Contains(newHiveName))
            {
                throw new FaultException<AlreadyExistFault>(new AlreadyExistFault("Name is already taken"));
            }

            var hive = this.GetHive(user, hiveName);
            try
            {
                hive.Name = newHiveName;
                this.context.SaveChanges();
                return true;
            }
            catch (DbEntityValidationException)
            {
                throw new FaultException<AlreadyExistFault>(new AlreadyExistFault("Invalid name"));
            }
        }

        public bool RemoveHive(string username, string hiveName)
        {
            var user = GetUserByUsername(username);
            var hive = GetHive(user, hiveName);

            hive.IsRemoved = true;
            hive.DateRemoved = DateTime.Now;
            this.RemoveFramesByHive(hive);

            this.context.SaveChanges();

            return true;
        }

        public IEnumerable<int> GetFramesByHiveName(string username, string hiveName)
        {
            var user = this.GetUserByUsername(username);
            var framesPositions = this.GetHive(user, hiveName).Frames
                .Where(f => f.IsActive)
                .Select(f => f.Position)
                .ToArray();            

            return framesPositions;
        }

        public void ChangeFrameStatusByHiveName(string username, string hiveName, IEnumerable<int> activeFramesPositions)
        {
            var user = this.GetUserByUsername(username);
            var hive = this.GetHive(user, hiveName);
            var frames = hive.Frames;
            var positions = hive.Frames.Select(f => f.Position);

            foreach (var position in positions)
            {
                if (!activeFramesPositions.Contains(position))
                {
                    frames.FirstOrDefault(f => f.Position == position).IsActive = false;
                    continue;
                }

                frames.FirstOrDefault(f => f.Position == position).IsActive = true;
            }

            this.context.SaveChanges();
        }

        public ICollection<FrameDTO> GetMeasurmentData(string username, string hiveName, DateTime startDate, DateTime endDate)
        {
            var user = GetUserByUsername(username);
            var hive = GetHive(user, hiveName);            

            var frames = hive.Frames.Where(f => f.IsActive).Select(f => new
            {
                f.Position,
                Measurments = f.Measurments
                .Where(m => m.DateTimeOfMeasurment.Date >= startDate.Date && m.DateTimeOfMeasurment.Date <= endDate.Date)
            });

            ICollection<FrameDTO> framesDTOs = new HashSet<FrameDTO>();
            foreach (var frame in frames)
            {
                var frameDTO = new FrameDTO { Position = frame.Position };
                foreach (var measurment in frame.Measurments)
                {
                    var measurmentDTO = new MeasurmentDTO
                    {
                        FirstSensorTemp = measurment.FirstSensorTemp,
                        SecondSensorTemp = measurment.SecondSensorTemp,
                        ThirdSensorTemp = measurment.ThirdSensorTemp,
                        OutsideTemp = measurment.OutsideTemp,
                        DateTimeOfMeasurment = measurment.DateTimeOfMeasurment
                    };

                    frameDTO.Measurments.Add(measurmentDTO);
                }

                framesDTOs.Add(frameDTO);
            }

            return framesDTOs;
        }

        private ICollection<Frame> InitializeFrames()
        {
            ICollection<Frame> frames = new HashSet<Frame>();
            for (int i = 1; i <= 28; i++)
            {
                Frame frame = new Frame
                {
                    Position = i,
                    IsRemoved = false,
                    IsActive = false
                };

                frames.Add(frame);
            }

            return frames;
        }

        private User GetUserByUsername(string username)
        {
            User user = context.Users.FirstOrDefault(u => u.Username == username);
            return user;
        }

        private Hive GetHive(User user, string hiveName)
        {
            var hive = user.Hives.FirstOrDefault(h => h.Name == hiveName);

            return hive;
        }

        private void RemoveFramesByHive(Hive hive)
        {
            foreach (var frame in hive.Frames)
            {
                frame.IsRemoved = true;
            }
        }

    }
}