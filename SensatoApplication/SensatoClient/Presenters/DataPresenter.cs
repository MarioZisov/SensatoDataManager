

namespace SensatoClient.Presenters
{
    using Contracts;
    using SensatoServiceReference;
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
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
        private bool rowColorFlag = true;
        private Color colorSectorA = Color.Yellow;
        private Color colorSectorB = Color.White;

        public DataPresenter(IDataView dataView)
        {
            this.dataView = dataView;
            this.client = new SensatoServiceClient();
            this.SubscribeEvents();
        }

        public void InitializeData(string hiveName)
        {
            this.dataView.Show();
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

        //TODO: Implement progress spinner for cooler loading
        private void ManageMeasurments(FrameDTO[] framesWithMeasurments)
        {
            int frameCounter = 1;

            int maxMeasurments = framesWithMeasurments.Max(f => f.Measurments.Count());
            for (int i = 1; i < maxMeasurments * NumberOfSensorsOnFrame; i++)
            {
                this.dataView.DataGrid.Rows.Add();
            }

            foreach (var frameWithMeasurments in framesWithMeasurments)
            {
                int measurmentCounter = 0;
                int framePos = frameWithMeasurments.Position;

                this.dataView.DataGrid.Columns[frameCounter].HeaderText = "Position " + framePos;                

                foreach (var measurmentDto in frameWithMeasurments.Measurments)
                {
                    string fristTemp = measurmentDto.FirstSensorTemp.ToString();
                    string secondTemp = measurmentDto.SecondSensorTemp.ToString();
                    string thirdTemp = measurmentDto.ThirdSensorTemp.ToString();
                    string outsideTemp = measurmentDto.OutsideTemp.ToString();
                    string dateOfMeasurment = measurmentDto.DateTimeOfMeasurment.Date.ToString("d");
                    string timeOfMeasurment = measurmentDto.DateTimeOfMeasurment.TimeOfDay.Hours.ToString();

                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.BackColor =
                        rowColorFlag ? this.colorSectorA : this.colorSectorB;
                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FramePositionColumn].Value = "Sensor 1: ";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FrameColumn + frameCounter].Value = fristTemp;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[OutsideColumn].Value =
                        !string.IsNullOrEmpty(outsideTemp) ? outsideTemp : "n/a";
                    this.dataView.DataGrid.Rows[measurmentCounter++].Cells[DateColumn].Value = dateOfMeasurment;

                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.BackColor =
                        rowColorFlag ? this.colorSectorA : this.colorSectorB;
                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FramePositionColumn].Value = "Sensor 2: ";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FrameColumn + frameCounter].Value = secondTemp;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[OutsideColumn].Value =
                        !string.IsNullOrEmpty(outsideTemp) ? outsideTemp : "n/a";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[TimeColumn].Value = timeOfMeasurment + "h";
                    this.dataView.DataGrid.Rows[measurmentCounter++].Cells[DateColumn].Value = dateOfMeasurment;

                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.BackColor =
                        rowColorFlag ? this.colorSectorA : this.colorSectorB;
                    this.dataView.DataGrid.Rows[measurmentCounter].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FramePositionColumn].Value = "Sensor 3: ";
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[FrameColumn + frameCounter].Value = thirdTemp;
                    this.dataView.DataGrid.Rows[measurmentCounter].Cells[OutsideColumn].Value =
                        !string.IsNullOrEmpty(outsideTemp) ? outsideTemp : "n/a";
                    this.dataView.DataGrid.Rows[measurmentCounter++].Cells[DateColumn].Value = dateOfMeasurment;

                    this.rowColorFlag = !rowColorFlag;
                }

                frameCounter++;
            }
        }
    }
}