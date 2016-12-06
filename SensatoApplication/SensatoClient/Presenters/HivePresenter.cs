using MetroFramework;
using SensatoClient.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenters
{
    public class HivePresenter
    {
        private IHiveView hiveView;
        private ILoginView loginView;

        //Hive presenters must hold Previous, Current and Next view.
        public HivePresenter(ILoginView loginView, IHiveView hiveView)
        {
            this.hiveView = hiveView;
            this.loginView = loginView;
            this.loginView.LoginClick += OnLoginClick;
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            
        }
    }
}
