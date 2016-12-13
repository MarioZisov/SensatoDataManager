namespace SensatoDBService
{
    using SensatoWebService.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using DataTransferObjects;
    using Faults;
    using SensatoWebService.Models;
    using System.Data.Entity.Validation;

    public class SensatoService : ISensatoService
    {
        private SensatoDbContext context;

        public SensatoService()
        {
            this.context = new SensatoDbContext();
        }

        public bool CheckUserExists(string username)
        {
            var user = this.context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                throw new FaultException<UsernameValidationFault>(new UsernameValidationFault("Invalid Username"));
            }

            return true;
        }

        public bool CheckPassowrdMatch(string passwordHash, string username)
        {
            var pass = this.context.Users.FirstOrDefault(n => n.Username == username).Password;
            if (pass != passwordHash)
            {
                throw new FaultException<PasswordValidationFault>(new PasswordValidationFault("Wrong Password"));
            }

            return true;
        }

        public ICollection<HiveDTO> GetUserDataByUsername(string username)
        {
            var hives = this.context.Hives
                .Where(h => h.User.Username == username && !h.IsRemoved)
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.IsRemoved,
                    Frames = x.Frames.Select(f => new
                    {
                        f.Position,
                        f.IsRemoved
                    })
                });

            ICollection<HiveDTO> hiveDtos = new HashSet<HiveDTO>();

            foreach (var hive in hives)
            {
                var hiveDto = new HiveDTO();
                hiveDto.Id = hive.Id;
                hiveDto.Name = hive.Name;
                foreach (var frame in hive.Frames)
                {
                    FrameDTO frameDto = new FrameDTO
                    {
                        IsRemoved = frame.IsRemoved,
                        Position = frame.Position
                    };

                    hiveDto.Frames.Add(frameDto);
                }

                hiveDtos.Add(hiveDto);
            }

            return hiveDtos;
        }

        public void AddHive(string username, string hiveName)
        {
            var user = this.context.Users.FirstOrDefault(u => u.Username == username);
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
                    Frames = this.InitializeFrames()
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
            var user = this.context.Users.FirstOrDefault(u => u.Username == username);
            var hiveNames = user.Hives.Select(h => h.Name);

            if (hiveNames.Contains(newHiveName))
            {
                throw new FaultException<AlreadyExistFault>(new AlreadyExistFault("Name is already taken"));
            }

            var hive = user.Hives.FirstOrDefault(h => h.Name == hiveName);
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
            var hive = this.context.Hives
                .FirstOrDefault(h => h.Name == hiveName && h.User.Username == username);

            hive.IsRemoved = true;
            this.context.Frames.RemoveRange(hive.Frames);
            
            this.context.SaveChanges();

            return true;
        }

        public ICollection<FrameDTO> GetFramesByHiveName(string username, string hiveName)
        {
            ICollection<FrameDTO> framesDTOs = new HashSet<FrameDTO>();
            var user = this.context.Users.FirstOrDefault(u => u.Username == username);
            var frames = user.Hives.FirstOrDefault(h => h.Name == hiveName).Frames;
            foreach (var frame in frames)
            {
                FrameDTO frameDto = new FrameDTO
                {
                    Position = frame.Position,
                    IsRemoved = frame.IsRemoved
                };

                framesDTOs.Add(frameDto);
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
                    IsRemoved = true
                };

                frames.Add(frame);
            }

            return frames;
        }
    }
}