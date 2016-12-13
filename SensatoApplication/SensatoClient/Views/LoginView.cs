namespace SensatoClient.Views
{
    using System;
    using Contracts;
    using MetroFramework.Controls;

    public partial class LoginView : MetroUserControl, ILoginView
    {
        public event EventHandler LoginClick;

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
        }        
    }
}