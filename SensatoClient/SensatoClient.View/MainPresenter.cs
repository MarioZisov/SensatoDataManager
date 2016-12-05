using SensatoClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenter
{
    public class MainPresenter
    {
        private MainView view;
        public MainPresenter(MainView mainView)
        {
            this.view = mainView;
            this.view.Login += this.OnLogin;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            HiveView uc = new HiveView();
            this.view.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
