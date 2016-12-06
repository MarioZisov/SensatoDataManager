using SensatoClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient.Presenters
{
    public class LoginPresenter
    {
        private ILoginView loginView;

        public LoginPresenter(ILoginView loginView)
        {
            this.loginView = loginView;
            this.loginView.LoginClick += OnLoginClick;
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            this.loginView.Hide();
        }
    }
}