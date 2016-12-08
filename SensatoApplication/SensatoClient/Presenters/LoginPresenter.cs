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
        private IHiveView hiveView;
        private HivePresenter hivePresenter;
        private SensatoServiceClient serviceClient;

        public LoginPresenter(ILoginView loginView, IHiveView hiveView, HivePresenter hivePresenter)
        {
            this.loginView = loginView;
            this.hiveView = hiveView;
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
                this.User = new UserModel(username);
                this.hivePresenter.User = this.User;

                this.hivePresenter.LoadHives();
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