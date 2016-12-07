using SensatoWebService.Data;
using System;

namespace SensatoDBService
{
    using System.Collections.Generic;
    using System.Linq;
    using DataTransferObjects;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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
                return false;
            }

            return true;
        }

        public bool CheckPassowrdMatch(string passwordHash,string username)
        {
            var pass = this.context.Users.FirstOrDefault(n => n.Username == username).Password;
            if (pass != passwordHash)
            {
                return false;
            }

            return true;
        }

        public ICollection<HiveDTO> GetHivesByUser(string username)
        {
            var hives = this.context.Hives.Where(n => n.User.Username == username).Select(x=> new
            {
                x.Id,
                x.Name
            });

            ICollection<HiveDTO> hiveDtos = new HashSet<HiveDTO>();

            foreach (var hive in hives)
            {
                var hiveDto = new HiveDTO();
                hiveDto.Id = hive.Id;
                hiveDto.Name = hive.Name;

                hiveDtos.Add(hiveDto);
            }

            return hiveDtos;
        }
    }
}
