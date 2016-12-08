namespace SensatoClient.Views
{
    using System;
    using MetroFramework.Controls;
    using Contracts;
    public partial class HiveView : MetroUserControl, IHiveView
    {
        public event EventHandler LogoutClick;

        public HiveView()
        {
            this.InitializeComponent();
            this.TriggerEvents();
        }

        private void TriggerEvents()
        {
            this.buttonLogout.Click += delegate
            {
                this.LogoutClick?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
