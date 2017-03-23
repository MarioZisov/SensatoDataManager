using MetroFramework;
using MetroFramework.Controls;
using SensatoClient.Exceptions;
using SensatoClient.Utilities;
using SensatoClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient.Presenters
{
    public class SetTimePresenter : AbstractPresenter
    {
        private SetTimeView timeView;
        private DeviceCommadsManager commandsManager;

        public event EventHandler ViewCancelButtonClick;

        public SetTimePresenter(SetTimeView timeView)
        {
            this.timeView = timeView;
        }

        public void Initialize()
        {
            this.timeView.Hours.SelectedItem = "00";
            this.timeView.Minutes.SelectedItem = "00";
            this.timeView.BringToFront();
            this.SubscribeEvents();
        }

        protected override void SubscribeEvents()
        {
            this.timeView.SetClick += OnSetClick;
            this.timeView.CheckedManually += OnCheckedManually;
            this.timeView.CheckedAutomatic += OnCheckedAutomatic;
            this.timeView.CancelClick += OnCancelClick;
            this.timeView.CancelClick += delegate
            {
                this.ViewCancelButtonClick.Invoke(this, EventArgs.Empty);
            };
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            this.timeView.SetClick -= OnSetClick;
            this.timeView.CheckedManually -= OnCheckedManually;
            this.timeView.CheckedAutomatic -= OnCheckedAutomatic;
        }

        private void OnCheckedAutomatic(object sender, EventArgs e)
        {
            if (this.timeView.RadioAutomatic.Checked)
            {

            }
        }

        private void OnCheckedManually(object sender, EventArgs e)
        {
            if (this.timeView.RadioManually.Checked)
                this.timeView.DateTimePanel.Enabled = true;
            else
                this.timeView.DateTimePanel.Enabled = false;
        }

        private void OnSetClick(object sender, EventArgs e)
        {
            DateTime date;

            if (this.timeView.RadioManually.Checked)
            {
                date = this.timeView.DateTime.Value.Date;
                
                var hours = int.Parse(this.timeView.Hours.SelectedItem.ToString());
                var minutes = int.Parse(this.timeView.Minutes.SelectedItem.ToString());

                date = date.AddHours(hours);
                date = date.AddMinutes(minutes);
            }
            else
            {
                date = DateTime.Now;
            }

            try
            {
                this.commandsManager = new DeviceCommadsManager();
                string result = this.commandsManager.SetTime(date);

                if (result == "OK!")
                {
                    string dateTime = date.ToString("dd MMM yyyy, hh:mm");
                    string message = $"Time was set to {dateTime}";

                    MetroMessageBox.Show(
                    (MetroUserControl)sender,
                    message,
                    "Device Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information, 100);

                    this.timeView.Hide();
                }
                else
                {
                    MetroMessageBox.Show(
                    (MetroUserControl)sender,
                    "Please try again to set the device clock.",
                    "Problem occurred",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning, 100);
                }
            }
            catch (NoPortFoundException)
            {
                MetroMessageBox.Show(
                    (MetroUserControl)sender,
                    "Ensure that device is connected",
                    "No Device Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error, 100);
            }

        }
    }
}
