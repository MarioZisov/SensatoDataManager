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
            private set
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

        public void ShowUsernameError(string errorMessage)
        {
            this.labelUsernameError.Text = errorMessage;
            this.labelUsernameError.Show();
        }

        public void HideUsernameError()
        {
            this.labelUsernameError.Hide();
        }

        public void ShowPasswordError(string errorMessage)
        {
            this.labelPasswordError.Text = errorMessage;
            this.labelPasswordError.Show();
        }

        public void HidePasswordError()
        {
            this.labelPasswordError.Hide();
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