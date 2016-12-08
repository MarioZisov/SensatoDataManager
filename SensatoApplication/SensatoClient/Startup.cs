namespace SensatoClient
{
    using Contracts;
    using Presenters;
    using Views;
    using System;
    using System.Windows.Forms;
    static class Startup
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ILoginView loginView = new LoginView();
            IHiveView hiveView = new HiveView();
            
            HivePresenter hivePres = new HivePresenter(hiveView);
            LoginPresenter loginPres = new LoginPresenter(loginView, hiveView,hivePres);

            MainForm mainForm = new MainForm(loginView, hiveView);
            Application.Run(mainForm);
        }
    }
}