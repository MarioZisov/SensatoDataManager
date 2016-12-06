using MetroFramework.Controls;
using MetroFramework.Forms;
using SensatoClient.Contracts;
using SensatoClient.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient
{
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