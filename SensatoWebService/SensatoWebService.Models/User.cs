namespace SensatoWebService.Models
{
    using System;
    using System.Collections.Generic;
    using Enumerations;
    using Attributes;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
        [MinLength(4), MaxLength(30)]
        [Username, Index(IsUnique = true)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool IsLogged { get; set; } 
        
        [Required]
        public bool IsDisabled { get; set; }

        [Required]
        public RoleType Role { get; set; }

        [Required]
        public DateTime DateOfRegistration { get; set; }

        public DateTime? DateDisabled { get; set; }
        public virtual ICollection<Hive> Hives
        {
            get { return this.hives; }
            set { this.hives = value; }
        }
    }
}