using MetroFramework.Controls;
using MetroFramework.Forms;
using SensatoClient.Contracts;
using SensatoClient.Models;
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

            ILoginView loginView = new LoginView();
            IHiveView hiveView = new HiveView();

            UserModel user = new UserModel();

            LoginPresenter loginPres = new LoginPresenter(loginView, hiveView, user);
            HivePresenter hivePres = new HivePresenter(loginView, hiveView);

            MainForm mainForm = new MainForm(loginView, hiveView);
            Application.Run(mainForm);
        }
    }
}