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
            INameView nameView = new NameView();
            IFrameView frameView = new FrameView();
            IDataView dataView = new DataView();

            DataPresenter dataPres = new DataPresenter(dataView);
            FramePresenter framePres = new FramePresenter(frameView);
            NamePresenter namePres = new NamePresenter(nameView);
            HivePresenter hivePres = new HivePresenter(hiveView, namePres, framePres, dataPres);
            LoginPresenter loginPres = new LoginPresenter(loginView, hivePres);

            MainForm mainForm = new MainForm(loginView, hiveView, nameView, frameView);
            Application.Run(mainForm);
        }
    }
}