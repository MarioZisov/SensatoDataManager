namespace SensatoDBService.DataTransferObjects
{
    using System;
    using System.Runtime.Serialization;
    using SensatoWebService.Models;

    [DataContract]
    public class MeasurmentDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public float FirstSensorTemp { get; set; }

        [DataMember]
        public float SecondSensorTemp { get; set; }

        [DataMember]
        public float ThirdSensorTemp { get; set; }

        [DataMember]
        public DateTime DateTimeOfMeasurment { get; set; }

        [DataMember]
        public Frame Frame { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
}