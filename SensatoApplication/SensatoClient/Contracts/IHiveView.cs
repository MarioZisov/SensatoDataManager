namespace SensatoClient.Contracts
{
    using System;
    using System.Windows.Forms;

    public interface IHiveView : IView
    {
        event EventHandler LogoutClick;

        event EventHandler HiveButtonClick;

        TableLayoutPanel HivesPanel { get; set; }

        void SubscibeHiveButtons();
    }
}
