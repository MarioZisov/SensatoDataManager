namespace SensatoClient.Presenters
{
    using Contracts;
    using System;
    using Models;
    using SensatoServiceReference;
    using System.ServiceModel;

    public class LoginPresenter : AbstractPresenter
    {
        private ILoginView loginView;
        private HivePresenter hivePresenter;
        private SensatoServiceClient serviceClient;

        public LoginPresenter(ILoginView loginView, HivePresenter hivePresenter)
        {
            this.loginView = loginView;
            this.serviceClient = new SensatoServiceClient();
            this.hivePresenter = hivePresenter;
            this.SubscribeEvents();
        }               

        protected override void SubscribeEvents()
        {
            this.loginView.LoginClick += OnLoginClick;
            this.hivePresenter.LogoutClick += OnLogoutClick;
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            this.loginView.HideErrorMessage();

            string username = this.loginView.Username;
            string password = this.loginView.Password;

            try
            {
                this.serviceClient.CheckUserExists(username);
                this.serviceClient.CheckPassowrdMatch(password, username);
                this.User = new UserModel(username);
                this.hivePresenter.User = this.User;
                this.loginView.Password = string.Empty;

                this.hivePresenter.Initialize();;
            }
            catch (FaultException<UsernameValidationFault> fex)
            {
                this.loginView.ShowErrorMessage(fex.Detail.Message);
            }
            catch (FaultException<PasswordValidationFault> fex)
            {
                this.loginView.ShowErrorMessage(fex.Detail.Message);
            }
        }

        private void OnLogoutClick(object sender, EventArgs e)
        {
            this.loginView.BringToFront();
        }
    }
}