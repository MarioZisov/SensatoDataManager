namespace SensatoClient.Views
{
    partial class DataView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dateEnd = new MetroFramework.Controls.MetroDateTime();
            this.dateStart = new MetroFramework.Controls.MetroDateTime();
            this.labelStart = new MetroFramework.Controls.MetroLabel();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outside = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.underTheRoof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frame1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.framePos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridData = new MetroFramework.Controls.MetroGrid();
            this.labelEnd = new MetroFramework.Controls.MetroLabel();
            this.buttonShow = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(64, 72);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(700, 2);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dateEnd
            // 
            this.dateEnd.Enabled = false;
            this.dateEnd.Location = new System.Drawing.Point(465, 91);
            this.dateEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(207, 29);
            this.dateEnd.TabIndex = 3;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(164, 91);
            this.dateStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(207, 29);
            this.dateStart.TabIndex = 2;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelStart.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelStart.Location = new System.Drawing.Point(105, 91);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(53, 25);
            this.labelStart.TabIndex = 4;
            this.labelStart.Text = "Start:";
            // 
            // date
            // 
            this.date.HeaderText = "     Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 70;
            // 
            // time
            // 
            this.time.HeaderText = "    Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.time.Width = 70;
            // 
            // outside
            // 
            this.outside.HeaderText = "Outside T";
            this.outside.Name = "outside";
            this.outside.ReadOnly = true;
            this.outside.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.outside.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.outside.Width = 60;
            // 
            // underTheRoof
            // 
            this.underTheRoof.HeaderText = "Under the roof T";
            this.underTheRoof.Name = "underTheRoof";
            this.underTheRoof.ReadOnly = true;
            this.underTheRoof.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.underTheRoof.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.underTheRoof.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Inactive";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 60;
            // 
            // frame7
            // 
            this.frame7.HeaderText = "Inactive";
            this.frame7.Name = "frame7";
            this.frame7.ReadOnly = true;
            this.frame7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frame7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frame7.Width = 60;
            // 
            // frame6
            // 
            this.frame6.Frozen = true;
            this.frame6.HeaderText = "Inactive";
            this.frame6.Name = "frame6";
            this.frame6.ReadOnly = true;
            this.frame6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frame6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frame6.Width = 60;
            // 
            // frame5
            // 
            this.frame5.Frozen = true;
            this.frame5.HeaderText = "Inactive";
            this.frame5.Name = "frame5";
            this.frame5.ReadOnly = true;
            this.frame5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frame5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frame5.Width = 60;
            // 
            // frame4
            // 
            this.frame4.Frozen = true;
            this.frame4.HeaderText = "Inactive";
            this.frame4.Name = "frame4";
            this.frame4.ReadOnly = true;
            this.frame4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frame4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frame4.Width = 60;
            // 
            // frame3
            // 
            this.frame3.Frozen = true;
            this.frame3.HeaderText = "Inactive";
            this.frame3.Name = "frame3";
            this.frame3.ReadOnly = true;
            this.frame3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frame3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frame3.Width = 60;
            // 
            // frame2
            // 
            this.frame2.Frozen = true;
            this.frame2.HeaderText = "Inactive";
            this.frame2.Name = "frame2";
            this.frame2.ReadOnly = true;
            this.frame2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frame2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frame2.Width = 60;
            // 
            // frame1
            // 
            this.frame1.Frozen = true;
            this.frame1.HeaderText = "Inactive";
            this.frame1.Name = "frame1";
            this.frame1.ReadOnly = true;
            this.frame1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frame1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.frame1.Width = 60;
            // 
            // framePos
            // 
            this.framePos.Frozen = true;
            this.framePos.HeaderText = "Frame Position";
            this.framePos.Name = "framePos";
            this.framePos.ReadOnly = true;
            this.framePos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.framePos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.framePos.Width = 60;
            // 
            // gridData
            // 
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.framePos,
            this.frame1,
            this.frame2,
            this.frame3,
            this.frame4,
            this.frame5,
            this.frame6,
            this.frame7,
            this.Column8,
            this.underTheRoof,
            this.outside,
            this.time,
            this.date});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridData.Location = new System.Drawing.Point(23, 139);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(864, 361);
            this.gridData.TabIndex = 1;
            this.gridData.UseCustomBackColor = true;
            this.gridData.UseCustomForeColor = true;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelEnd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelEnd.Location = new System.Drawing.Point(413, 91);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(46, 25);
            this.labelEnd.TabIndex = 5;
            this.labelEnd.Text = "End:";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(717, 91);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(101, 29);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseSelectable = true;
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 523);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.gridData);
            this.Name = "DataView";
            this.Text = "DataView";
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dateEnd;
        private MetroFramework.Controls.MetroDateTime dateStart;
        private MetroFramework.Controls.MetroLabel labelStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn outside;
        private System.Windows.Forms.DataGridViewTextBoxColumn underTheRoof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame7;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame6;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame5;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame4;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame3;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame2;
        private System.Windows.Forms.DataGridViewTextBoxColumn frame1;
        private System.Windows.Forms.DataGridViewTextBoxColumn framePos;
        private MetroFramework.Controls.MetroGrid gridData;
        private MetroFramework.Controls.MetroLabel labelEnd;
        private MetroFramework.Controls.MetroButton buttonShow;
    }
}