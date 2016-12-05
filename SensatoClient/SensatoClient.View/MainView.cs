using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient.View
{
    public partial class MainView : MetroForm
    {
        public event EventHandler Login;

        public MainView()
        {
            this.InitializeComponent();

            this.buttonLogin.Click += delegate
            {
                this.Login?.Invoke(this, EventArgs.Empty);
            };
        }


        //private void buttonLogin_Click(object sender, EventArgs e)
        //{
        //    HiveView uc = new HiveView();
        //    this.Controls.Add(uc);
        //    uc.BringToFront();
        //}
    }
}
