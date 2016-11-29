namespace SensatoWebService.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        private ICollection<Hive> hives;
        public User()
        {
            this.Hives = new HashSet<Hive>();   
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool IsLogged { get; set; } 

        public bool IsDeleted { get; set; }

        public virtual ICollection<Hive> Hives
        {
            get { return this.hives; }
            set { this.hives = value; }
        }
    }
}
