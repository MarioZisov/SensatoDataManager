namespace SensatoClient.Views
{
    partial class SetTimeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioAutomatic = new MetroFramework.Controls.MetroRadioButton();
            this.radioManually = new MetroFramework.Controls.MetroRadioButton();
            this.panelDateTime = new MetroFramework.Controls.MetroPanel();
            this.dropMinutes = new MetroFramework.Controls.MetroComboBox();
            this.dropHours = new MetroFramework.Controls.MetroComboBox();
            this.dateTime = new MetroFramework.Controls.MetroDateTime();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.buttonSet = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioAutomatic
            // 
            this.radioAutomatic.AutoSize = true;
            this.radioAutomatic.Location = new System.Drawing.Point(31, 28);
            this.radioAutomatic.Name = "radioAutomatic";
            this.radioAutomatic.Size = new System.Drawing.Size(268, 15);
            this.radioAutomatic.TabIndex = 0;
            this.radioAutomatic.Text = "Set date and time automatically (recomended)";
            this.radioAutomatic.UseSelectable = true;
            // 
            // radioManually
            // 
            this.radioManually.AutoSize = true;
            this.radioManually.Location = new System.Drawing.Point(31, 72);
            this.radioManually.Name = "radioManually";
            this.radioManually.Size = new System.Drawing.Size(167, 15);
            this.radioManually.TabIndex = 1;
            this.radioManually.Text = "Set date and time manually";
            this.radioManually.UseSelectable = true;
            // 
            // panelDateTime
            // 
            this.panelDateTime.Controls.Add(this.dropMinutes);
            this.panelDateTime.Controls.Add(this.dropHours);
            this.panelDateTime.Controls.Add(this.dateTime);
            this.panelDateTime.Enabled = false;
            this.panelDateTime.HorizontalScrollbarBarColor = true;
            this.panelDateTime.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDateTime.HorizontalScrollbarSize = 10;
            this.panelDateTime.Location = new System.Drawing.Point(31, 103);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(365, 71);
            this.panelDateTime.TabIndex = 2;
            this.panelDateTime.VerticalScrollbarBarColor = true;
            this.panelDateTime.VerticalScrollbarHighlightOnWheel = false;
            this.panelDateTime.VerticalScrollbarSize = 10;
            // 
            // dropMinutes
            // 
            this.dropMinutes.DropDownHeight = 160;
            this.dropMinutes.DropDownWidth = 50;
            this.dropMinutes.FormattingEnabled = true;
            this.dropMinutes.IntegralHeight = false;
            this.dropMinutes.ItemHeight = 23;
            this.dropMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.dropMinutes.Location = new System.Drawing.Point(294, 17);
            this.dropMinutes.Name = "dropMinutes";
            this.dropMinutes.Size = new System.Drawing.Size(59, 29);
            this.dropMinutes.TabIndex = 4;
            this.dropMinutes.UseSelectable = true;
            this.dropMinutes.UseStyleColors = true;
            // 
            // dropHours
            // 
            this.dropHours.DisplayFocus = true;
            this.dropHours.DropDownHeight = 160;
            this.dropHours.DropDownWidth = 5;
            this.dropHours.FormattingEnabled = true;
            this.dropHours.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dropHours.IntegralHeight = false;
            this.dropHours.ItemHeight = 23;
            this.dropHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.dropHours.Location = new System.Drawing.Point(229, 17);
            this.dropHours.Name = "dropHours";
            this.dropHours.Size = new System.Drawing.Size(59, 29);
            this.dropHours.TabIndex = 3;
            this.dropHours.UseSelectable = true;
            this.dropHours.UseStyleColors = true;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(13, 17);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 29);
            this.dateTime.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(89, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 34);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseSelectable = true;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(223, 193);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(96, 34);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 2);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.panel3.Location = new System.Drawing.Point(425, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 251);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 251);
            this.panel4.TabIndex = 8;
            // 
            // SetTimeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelDateTime);
            this.Controls.Add(this.radioManually);
            this.Controls.Add(this.radioAutomatic);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "SetTimeView";
            this.Size = new System.Drawing.Size(427, 251);
            this.panelDateTime.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton radioAutomatic;
        private MetroFramework.Controls.MetroRadioButton radioManually;
        private MetroFramework.Controls.MetroPanel panelDateTime;
        private MetroFramework.Controls.MetroDateTime dateTime;
        private MetroFramework.Controls.MetroComboBox dropMinutes;
        private MetroFramework.Controls.MetroComboBox dropHours;
        private MetroFramework.Controls.MetroButton buttonCancel;
        private MetroFramework.Controls.MetroButton buttonSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
