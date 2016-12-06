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
        private IHiveView hiveView;

        public LoginPresenter(ILoginView loginView, IHiveView hiveView)
        {
            this.loginView = loginView;
            this.hiveView = hiveView;
            this.loginView.LoginClick += OnLoginClick;
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            //Login logic and validation come here.
            ///...
            //If success the Hive View have to be brought to front.
            this.hiveView.BringToFront();
        }
    }
}