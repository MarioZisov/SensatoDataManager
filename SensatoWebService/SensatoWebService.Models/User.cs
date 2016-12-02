namespace SensatoWebService.Models
{
    using Enumerations;
    using Attributes;
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

        [Required, Username, MinLength(4)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool IsLogged { get; set; } 
        
        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public RoleType Role { get; set; }

        public virtual ICollection<Hive> Hives
        {
            get { return this.hives; }
            set { this.hives = value; }
        }
    }
}