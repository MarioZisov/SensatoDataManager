using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient.View
{
    using Presenter;

    static class Startup
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainView view = new MainView();
            MainPresenter presenter = new MainPresenter(view);
            Application.Run(view);
        }
    }
}
