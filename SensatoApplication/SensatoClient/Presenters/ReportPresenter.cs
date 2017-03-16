namespace SensatoClient.Presenters
{
    using System;
    using System.IO.Ports;
    using System.ServiceModel;
    using System.Windows.Forms;
    using Contracts;
    using MetroFramework;
    using MetroFramework.Forms;
    using SensatoServiceReference;

    public class ReportPresenter : AbstractPresenter
    {
        private const string cantConnectMessage = "Could not connect to the server";
        private const string cantConnectTitle = "Connection problem";
        private const string successMessage = "Message send successfully";
        private const string successTitle = "Success";

        

        private IReportView reportView;
        private SensatoServiceClient client;

        public ReportPresenter(IReportView reportView)
        {
            this.reportView = reportView;
            this.client = new SensatoServiceClient();
            this.SubscribeEvents();

            var portsNames = SerialPort.GetPortNames();

        }

        public void Initialize()
        {
            this.reportView.Show();
        }

        protected override void SubscribeEvents()
        {
            this.reportView.SendClick += OnSendClick;
        }

        private void OnSendClick(object sender, EventArgs e)
        {
            this.reportView.LoadLabel.Visible = true;
            this.reportView.LoadLabel.Refresh();

            string userEmail = this.reportView.UserEmail;
            string subject = this.reportView.Subject;
            string message = string.Format(
                "{0}{1}---------------{1}{2}",
                this.reportView.Message,
                Environment.NewLine,
                this.reportView.UserEmail);

            try
            {
                client.SendEmail("sensato.report@gmail.com", subject, message, false);

                this.ShowMessage(successTitle, successMessage, true);
            }
            catch (EndpointNotFoundException)
            {
                this.ShowMessage(cantConnectTitle, cantConnectMessage, false);
            }
            finally
            {
                this.reportView.Close();
            }
        }

        private void ShowMessage(string title, string message, bool isSuccessful)
        {
            this.reportView.LoadLabel.Visible = false;

            MetroMessageBox.Show(
                    (MetroForm)this.reportView,
                    message,
                    title,
                    MessageBoxButtons.OK,
                    isSuccessful ? MessageBoxIcon.Information : MessageBoxIcon.Error
                    , 100);
        }
    }
}