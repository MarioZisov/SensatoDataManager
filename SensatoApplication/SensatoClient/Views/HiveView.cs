namespace SensatoClient.Views
{
    using System;
    using MetroFramework.Controls;
    using Contracts;
    using System.Windows.Forms;
    using System.Linq;

    public partial class HiveView : MetroUserControl, IHiveView
    {
        public event EventHandler LogoutClick;
        public event EventHandler HiveButtonClick;

        public HiveView()
        {
            this.InitializeComponent();
            this.SubscribeViewButtons();
        }

        public TableLayoutPanel HivesPanel
        {
            get
            {
                return this.tablePanelHives;
            }
        }

        public MetroPanel HiveControls
        {
            get
            {
                return this.panelHiveControls;
            }
        }

        public void ResetHiveView()
        {
            this.HivesPanel.Height = 380;
            this.HivesPanel.Controls.Clear();

            var hiveControls = this.HiveControls.Controls.OfType<MetroButton>();
            foreach (MetroButton button in hiveControls)
            {
                button.Enabled = false;
            }
        }

        public void SubscibeHiveButtons()
        {
            foreach (Button button in HivesPanel.Controls)
            {
                button.Click += delegate
                {
                    this.HiveButtonClick?.Invoke(button, EventArgs.Empty);
                };
            }
        }

        private void SubscribeViewButtons()
        {
            this.buttonLogout.Click += delegate
            {
                this.LogoutClick?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}