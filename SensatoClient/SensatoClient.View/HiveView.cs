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

        private Point MouseDownLocation;
        bool isMove;

        Dictionary<TableLayoutPanelCellPosition, Rectangle> dict = new Dictionary<TableLayoutPanelCellPosition, Rectangle>();

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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_MouseDown(object sender, MouseEventArgs e)
        {
            Control button = sender as Control;
            metroTile3.Parent = this;
            metroTile3.BringToFront();            
            MouseDownLocation = e.Location;
        }

        private void metroTile3_MouseMove(object sender, MouseEventArgs e)
        {
            Control button = sender as Control;
            if (e.Button == MouseButtons.Left)
            {
                metroTile3.Left += e.X - MouseDownLocation.X;
                metroTile3.Top += e.Y - MouseDownLocation.Y;
                isMove = true;
                tableLayoutPanel2.Invalidate();
            }
        }

        private void Buttons_MouseUp(object sender, MouseEventArgs e)
        {
            Control button = sender as Control;
            if (isMove)
            {
                SetControl(button, e.Location);
                button.Parent = tableLayoutPanel1;
                isMove = false;
            }
        }

        private void SetControl(Control c, Point position)
        {
            Point localPoint = tableLayoutPanel2.PointToClient(c.PointToScreen(position));
            var keyValue = dict.FirstOrDefault(e => e.Value.Contains(localPoint));
            if (!keyValue.Equals(default(KeyValuePair<TableLayoutPanelCellPosition, Rectangle>)))
            {
                tableLayoutPanel2.SetCellPosition(c, keyValue.Key);
            }
        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            dict[new TableLayoutPanelCellPosition(e.Column, e.Row)] = e.CellBounds;
            if (isMove)
            {
                if (e.CellBounds.Contains(tableLayoutPanel1.PointToClient(MousePosition)))
                {
                    e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds);
                }
            }
        }
    }
}
