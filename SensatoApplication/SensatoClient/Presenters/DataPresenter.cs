

namespace SensatoClient.Presenters
{
    using Contracts;
    using SensatoServiceReference;
    using System;
    using System.Windows.Forms;
    using Views;

    public class DataPresenter : AbstractPresenter
    {
        private const int NumberOfSensorsOnFrame = 3;
        private const string FramePositionColumn = "framePos";
        private const string FrameColumn = "frame";
        private const string OutsideColumn = "outside";
        private const string DateColumn = "date";
        private const string TimeColumn = "time";

        private IDataView dataView;
        private SensatoServiceClient client;
        private string hiveName;

        public DataPresenter(/*IDataView dataView*/)
        {
            //this.dataView = dataView;
            this.client = new SensatoServiceClient();
            //this.SubscribeEvents();
        }

        public void InitializeData(string hiveName)
        {
            this.dataView = new DataView();
            this.dataView.Show();
            this.SubscribeEvents();
            this.hiveName = hiveName;
            this.dataView.StartDate.MaxDate = DateTime.Now;
        }

        protected override void SubscribeEvents()
        {
            this.dataView.ShowClick += OnShowClick;
            this.dataView.StartDateChange += OnStartDateChange;
        }

        private void OnStartDateChange(object sender, EventArgs e)
        {
            this.dataView.EndDate.MaxDate = DateTime.Now;

            if (!this.dataView.EndDate.Enabled)
            {
                this.dataView.EndDate.Enabled = true;
            }

            this.dataView.EndDate.ResetText();

            var startDateValue = this.dataView.StartDate.Value;
            this.dataView.EndDate.MinDate = startDateValue;
            var maxDateDiff = (DateTime.Now - startDateValue).TotalDays <= 30
                ? (DateTime.Now - startDateValue).TotalDays
                : 30;

            this.dataView.EndDate.MaxDate = startDateValue.AddDays(maxDateDiff);
        }

        private void OnShowClick(object sender, EventArgs e)
        {
            this.dataView.DataGrid.Rows.Clear();

            var startDate = this.dataView.StartDate.Value;
            var endDate = this.dataView.EndDate.Value;

            var framesWithMeasurments =
                this.client.GetMeasurmentData(this.User.Username, this.hiveName, startDate, endDate);

            this.ManageMeasurments(framesWithMeasurments);
        }

        private void ManageMeasurments(FrameDTO[] framesWithMeasurments)
        {
            int frameCounter = 1;

            foreach (var frameWithMeasurments in framesWithMeasurments)
            {
                int measurmentCounter = 0;
                int framePos = frameWithMeasurments.Position;

                this.dataView.DataGrid.Columns[FrameColumn + frameCounter].HeaderText = "Position " + framePos;

                //It will be good if we can avoid this - first adding empty rows then putting data in them
                if (this.dataView.DataGrid.RowCount < frameWithMeasurments.Measurments.Length * 3)
                {
                    for (int i = 0; i < frameWithMeasurments.Measurments.Length * NumberOfSensorsOnFrame; i++)
                    {
                        this.dataView.DataGrid.Rows.Add();
                    }
                }

                foreach (var measurmentDto in frameWithMeasurments.Measurments)
                {
                    string fristTemp = measurmentDto.FirstSensorTemp.ToString();
                    string secondTemp = measurmentDto.SecondSensorTemp.ToString();
                    string thirdTemp = measurmentDto.ThirdSensorTemp.ToString();
                    string outsideTemp = measurmentDto.OutsideTemp.ToString();
                    string dateOfMeasurment = measurmentDto.DateTimeOfMeasurment.Date.ToString("d");
                    string timeOfMeasurment = measurmentDto.DateTimeOfMeasurment.TimeOfDay.ToString("g");

                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FramePositionColumn].Value = "Sensor 1: ";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FrameColumn + frameCounter].Value = fristTemp;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[OutsideColumn].Value =
                        !string.IsNullOrEmpty(outsideTemp) ? outsideTemp : "n/a";
                    this.dataView.DataGrid.Rows[measurmentCounter++].Cells[DateColumn].Value = dateOfMeasurment;

                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FramePositionColumn].Value = "Sensor 2: ";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FrameColumn + frameCounter].Value = secondTemp;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[OutsideColumn].Value =
                        !string.IsNullOrEmpty(outsideTemp) ? outsideTemp : "n/a";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[TimeColumn].Value = timeOfMeasurment;
                    this.dataView.DataGrid.Rows[measurmentCounter++].Cells[DateColumn].Value = dateOfMeasurment;

                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FramePositionColumn].Value = "Sensor 3: ";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FrameColumn + frameCounter].Value = thirdTemp;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[OutsideColumn].Value =
                        !string.IsNullOrEmpty(outsideTemp) ? outsideTemp : "n/a";
                    this.dataView.DataGrid.Rows[measurmentCounter++].Cells[DateColumn].Value = dateOfMeasurment;
                }
                frameCounter++;
            }
        }
    }
}
