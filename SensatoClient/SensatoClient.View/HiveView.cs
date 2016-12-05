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

namespace SensatoClient.View
{
    public partial class HiveView : MetroUserControl
    {
        public HiveView()
        {
            InitializeComponent();
        }        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var control = new MetroTile
            {
                Width = 90,
                Height = 90
            };

            Padding p = new Padding(5);
            control.Padding = p;
            tableLayoutPanel2.Height += 100;

            //tableLayoutPanel2.Controls.Add(control, 0, 1);

            //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));

            tableLayoutPanel2.Controls.Add(control, 1, 3);
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }
    }
}
