namespace SensatoDBService.DataTransferObjects
{

    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using global::SensatoWebService.Models;

    [DataContract]
    public class FrameDTO
    {
        private ICollection<MeasurmentDTO> measurments;
        public FrameDTO()
        {
            this.Measurments = new HashSet<MeasurmentDTO>();
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Position { get; set; }

        [DataMember]
        public virtual Hive Hive { get; set; }

        [DataMember]
        public bool IsRemoved { get; set; }

        [DataMember]
        public ICollection<MeasurmentDTO> Measurments
        {
            get { return this.measurments; }
            set { this.measurments = value; }
        }
    }
}
