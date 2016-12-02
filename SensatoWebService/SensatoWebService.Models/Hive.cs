namespace SensatoWebService.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
        public string Name { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required, Column("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<Frame> Frames
        {
            get { return this.frames; }
            set { this.frames = value; }
        }
    }
}