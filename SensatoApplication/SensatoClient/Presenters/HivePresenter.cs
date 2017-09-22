namespace SensatoClient.Presenters
{
    using Contracts;
    using MetroFramework.Controls;
    using SensatoServiceReference;
    using System;
    using System.Windows.Forms;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using IO;
    using MetroFramework;
    using Views;
    using System.Threading.Tasks;
    using Utilities;
    using Exceptions;

    public class HivePresenter : AbstractPresenter
    {
        private const string Pattern =
            @"((\+\d{1,2}\,){3}(---,)+)+((\+\d{1,2}\,){3}(---,)+(\+\d{1,2},)?(---,)+)?([0-9]|0[0-9]|1[0-9]|2[0-3])h(.+)";

        private const string ValidateFileMessage = "Are you sure you want to add data to \"{0}\" from file: \"{1}\"?";

        private IHiveView hiveView;
        private SensatoServiceClient serviceClient;
        private NamePresenter namePresenter;
        private MetroButton selectedHiveButton;
        private FramePresenter framePresenter;
        private FileInputReader reader;
        private DeviceCommadsManager commandsManager;
        private SetTimePresenter timePresenter;
        private SetNumberPresenter numberPresetner;

        public event EventHandler LogoutClick;

        public HivePresenter(IHiveView hiveView, NamePresenter namePresenter, FramePresenter framePresenter, SetTimePresenter timePresenter, SetNumberPresenter numberPresenter)
        {
            this.hiveView = hiveView;
            this.serviceClient = new SensatoServiceClient();
            this.reader = new FileInputReader();
            this.namePresenter = namePresenter;
            this.framePresenter = framePresenter;
            this.timePresenter = timePresenter;
            this.numberPresetner = numberPresenter;
            //this.dataPresenter = dataPresenter;
            this.SubscribeEvents();
            //this.commandsManager = new DeviceCommadsManager();
        }

        public void Initialize()
        {
            var hivesNames = this.serviceClient.GetUserHivesByUsername(this.User.Username);
            this.PassHivesToView(hivesNames);
            this.hiveView.BringToFront();
        }

        protected override void SubscribeEvents()
        {
            this.hiveView.DataClick += OnDataButtonClick;
            this.hiveView.LogoutClick += OnLogout;
            this.hiveView.HiveButtonClick += OnHiveButtonsClick;
            this.hiveView.AddHiveClick += OnAddHiveButtonClick;
            this.hiveView.RenameHiveClick += OnRenameHiveClick;
            this.hiveView.RemoveHiveClick += OnRemoveHiveClick;
            this.hiveView.AddDataFileClick += OnAddDataFileClick;
            this.hiveView.FrameClick += OnFrameClick;
            this.hiveView.SearchTextChanged += OnSearchTextChange;

            this.hiveView.CheckTimeClick += OnCheckTimeClick;
            this.hiveView.SetTimeClick += OnSetTimeClick;
            this.hiveView.ShowNumberClick += OnShowNumberClick;
            this.hiveView.SetNumberClick += OnSetNumberClick;
            this.hiveView.GetDataClick += OnGetDataClick;

            this.namePresenter.RenameSaveComplete += OnRenameComplete;
            this.namePresenter.AddSaveComplete += OnAddComplete;
            this.namePresenter.Cancel += OnRenameCancel;

            this.framePresenter.ViewBackButtonClick += OnFrameViewBackButtonClick;

            this.timePresenter.ViewCancelButtonClick += OnViewCancelButtonClick;
            this.timePresenter.ViewSetButtonClick += OnViewSetButtonClick;

            this.numberPresetner.ViewCancelClick += OnViewCancelClick;
            this.numberPresetner.ViewSetClick += OnViewSetClick; 
        }

        private void OnViewSetClick(object sender, EventArgs e)
        {
            this.hiveView.IsEnabled = true;
        }

        private void OnViewSetButtonClick(object sender, EventArgs e)
        {
            this.hiveView.IsEnabled = true;
        }

        private void OnViewCancelClick(object sender, EventArgs e)
        {
            this.hiveView.IsEnabled = true;
            this.hiveView.BringToFront();
        }

        private void OnViewCancelButtonClick(object sender, EventArgs e)
        {
            this.hiveView.IsEnabled = true;
            this.hiveView.BringToFront();
        }

        private void OnGetDataClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnSetNumberClick(object sender, EventArgs e)
        {
            this.hiveView.IsEnabled = false;
            this.numberPresetner.Initialize();
        }

        private void OnShowNumberClick(object sender, EventArgs e)
        {
            this.commandsManager = new DeviceCommadsManager();
            var numberStr = commandsManager.CheckDeviceNumber();
            int number = int.Parse(numberStr);
            string message = $"Device number is {number}";

            MetroMessageBox.Show(
                    (MetroUserControl)sender,
                    message,
                    "Device Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information, 100);
        }

        private void OnSetTimeClick(object sender, EventArgs e)
        {
            this.hiveView.IsEnabled = false;
            this.timePresenter.Initialize();
        }
    

        private void OnCheckTimeClick(object sender, EventArgs e)
        {
            try
            {
                this.commandsManager = new DeviceCommadsManager();
                string time = this.commandsManager.CheckTime();
                MetroMessageBox.Show(
                    (MetroUserControl)sender,
                    time,
                    "Device Time",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information, 100);
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
            catch (MoreThenOnePortFoundException)
            {
                MetroMessageBox.Show(
                   (MetroUserControl)sender,
                   "Please ensure only Sensato's device is connected",
                   "More Than One Device Found",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning, 100);
            }
        }

        private void OnSearchTextChange(object sender, EventArgs e)
        {
            var searchBox = (MetroTextBox)sender;
            string text = searchBox.Text.ToLower();

            var buttons = this.hiveView.HivesTable.Controls
                .OfType<MetroButton>();

            if (string.IsNullOrEmpty(text))
            {
                foreach (var button in buttons)
                {
                    button.Visible = true;
                    button.Refresh();
                }
            }
            else
            {
                foreach (var button in buttons)
                {
                    if (!button.Text.ToLower().Contains(text))
                    {
                        button.Visible = false;
                        button.Refresh();
                        continue;
                    }

                    button.Visible = true;
                    button.Refresh();
                }
            }
        }

        private async void OnAddDataFileClick(object sender, EventArgs e)
        {
            this.hiveView.FileDialog.Filter = "All files(*.txt) | *.txt";
            DialogResult fileOpenResult = this.hiveView.FileDialog.ShowDialog();
            if (fileOpenResult != DialogResult.Cancel)
            {
                string addedFilePath = this.hiveView.FileDialog.FileName;
                int lastSlashIndex = addedFilePath.LastIndexOf('\\');
                string fileName = addedFilePath.Substring(lastSlashIndex + 1);

                DialogResult confirmResult = MetroMessageBox.Show
                    ((MetroUserControl)sender,
                        string.Format(ValidateFileMessage, this.selectedHiveButton.Text, fileName),
                        "Confrim data upload"
                        , MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        120);

                if (confirmResult == DialogResult.Yes)
                {
                    this.hiveView.Spinner.Visible = true;
                    this.hiveView.Spinner.Spinning = true;
                    this.hiveView.IsEnabled = false;

                    IList<string> allLines = this.reader.ReadInput(addedFilePath);
                    IList<string> validLines = this.ParseValideLines(allLines);
                    await Task.Factory.StartNew(() => this.ProcessData(validLines));

                    this.hiveView.Spinner.Visible = false;
                    this.hiveView.Spinner.Spinning = false;
                    this.hiveView.IsEnabled = true;
                }
            }
        }

        //TODO: Validation for input data
        //TODO: This method should be moved in a separate class
        private void ProcessData(IList<string> validLines)
        {
            Dictionary<int, object[][]> dataTranferCollection = new Dictionary<int, object[][]>();
            int framesCount = this.serviceClient
                .GetFramesByHive(this.User.Username, this.selectedHiveButton.Text)
                .Count();

            for (int i = 0; i < framesCount; i++)
            {
                dataTranferCollection.Add(i, new object[validLines.Count][]);
            }

            string splitString = "---|,---,";

            for (int lineIndex = 0; lineIndex < validLines.Count; lineIndex++)
            {
                string[] splittedDataByFrame = Regex.Split(validLines[lineIndex], splitString)
                        .Where(s => !string.IsNullOrEmpty(s))
                        .ToArray();

                string dateTime = splittedDataByFrame[splittedDataByFrame.Length - 1];
                int hour = int.Parse(dateTime.Split(',')[0].Substring(0, 2));
                string outsideTemp = null;

                DateTime measurmentDate = DateTime.Parse(dateTime.Split(',')[1]).AddHours(hour);

                if (framesCount + 2 == splittedDataByFrame.Length)
                {
                    outsideTemp = splittedDataByFrame[splittedDataByFrame.Length - 2];
                }

                for (int index = 0; index < framesCount; index++)
                {
                    object[] dataByFrame = new object[5];
                    dataByFrame[0] = splittedDataByFrame[index].Split(',')[0];
                    dataByFrame[1] = splittedDataByFrame[index].Split(',')[1];
                    dataByFrame[2] = splittedDataByFrame[index].Split(',')[2];
                    dataByFrame[3] = outsideTemp;
                    dataByFrame[4] = measurmentDate;

                    dataTranferCollection[index][lineIndex] = dataByFrame;
                }
            }

            this.serviceClient.UploadMeasurmentData(this.User.Username, this.selectedHiveButton.Text, dataTranferCollection);

        }

        private void OnDataButtonClick(object sender, EventArgs e)
        {
            IDataView dataView = new DataView();
            DataPresenter dataPres = new DataPresenter(dataView);
            dataPres.User = this.User;
            dataPres.InitializeData(this.selectedHiveButton.Text);
        }

        private void OnFrameViewBackButtonClick(object sender, EventArgs e)
            => this.hiveView.BringToFront();

        private void OnFrameClick(object sender, EventArgs e)
        {
            this.framePresenter.User = this.User;

            IEnumerable<int> activeFrames = this.serviceClient
                .GetFramesByHive(this.User.Username, this.selectedHiveButton.Text);

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

        private void OnRenameCancel(object sender, EventArgs e)
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

        private IList<string> ParseValideLines(IList<string> allLines)
        {
            Regex regex = new Regex(Pattern);

            IList<string> validLines = new List<string>();
            foreach (var line in allLines)
            {
                if (regex.IsMatch(line))
                {
                    validLines.Add(line);
                }
            }

            return validLines;
        }
    }
}