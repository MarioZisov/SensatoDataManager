namespace SensatoClient.Contracts
{
    using MetroFramework.Controls;
    using System;
    using System.Windows.Forms;

    public interface IHiveView : IView
    {
        event EventHandler LogoutClick;

        event EventHandler HiveButtonClick;

        TableLayoutPanel HivesPanel { get; }

        MetroPanel HiveControls { get; }

        void SubscibeHiveButtons();

        void ResetHiveView();
    }
}
