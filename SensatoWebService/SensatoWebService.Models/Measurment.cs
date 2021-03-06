﻿namespace SensatoWebService.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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

        [Required,Column("FrameId")]
        public virtual Frame Frame { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
