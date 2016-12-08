namespace SensatoDBService.DataTransferObjects
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using SensatoWebService.Models.Enumerations;

    [DataContract]
    public class UserDTO
    {
        private ICollection<HiveDTO> hives;

        public UserDTO()
        {
            this.Hives = new HashSet<HiveDTO>();
        }
        
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool IsLogged { get; set; }

        [DataMember]
        public bool IsDisabled { get; set; }

        [DataMember]
        public RoleType Role { get; set; }

        [DataMember]
        public ICollection<HiveDTO> Hives
        {
            get { return this.hives; }
            set { this.hives = value; }
        }
    }
}
