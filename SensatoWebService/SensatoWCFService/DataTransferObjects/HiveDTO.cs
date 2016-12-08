namespace SensatoDBService.DataTransferObjects
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using SensatoWebService.Models;

    [DataContract]
    public class HiveDTO
    {
        private ICollection<FrameDTO> frames;

        public HiveDTO()
        {
            this.Frames = new HashSet<FrameDTO>();
        }

        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public bool IsRemoved { get; set; }
        
        [DataMember]
        public User User { get; set; }

        [DataMember]
        public ICollection<FrameDTO> Frames
        {
            get { return this.frames; }
            set { this.frames = value; }
        }
    }
}