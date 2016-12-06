using MetroFramework.Controls;
using MetroFramework.Forms;
using SensatoClient.Contracts;
using SensatoClient.Presenters;
using SensatoClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient
{
    static class Startup
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserControl loginView = new LoginView();
            UserControl hiveView = new HiveView();
            LoginPresenter loginPres = new LoginPresenter((ILoginView)loginView);
            HivePresenter hivePres = new HivePresenter((IHiveView)hiveView, (ILoginView)loginView);
            MainForm mainForm = new MainForm(loginView, hiveView);
            Application.Run(mainForm);
        }
    }
}