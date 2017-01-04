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
using MetroFramework.Controls;

namespace SensatoClient.Views
{
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

        public MetroProgressSpinner Spinner
        {
            get
            {
                return this.progressSpinner;
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
