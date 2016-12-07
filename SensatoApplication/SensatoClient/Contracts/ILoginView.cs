using MetroFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Contracts
{
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
