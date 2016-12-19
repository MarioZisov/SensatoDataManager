namespace SensatoClient
{
    using System.Windows.Forms;
    using Contracts;
    using MetroFramework.Forms;
    using Views;

    public partial class MainForm : MetroForm
    {
        private IView[] views;

        public MainForm(params IView[] views)
        {
            InitializeComponent();
            this.views = views;
            InitializeViews();                                        
        }

        private void InitializeViews()
        {
            foreach (var view in this.views)
            {
                this.Controls.Add((UserControl)view);
            }

            IView loginView = this.views[0];
            loginView.BringToFront();
        }
    }
}