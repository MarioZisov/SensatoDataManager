namespace SensatoClient
{
    using Contracts;
    using Presenters;
    using Views;
    using System;
    using System.Windows.Forms;
    using System.Globalization;
    using System.Threading;

    static class Startup
    {
        private static Mutex mutex = new Mutex(true, "mutex");

        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ILoginView loginView = new LoginView();
            IHiveView hiveView = new HiveView();
            INameView nameView = new NameView();
            IFrameView frameView = new FrameView();
            //IDataView dataView = new DataView();
            SetTimeView timeView = new SetTimeView();

            //DataPresenter dataPres = new DataPresenter(/*dataView*/);
            FramePresenter framePres = new FramePresenter(frameView);
            NamePresenter namePres = new NamePresenter(nameView);
            SetTimePresenter timePresenter = new SetTimePresenter(timeView);
            HivePresenter hivePres = new HivePresenter(hiveView, namePres, framePres, timePresenter/*, dataPres*/);
            LoginPresenter loginPres = new LoginPresenter(loginView, hivePres);

            MainForm mainForm = new MainForm(loginView, hiveView, nameView, frameView, timeView);
            
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.Run(mainForm);
            }
            else
            {
                MessageBox.Show("The program already running!", "Oops",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}