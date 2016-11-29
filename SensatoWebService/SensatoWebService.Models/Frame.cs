namespace SensatoWebService.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Frame
    {
        private ICollection<Measurment> measurments;
        public Frame()
        {
            this.Measurments = new HashSet<Measurment>();   
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int Position { get; set; }

        [Required,Column("HiveId")]
        public virtual Hive Hive { get; set; }
        
        [Required]
        public bool IsDeleted { get; set; }

        public virtual ICollection<Measurment> Measurments
        {
            get { return this.measurments; }
            set { this.measurments = value; }
        }
    }
}
