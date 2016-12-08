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
            this.hivePresenter = hivePresenter;
            this.SubscribeEvents();
        }               

        protected override void SubscribeEvents()
        {
            this.loginView.LoginClick += OnLoginClick;
            this.hiveView.LogoutClick += OnLogoutClick;
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            this.loginView.HideUsernameError();
            this.loginView.HidePasswordError();

            string username = "FirstUser";// this.loginView.Username;
            string password = "123";// this.loginView.Password;

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

        private void OnLogoutClick(object sender, EventArgs e)
        {
            this.loginView.BringToFront();
            this.hiveView.ResetHiveView();       
        }
    }
}