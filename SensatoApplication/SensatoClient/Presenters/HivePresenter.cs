namespace SensatoClient.Presenters
{
    using Contracts;
    using MetroFramework.Controls;
    using Models;
    using SensatoServiceReference;
    using System;
    using System.Windows.Forms;
    using System.Linq;
    using System.Collections.Generic;
    using MetroFramework;

    public class HivePresenter : AbstractPresenter
    {
        private IHiveView hiveView;
        private SensatoServiceClient serviceClient;
        private NamePresenter namePresenter;
        private MetroButton selectedHiveButton;
        private FramePresenter framePresenter;

        public event EventHandler LogoutClick;

        public HivePresenter(IHiveView hiveView, NamePresenter namePresenter, FramePresenter framePresenter)
        {
            this.hiveView = hiveView;
            this.serviceClient = new SensatoServiceClient();
            this.namePresenter = namePresenter;
            this.framePresenter = framePresenter;
            this.SubscribeEvents();
        }

        public void Initialize()
        {
            var hivesNames = this.serviceClient.GetUserHivesByUsername(this.User.Username);            
            this.PassHivesToView(hivesNames);
            this.hiveView.BringToFront();
        }

        protected override void SubscribeEvents()
        {
            this.hiveView.LogoutClick += OnLogout;
            this.hiveView.HiveButtonClick += OnHiveButtonsClick;
            this.hiveView.AddHiveClick += OnAddHiveButtonClick;
            this.hiveView.RenameHiveClick += OnRenameHiveClick;
            this.hiveView.RemoveHiveClick += OnRemoveHiveClick;
            this.hiveView.FrameClick += OnFrameClick;
            this.namePresenter.RenameSaveComplete += OnRenameComplete;
            this.namePresenter.AddSaveComplete += OnAddComplete;
            this.namePresenter.Cancel += OnCancel;
            this.framePresenter.ViewBackButtonClick += OnFrameViewBackButtonClick;
        }

        private void OnFrameViewBackButtonClick(object sender, EventArgs e)
            => this.hiveView.BringToFront();

        private void OnFrameClick(object sender, EventArgs e)
        {
            this.framePresenter.User = this.User;

            IEnumerable<int> activeFrames = this.serviceClient
                .GetFramesByHiveName(this.User.Username, this.selectedHiveButton.Text);                

            this.framePresenter.SetCurrentHiveName(this.selectedHiveButton.Text);
            this.framePresenter.LoadActiveFrames(activeFrames);
        }

        private void OnRemoveHiveClick(object sender, EventArgs e)
        {
            string hiveName = this.selectedHiveButton.Text;

            DialogResult result = MetroMessageBox.Show((MetroUserControl)sender
                , $"Data for {hiveName} will be deleted. Do you want to continue?"
                , $"Delete {hiveName}"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning
                , 100);

            if (result == DialogResult.Yes)
            {
                this.serviceClient.RemoveHive(this.User.Username, hiveName);
                var hive = this.User.Hives.FirstOrDefault(h => h.Name == hiveName);
                this.User.Hives.Remove(hive);
                this.hiveView.HivesTable.Controls.Remove(this.selectedHiveButton);
                this.hiveView.HivesTable.Refresh();
                this.hiveView.HiveControls.Enabled = false;
                this.selectedHiveButton = null;
            }
        }

        private void OnLogout(object sender, EventArgs e)
        {
            this.LogoutClick?.Invoke(sender, e);
            this.hiveView.HivesTable.Height = 0;
            this.hiveView.HivesTable.Controls.Clear();
            this.hiveView.HiveControls.Enabled = false;
        }

        private void OnRenameHiveClick(object sender, EventArgs e)
        {
            this.namePresenter.User = this.User;
            this.namePresenter.RenameInitialize(this.selectedHiveButton.Text);
            this.hiveView.IsEnabled = false;
        }

        private void OnAddHiveButtonClick(object sender, EventArgs e)
        {
            this.namePresenter.User = this.User;
            this.namePresenter.AddInitialize();
            this.hiveView.IsEnabled = false;
        }

        private void OnRenameComplete(object sender, EventArgs e)
        {
            MetroTextBox textBox = (MetroTextBox)sender;
            string newHiveName = textBox.Text;
            this.selectedHiveButton.Text = newHiveName;

            this.hiveView.IsEnabled = true;
            this.hiveView.BringToFront();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            this.hiveView.IsEnabled = true;
            this.hiveView.BringToFront();
        }

        private void OnAddComplete(object sender, EventArgs e)
        {
            MetroTextBox textBox = (MetroTextBox)sender;
            string hiveName = textBox.Text;
            this.PassHivesToView(new List<string> { hiveName });

            this.hiveView.IsEnabled = true;
            this.hiveView.BringToFront();
        }

        private void OnHiveButtonsClick(object sender, EventArgs e)
        {
            var buttons = this.hiveView.HivesTable.Controls.OfType<MetroButton>();
            foreach (var button in buttons)
            {
                button.Highlight = false;
            }

            this.hiveView.HivesTable.Refresh();

            MetroButton hiveButton = (MetroButton)sender;
            hiveButton.Highlight = true;
            hiveButton.Refresh();
            this.selectedHiveButton = hiveButton;
            this.hiveView.HiveControls.Enabled = true;
        }

        private void PassHivesToView(IEnumerable<string> hiveNames)
        {
            int hivesCount = hiveNames.Count();
            RearangeHivesTable(hivesCount);

            MetroButton[] buttons = new MetroButton[hivesCount];

            int counter = 0;
            foreach (var hiveName in hiveNames)
            {
                MetroButton button = new MetroButton();
                button.Width = 112;
                button.Height = 95;
                button.UseSelectable = false;
                button.Style = MetroColorStyle.Yellow;

                Padding padding = new Padding();
                padding.All = 5;

                button.Margin = padding;
                button.Text = hiveName;

                buttons[counter] = button;
                counter++;
            }

            this.hiveView.HivesTable.Controls.AddRange(buttons);
            this.hiveView.SubscibeHiveButtons(buttons);
        }

        private void RearangeHivesTable(int hivesCount)
        {
            int currentHivesCount = this.hiveView.HivesTable.Controls.OfType<MetroButton>().Count();
            int currentRowsCount = (int)Math.Ceiling(currentHivesCount / 5.0);

            int totalHivesCount = hivesCount + currentHivesCount;
            int totalRowsCount = (int)Math.Ceiling(totalHivesCount / 5.0);

            int rowsToAdd = totalRowsCount - currentRowsCount;
            if (rowsToAdd > 0)
            {
                for (int i = 0; i < rowsToAdd; i++)
                {
                    RowStyle rs = new RowStyle(SizeType.Absolute, 95);
                    this.hiveView.HivesTable.RowStyles.Add(rs);
                    this.hiveView.HivesTable.Height += 95;
                }
            }
        }
    }
}