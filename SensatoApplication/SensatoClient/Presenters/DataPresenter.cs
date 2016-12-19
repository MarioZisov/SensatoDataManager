using SensatoClient.Contracts;
using SensatoClient.SensatoServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenters
{
    public class DataPresenter : AbstractPresenter
    {
        private IDataView dataView;
        private SensatoServiceClient client;
        private string hiveName;

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
            var startDate = this.dataView.StartDate.Value;
            var endDate = this.dataView.EndDate.Value;

            var measurments = this.client.GetMeasurmentData(this.User.Username, this.hiveName, startDate, endDate);
        }
    }
}
