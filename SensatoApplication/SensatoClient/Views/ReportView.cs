using MetroFramework.Controls;
using MetroFramework.Forms;
using SensatoClient.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient.Views
{
    public partial class ReportView : MetroForm, IReportView
    {
        public event EventHandler SendClick;

        public ReportView()
        {
            InitializeComponent();
            this.SubsribeViewButtons();
        }

        public string UserEmail
        {
            get { return this.textBoxEmail.Text; }
        }

        public string Subject
        {
            get { return this.textBoxSubject.Text; }
        }

        public string Message
        {
            get { return this.textBoxMessage.Text; }
        }

        public MetroLabel LoadLabel
        {
            get { return this.labelLoading; }
        }

        private void SubsribeViewButtons()
        {
            this.buttonSend.Click += delegate
            {
                this.SendClick?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
