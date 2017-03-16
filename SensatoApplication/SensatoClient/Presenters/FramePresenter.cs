namespace SensatoClient.Presenters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using MetroFramework.Controls;
    using SensatoServiceReference;

    public class FramePresenter : AbstractPresenter
    {
        private IFrameView frameView;
        private SensatoServiceClient serviceClient;

        public event EventHandler ViewBackButtonClick;

        public FramePresenter(IFrameView frameView)
        {
            this.frameView = frameView;
            this.serviceClient = new SensatoServiceClient();
            this.SubscribeEvents();
        }

        protected override void SubscribeEvents()
        {
            this.frameView.FrameButtonClick += OnFrameButtonClick;
            this.frameView.SaveButtonClick += OnSaveButtonClick;
            this.frameView.BackButtonClick += delegate 
            {
                this.ViewBackButtonClick?.Invoke(this, EventArgs.Empty);
            };
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            var activeFramesPositions = this.frameView.FramesPanel.Controls
                .OfType<MetroButton>()
                .Where(b => b.Highlight)
                .Select(b => int.Parse(b.Text))
                .ToArray();

            this.serviceClient.ChangeFrameStatusByHive(this.User.Username, this.frameView.HiveName, activeFramesPositions);

        }

        public void LoadActiveFrames(IEnumerable<int> framesPositions)
        {
            var frameButtons = this.frameView.FramesPanel.Controls.OfType<MetroButton>();
            foreach (MetroButton frameButton in frameButtons)
            {
                int pos = int.Parse(frameButton.Text);
                if (!framesPositions.Contains(pos))
                {
                    frameButton.Highlight = false;
                    continue;
                }

                frameButton.Highlight = true;
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
