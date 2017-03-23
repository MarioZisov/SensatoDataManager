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
    public partial class SetTimeView : MetroUserControl, IView
    {
        public event EventHandler SetClick;
        public event EventHandler CancelClick;
        public event EventHandler CheckedManually;
        public event EventHandler CheckedAutomatic;

        public SetTimeView()
        {
            this.InitializeComponent();
            this.SubscribeViewButtons();
        }

        public MetroRadioButton RadioManually => this.radioManually;

        public MetroRadioButton RadioAutomatic => this.radioAutomatic;

        public MetroDateTime DateTime => this.dateTime;

        public MetroComboBox Minutes => this.dropMinutes;

        public MetroComboBox Hours => this.dropHours;

        public MetroPanel DateTimePanel => this.panelDateTime;

        private void SubscribeViewButtons()
        {
            this.buttonSet.Click += delegate
            {
                this.SetClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonCancel.Click += delegate
            {
                this.CancelClick?.Invoke(this, EventArgs.Empty);
            };

            this.radioManually.CheckedChanged += delegate
            {
                this.CheckedManually?.Invoke(this, EventArgs.Empty);
            };

            this.RadioAutomatic.CheckedChanged += delegate
            {
                this.CheckedAutomatic?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
