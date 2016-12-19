namespace SensatoWebService.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Measurment
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public float FirstSensorTemp { get; set; }

        [Required]
        public float SecondSensorTemp { get; set; }

        [Required]
        public float ThirdSensorTemp { get; set; }

        [Required]
        public DateTime DateTimeOfMeasurment { get; set; }

        public int? FrameId { get; set; }
       
        public virtual Frame Frame { get; set; }
        
    }
}