using MetroFramework.Controls;
using SensatoClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenters
{
    public class FramePresenter : AbstractPresenter
    {
        private IFrameView frameView;

        public FramePresenter(IFrameView frameView)
        {
            this.frameView = frameView;
            this.SubscribeEvents();
        }

        protected override void SubscribeEvents()
        {
            this.frameView.FrameButtonClick += OnFrameButtonClick;
        }

        public void LoadActiveFrames(IEnumerable<int> framesPositions)
        {
            var frameButtons = this.frameView.FramesPanel.Controls.OfType<MetroButton>();
            foreach (MetroButton frameButton in frameButtons)
            {
                int pos = int.Parse(frameButton.Text);
                if (framesPositions.Contains(pos))
                {
                    frameButton.Highlight = true;
                }
            }

            this.frameView.BringToFront();
        }

        public void SetCurrentHiveName(string hiveName)
        {
            this.frameView.HiveName = hiveName;
        }

        private void OnFrameButtonClick(object sender, EventArgs e)
        {
            MetroButton frame = (MetroButton)sender;


            frame.Highlight = !frame.Highlight;
        }
    }
}
