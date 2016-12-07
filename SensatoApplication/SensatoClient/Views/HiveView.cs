using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using SensatoClient.Contracts;

namespace SensatoClient.Views
{
    public partial class HiveView : MetroUserControl, IHiveView
    {
        public event EventHandler LogoutClick;

        public HiveView()
        {
            this.InitializeComponent();
            this.SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            this.buttonLogout.Click += delegate
            {
                this.LogoutClick.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
