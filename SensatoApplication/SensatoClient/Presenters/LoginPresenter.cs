using SensatoClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SensatoClient.Exceptions;
using SensatoClient.Models;
using SensatoClient.SensatoServiceReference;
using System.ServiceModel;

namespace SensatoClient.Presenters
{
    public class LoginPresenter : AbstractPresenter
    {
        private ILoginView loginView;
        private IHiveView hiveView;
        private UserModel user;
        private SensatoServiceClient serviceClient;

        public LoginPresenter(ILoginView loginView, IHiveView hiveView, UserModel user)
        {
            this.loginView = loginView;
            this.hiveView = hiveView;
            this.user = user;
            this.serviceClient = new SensatoServiceClient();
            this.SubscribeEvents();
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            this.loginView.HideUsernameError();
            this.loginView.HidePasswordError();

            string username = this.loginView.Username;
            string password = this.loginView.Password;

            try
            {
                this.serviceClient.CheckUserExists(username);
                this.serviceClient.CheckPassowrdMatch(password, username);

                this.hiveView.BringToFront();
            }
            catch (FaultException<UsernameValidationFault> fex)
            {
                this.loginView.ShowUsernameError(fex.Detail.Message);
            }
            catch (FaultException<PasswordValidationFault> fex)
            {
                this.loginView.ShowPasswordError(fex.Detail.Message);
            }
        }

        public void OnLogoutClick(object sender, EventArgs e)
        {
            this.loginView.BringToFront();
        }

        protected override void SubscribeEvents()
        {
            this.loginView.LoginClick += OnLoginClick;
            this.hiveView.LogoutClick += OnLogoutClick;
        }
    }
}