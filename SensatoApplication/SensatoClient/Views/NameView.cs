using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SensatoClient.Contracts;
using MetroFramework.Controls;

namespace SensatoClient.Views
{
    public partial class NameView : MetroUserControl, INameView
    {
        public event EventHandler CancelButtonClick;
        public event EventHandler SaveButtonClick;       

        public NameView()
        {
            this.InitializeComponent();
            this.SubscribeEvents();
        }

        public string HiveName
        {
            get
            {
                return this.textBoxHiveName.Text;
            }
            set
            {
                this.textBoxHiveName.Text = value;
            }
        }

        public string ErrorText
        {
            get
            {
                return this.labelError.Text;
            }
            set
            {
                this.labelError.Text = value;
            }
        }

        public void ShowError() => this.labelError.Show();

        public void HideError() => this.labelError.Hide();

        private void SubscribeEvents()
        {
            this.buttonSave.Click += delegate
            {
                this.SaveButtonClick?.Invoke(this.textBoxHiveName, EventArgs.Empty);
            };

            this.buttonCancel.Click += delegate
            {
                this.CancelButtonClick?.Invoke(this, EventArgs.Empty);
            };
        }        
    }
}
