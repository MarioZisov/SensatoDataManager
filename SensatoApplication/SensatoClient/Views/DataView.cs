namespace SensatoClient.Views
{
    using MetroFramework.Forms;
    using SensatoClient.Contracts;
    using System;
    using MetroFramework.Controls;

    public partial class DataView : MetroForm, IDataView
    {

        public event EventHandler ShowClick;
        public event EventHandler StartDateChange;

        public DataView()
        {
            InitializeComponent();
            SubscribeEvents();
        }        

        public MetroGrid DataGrid
        {
            get
            {
                return this.gridData;
            }
        }

        public MetroDateTime StartDate
        {
            get
            {
                return this.dateStart;
            }
        }

        public MetroDateTime EndDate
        {
            get
            {
                return this.dateEnd;
            }
        }

        public MetroButton ShowButton
        {
            get
            {
                return this.buttonShow;
            }
        }

        private void SubscribeEvents()
        {
            this.buttonShow.Click += delegate
            {
                this.ShowClick?.Invoke(this, EventArgs.Empty);
            };

            this.dateStart.ValueChanged += delegate
            {
                this.StartDateChange?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}
