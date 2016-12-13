namespace SensatoClient.Contracts
{
    using System;

    public interface ILoginView : IView
    {
        event EventHandler LoginClick;

        string Username { get; }

        string Password { get; set; }        

        void ShowErrorMessage(string errorMessage);

        void HideErrorMessage();
    }
}
