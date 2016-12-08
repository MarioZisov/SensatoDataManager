namespace SensatoClient.Models
{
    using System.Collections.Generic;

    public class HiveModel
    {
        private ICollection<FrameModel> frames;

        public HiveModel()
        {
            this.frames = new HashSet<FrameModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<FrameModel> Frames
        {
            get { return this.frames; }
            set { this.frames = value; }
        }
    }
}