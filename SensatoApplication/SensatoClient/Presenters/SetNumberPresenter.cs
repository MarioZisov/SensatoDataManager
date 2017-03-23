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
    public class SetNumberPresenter : AbstractPresenter
    {
        private DeviceCommadsManager commandManager;
        private SetNumberView numberView;

        public event EventHandler ViewCancelClick;

        public SetNumberPresenter(SetNumberView numberView)
        {
            this.numberView = numberView;
        }

        public void Initialize()
        {
            this.numberView.Numbers.SelectedItem = "0";
            this.numberView.BringToFront();
            this.SubscribeEvents();
        }

        protected override void SubscribeEvents()
        {
            this.numberView.SetClick += OnSetClick;
            this.numberView.CancelClick += OnCancelClick;
            this.numberView.CancelClick += delegate
            {
                this.ViewCancelClick?.Invoke(this, EventArgs.Empty);
            };
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            this.numberView.SetClick -= OnSetClick;
        }

        private void OnSetClick(object sender, EventArgs e)
        {
            try
            {
                this.commandManager = new DeviceCommadsManager();
                int number = int.Parse(this.numberView.Numbers.SelectedItem.ToString());
                var result = this.commandManager.SetDeviceNumber(number);

                if (result != "WRONG COMMAND!")
                {
                    string message = $"Device number was set to {number}";

                    MetroMessageBox.Show(
                    (MetroUserControl)sender,
                    message,
                    "Device Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information, 100);

                    this.numberView.Hide();
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
