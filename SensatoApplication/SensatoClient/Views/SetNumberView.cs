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
    public partial class SetNumberView : MetroUserControl, IView
    {
        public event EventHandler CancelClick;
        public event EventHandler SetClick;

        public SetNumberView()
        {
            InitializeComponent();
            this.SubscribeViewButtons();
        }

        public MetroComboBox Numbers => this.dropNumbers;

        private void SubscribeViewButtons()
        {
            this.buttonCancel.Click += delegate
            {
                this.CancelClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonSet.Click += delegate
            {
                this.SetClick?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
