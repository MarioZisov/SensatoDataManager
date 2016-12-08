namespace SensatoClient.Models
{
    using System.Collections.Generic;

    public class UserModel
    {
        private ICollection<HiveModel> hives;

        public UserModel(string username)
        {
            this.Username = username;
            this.hives = new HashSet<HiveModel>();
        }

        public string Username { get; set; }
        
        public ICollection<HiveModel> Hives
        {
            get { return this.hives; }
            set { this.hives = value; }
        }
    }
}
