namespace SensatoClient.Presenters
{
    using Contracts;
    using System;
    using Models;
    using SensatoServiceReference;
    using System.ServiceModel;
    using MetroFramework;
    using MetroFramework.Controls;
    using System.Windows.Forms;
    using Views;

    public class LoginPresenter : AbstractPresenter
    {
        private const string cantConnectMessage = "Could not connect to the server.";
        private const string cantConnectTitle = "Connection problem";

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
            this.loginView.LabelClick += OnLabelClick;
        }        

        private void OnLoginClick(object sender, EventArgs e)
        {
            this.loginView.HideErrorMessage();

            string username = "FirstUser";// this.loginView.Username;
            string password = "123";// this.loginView.Password;

            try
            {
                //string hashedPassword = HashUtilities.HashPassword(password);

                this.serviceClient.CheckUserExists(username);
                this.serviceClient.CheckPassowrdMatch(password, username);
                this.User = new UserModel(username);
                this.hivePresenter.User = this.User;
                this.loginView.Password = string.Empty;

                this.hivePresenter.Initialize();
            }
            catch (FaultException<UsernameValidationFault> fex)
            {
                this.loginView.ShowErrorMessage(fex.Detail.Message);
            }
            catch (FaultException<PasswordValidationFault> fex)
            {
                this.loginView.ShowErrorMessage(fex.Detail.Message);
            }
            catch (EndpointNotFoundException)
            {
                MetroMessageBox.Show(
                    (MetroUserControl)this.loginView,
                    cantConnectMessage,
                    cantConnectTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 100);
            }
        }

        private void OnLabelClick(object sender, EventArgs e)
        {
            IReportView reportView = new ReportView();
            ReportPresenter reportPresenter = new ReportPresenter(reportView);
            reportPresenter.Initialize();
        }

        private void OnLogoutClick(object sender, EventArgs e)
        {
            this.loginView.BringToFront();
        }
    }
}