namespace SensatoWebService.Models
{
    using System;
    using Attributes;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Hive
    {
        private ICollection<Frame> frames;

        public Hive()
        {
            this.Frames = new HashSet<Frame>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ASCII]
        [MinLength(1), MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public bool IsRemoved { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public DateTime DateOfCreation { get; set; }

        public DateTime? DateRemoved { get; set; }

        public virtual ICollection<Frame> Frames
        {
            get { return this.frames; }
            set { this.frames = value; }
        }
    }
}