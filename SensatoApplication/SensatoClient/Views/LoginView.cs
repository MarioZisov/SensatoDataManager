using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using SensatoClient.Contracts;
using MetroFramework.Interfaces;

namespace SensatoClient.Views
{
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

        private void SubscribeEvents()
        {
            this.buttonLogin.Click += delegate
            {
                this.LoginClick?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}