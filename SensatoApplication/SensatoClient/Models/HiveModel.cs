using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Models
{
    public class HiveModel
    {
        private ICollection<FrameModel> frames;

        public HiveModel()
        {
            this.frames = new HashSet<FrameModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<FrameModel> MyProperty
        {
            get { return this.frames; }
            set { this.frames = value; }
        }
    }
}