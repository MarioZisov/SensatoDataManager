using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Models
{
    public class UserModel
    {
        private ICollection<HiveModel> hives;

        public UserModel()
        {
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
