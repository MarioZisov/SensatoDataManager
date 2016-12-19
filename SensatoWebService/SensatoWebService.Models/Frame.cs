namespace SensatoWebService.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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
       
        public int? HiveId { get; set; }

        public virtual Hive Hive { get; set; }
        
        [Required]
        public bool IsRemoved { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Measurment> Measurments
        {
            get { return this.measurments; }
            set { this.measurments = value; }
        }
    }
}