namespace SensatoClient.Contracts
{
    using System;

    public interface IHiveView : IView
    {
        event EventHandler LogoutClick;
    }
}
