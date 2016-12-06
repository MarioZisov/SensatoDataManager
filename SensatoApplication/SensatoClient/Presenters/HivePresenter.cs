using SensatoClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenters
{
    public class HivePresenter
    {
        private IHiveView hiveView;
        private ILoginView loginView;

        public HivePresenter(IHiveView hiveView, ILoginView loginView)
        {
            this.hiveView = hiveView;
            this.loginView = loginView;
            this.loginView.LoginClick += OnLoginClick;
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            this.hiveView.Show();
        }
    }
}
