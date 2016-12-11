using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using SensatoClient.Contracts;

namespace SensatoClient.Views
{
    public partial class FrameView : MetroUserControl, IFrameView
    {
        public FrameView()
        {
            InitializeComponent();
        }

        public MetroPanel FramesPanel
        {
            get
            {
                return this.panelFrames;
            }
        }
    }
}
