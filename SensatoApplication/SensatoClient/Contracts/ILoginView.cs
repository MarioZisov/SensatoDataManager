namespace SensatoClient.Contracts
{
    using System;

    public interface ILoginView : IView
    {
        event EventHandler LoginClick;

        string Username { get; }

        string Password { get; }        

        void ShowUsernameError(string errorMessage);

        void HideUsernameError();

        void ShowPasswordError(string errorMessage);
                 
        void HidePasswordError();
    }
}
