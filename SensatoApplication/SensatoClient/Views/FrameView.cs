namespace SensatoClient.Views
{
    using System;
    using System.Linq;
    using MetroFramework.Controls;
    using SensatoClient.Contracts;

    public partial class FrameView : MetroUserControl, IFrameView
    {
        public event EventHandler FrameButtonClick;
        public event EventHandler SaveButtonClick;
        public event EventHandler BackButtonClick;

        public FrameView()
        {
            InitializeComponent();
            this.SubscribeViewButtons();
        }

        public MetroPanel FramesPanel
        {
            get
            {
                return this.panelFrames;
            }
        }

        public string HiveName
        {
            get { return this.labelHiveName.Text; }
            set { this.labelHiveName.Text = value; }
        }

        private void SubscribeViewButtons()
        {
            var buttons = this.FramesPanel.Controls.OfType<MetroButton>();
            foreach (MetroButton button in buttons)
            {
                button.Click += delegate
                {
                    this.FrameButtonClick?.Invoke(button, EventArgs.Empty);
                };
            }

            buttonSave.Click += delegate
            {
                this.SaveButtonClick?.Invoke(this, EventArgs.Empty);
            };

            buttonBack.Click += delegate
            {
                this.BackButtonClick?.Invoke(this, EventArgs.Empty);
            };


        }
    }
}
