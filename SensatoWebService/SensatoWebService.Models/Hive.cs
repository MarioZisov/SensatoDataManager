namespace SensatoWebService.Models
{
    using Attributes;
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
        [MinLength(1), MaxLength(100)]
        [HiveName]
        [Index("HiveNameUserIdUnq", IsUnique = true, Order = 1)]
        public string Name { get; set; }

        [Required]
        public bool IsRemoved { get; set; }

        [Index("HiveNameUserIdUnq", IsUnique = true, Order = 2)]
        public int? UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Frame> Frames
        {
            get { return this.frames; }
            set { this.frames = value; }
        }
    }
}