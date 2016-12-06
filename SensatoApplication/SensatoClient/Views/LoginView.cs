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
            InitializeComponent();
            this.buttonLogin.Click += delegate
            {
                this.LoginClick?.Invoke(this, EventArgs.Empty);
            };
        }

        public string Password
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Username
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }        
    }
}