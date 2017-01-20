namespace SensatoClient.Views
{
    using System;
    using Contracts;
    using MetroFramework.Controls;
    using SensatoServiceReference;
    using System.Drawing;

    public partial class LoginView : MetroUserControl, ILoginView
    {
        public event EventHandler LoginClick;
        public event EventHandler LabelClick;

        public LoginView()
        {
            this.InitializeComponent();
            this.SubscribeEvents();
        }

        public string Password
        {
            get
            {
                return this.textBoxPassword.Text;
            }
            set
            {
                this.textBoxPassword.Text = value;
            }
        }

        public string Username
        {
            get
            {
                return this.tetBoxUsername.Text;
            }
            private set
            {
                this.tetBoxUsername.Text = value;
            }
        }

        public void ShowErrorMessage(string errorMessage)
        {
            this.labelError.Text = errorMessage;
            this.labelError.Show();
        }

        public void HideErrorMessage()
        {
            this.labelError.Hide();
        }

        private void SubscribeEvents()
        {
            this.buttonLogin.Click += delegate
            {
                this.LoginClick?.Invoke(this, EventArgs.Empty);
            };

            this.labelReport.Click += delegate
            {
                this.LabelClick?.Invoke(this, EventArgs.Empty);
            };
        }

        private void labelReport_MouseEnter(object sender, EventArgs e)
        {
            this.labelReport.ForeColor = Color.DarkRed;
        }

        private void labelReport_MouseLeave(object sender, EventArgs e)
        {
            this.labelReport.ForeColor = Color.Red;
        }
    }
}