namespace SensatoClient.Presenters
{
    using Contracts;
    using MetroFramework.Controls;
    using Models;
    using SensatoServiceReference;
    using System;
    using System.Windows.Forms;
    using System.Linq;

    public class HivePresenter : AbstractPresenter
    {
        private IHiveView hiveView;
        private SensatoServiceClient serviceClient;

        public HivePresenter(IHiveView hiveView)
        {
            this.hiveView = hiveView;
            this.serviceClient = new SensatoServiceClient();
            this.SubscribeEvents();
        }             

        public void LoadHives()
        {
            var hivesDto = this.serviceClient.GetUserDataByUsername(this.User.Username);
            foreach (var hiveDto in hivesDto)
            {
                HiveModel hive = new HiveModel();
                if (!hiveDto.IsRemoved)
                {
                    hive.Id = hiveDto.Id;
                    hive.Name = hiveDto.Name;
                    foreach (var frameDto in hiveDto.Frames)
                    {
                        FrameModel frame = new FrameModel();
                        if (!frameDto.IsRemoved)
                        {
                            frame.Position = frameDto.Position;
                            hive.Frames.Add(frame);
                        }
                    }
                    this.User.Hives.Add(hive);
                }
            }

            this.PassHivesToView();
        }

        protected override void SubscribeEvents()
        {
            this.hiveView.HiveButtonClick += OnHiveButtonsClick;
        }

        private void OnHiveButtonsClick(object sender, EventArgs e)
        {
            MetroButton hiveButton = (MetroButton)sender;
            var hiveControls = this.hiveView.HiveControls.Controls.OfType<MetroButton>();
            foreach (MetroButton button in hiveControls)
            {
                button.Enabled = true;
            }
        }

        private void PassHivesToView()
        {
            int hivesCount = this.User.Hives.Count;
            int heigthToAdd = 0;
            if (hivesCount > 20)
            {
                int diff = hivesCount - 20;
                int rowsToAdd = (diff / 5) + 1;
                heigthToAdd = rowsToAdd * 95;
                this.hiveView.HivesPanel.Height += heigthToAdd;
            }

            Control[] buttons = new Control[hivesCount];

            int counter = 0;
            foreach (var hive in this.User.Hives)
            {
                MetroButton button = new MetroButton();
                button.Width = 112;
                button.Height = 95;

                Padding padding = new Padding();
                padding.All = 5;

                button.Margin = padding;
                button.Text = hive.Name;

                buttons[counter] = button;
                counter++;
            }

            this.hiveView.HivesPanel.Controls.AddRange(buttons);
            this.hiveView.SubscibeHiveButtons();
        }
    }
}