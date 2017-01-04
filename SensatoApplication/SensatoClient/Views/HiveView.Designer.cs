namespace SensatoClient.Views
{
    partial class HiveView
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
            this.buttonData = new MetroFramework.Controls.MetroButton();
            this.buttonFrame = new MetroFramework.Controls.MetroButton();
            this.buttonRename = new MetroFramework.Controls.MetroButton();
            this.buttonRemove = new MetroFramework.Controls.MetroButton();
            this.buttonAddHive = new MetroFramework.Controls.MetroButton();
            this.buttonLogout = new MetroFramework.Controls.MetroButton();
            this.textBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tablePanelHives = new System.Windows.Forms.TableLayoutPanel();
            this.panelHiveControls = new MetroFramework.Controls.MetroPanel();
            this.buttonAddData = new MetroFramework.Controls.MetroButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroPanel1.SuspendLayout();
            this.panelHiveControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonData
            // 
            this.buttonData.Location = new System.Drawing.Point(3, 9);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(132, 31);
            this.buttonData.TabIndex = 2;
            this.buttonData.Text = "Data";
            this.buttonData.UseSelectable = true;
            // 
            // buttonFrame
            // 
            this.buttonFrame.Location = new System.Drawing.Point(3, 48);
            this.buttonFrame.Name = "buttonFrame";
            this.buttonFrame.Size = new System.Drawing.Size(132, 31);
            this.buttonFrame.TabIndex = 3;
            this.buttonFrame.Text = "Frame";
            this.buttonFrame.UseSelectable = true;
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(3, 85);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(132, 31);
            this.buttonRename.TabIndex = 4;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseSelectable = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(3, 122);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 31);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseSelectable = true;
            // 
            // buttonAddHive
            // 
            this.buttonAddHive.Location = new System.Drawing.Point(3, 237);
            this.buttonAddHive.Name = "buttonAddHive";
            this.buttonAddHive.Size = new System.Drawing.Size(129, 31);
            this.buttonAddHive.TabIndex = 6;
            this.buttonAddHive.Text = "Add Hive";
            this.buttonAddHive.UseSelectable = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(3, 374);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(132, 31);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseSelectable = true;
            // 
            // textBoxSearch
            // 
            // 
            // 
            // 
            this.textBoxSearch.CustomButton.Image = null;
            this.textBoxSearch.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.textBoxSearch.CustomButton.Name = "";
            this.textBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSearch.CustomButton.TabIndex = 1;
            this.textBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSearch.CustomButton.UseCustomBackColor = true;
            this.textBoxSearch.CustomButton.UseSelectable = true;
            this.textBoxSearch.CustomButton.Visible = false;
            this.textBoxSearch.Lines = new string[0];
            this.textBoxSearch.Location = new System.Drawing.Point(3, 274);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PromptText = "Search hives...";
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.ShowClearButton = true;
            this.textBoxSearch.Size = new System.Drawing.Size(129, 23);
            this.textBoxSearch.Style = MetroFramework.MetroColorStyle.Yellow;
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.UseSelectable = true;
            this.textBoxSearch.WaterMark = "Search hives...";
            this.textBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.progressSpinner);
            this.metroPanel1.Controls.Add(this.tablePanelHives);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(210, 17);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(587, 388);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tablePanelHives
            // 
            this.tablePanelHives.BackColor = System.Drawing.Color.White;
            this.tablePanelHives.ColumnCount = 5;
            this.tablePanelHives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tablePanelHives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tablePanelHives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tablePanelHives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tablePanelHives.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tablePanelHives.Location = new System.Drawing.Point(3, 3);
            this.tablePanelHives.Name = "tablePanelHives";
            this.tablePanelHives.RowCount = 1;
            this.tablePanelHives.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tablePanelHives.Size = new System.Drawing.Size(560, 0);
            this.tablePanelHives.TabIndex = 2;
            // 
            // panelHiveControls
            // 
            this.panelHiveControls.Controls.Add(this.buttonAddData);
            this.panelHiveControls.Controls.Add(this.buttonData);
            this.panelHiveControls.Controls.Add(this.buttonFrame);
            this.panelHiveControls.Controls.Add(this.buttonRename);
            this.panelHiveControls.Controls.Add(this.buttonRemove);
            this.panelHiveControls.Enabled = false;
            this.panelHiveControls.HorizontalScrollbarBarColor = true;
            this.panelHiveControls.HorizontalScrollbarHighlightOnWheel = false;
            this.panelHiveControls.HorizontalScrollbarSize = 10;
            this.panelHiveControls.Location = new System.Drawing.Point(0, 20);
            this.panelHiveControls.Name = "panelHiveControls";
            this.panelHiveControls.Size = new System.Drawing.Size(142, 192);
            this.panelHiveControls.TabIndex = 10;
            this.panelHiveControls.VerticalScrollbarBarColor = true;
            this.panelHiveControls.VerticalScrollbarHighlightOnWheel = false;
            this.panelHiveControls.VerticalScrollbarSize = 10;
            // 
            // buttonAddData
            // 
            this.buttonAddData.Location = new System.Drawing.Point(3, 158);
            this.buttonAddData.Name = "buttonAddData";
            this.buttonAddData.Size = new System.Drawing.Size(132, 31);
            this.buttonAddData.TabIndex = 6;
            this.buttonAddData.Text = "Add Data File";
            this.buttonAddData.UseSelectable = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // progressSpinner
            // 
            this.progressSpinner.Location = new System.Drawing.Point(173, 161);
            this.progressSpinner.Maximum = 100;
            this.progressSpinner.Name = "progressSpinner";
            this.progressSpinner.Size = new System.Drawing.Size(60, 60);
            this.progressSpinner.Spinning = false;
            this.progressSpinner.Style = MetroFramework.MetroColorStyle.Yellow;
            this.progressSpinner.TabIndex = 3;
            this.progressSpinner.UseSelectable = true;
            this.progressSpinner.Value = 100;
            this.progressSpinner.Visible = false;
            // 
            // HiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHiveControls);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAddHive);
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "HiveView";
            this.Size = new System.Drawing.Size(800, 428);
            this.UseSelectable = false;
            this.metroPanel1.ResumeLayout(false);
            this.panelHiveControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton buttonData;
        private MetroFramework.Controls.MetroButton buttonFrame;
        private MetroFramework.Controls.MetroButton buttonRename;
        private MetroFramework.Controls.MetroButton buttonRemove;
        private MetroFramework.Controls.MetroButton buttonAddHive;
        private MetroFramework.Controls.MetroButton buttonLogout;
        private MetroFramework.Controls.MetroTextBox textBoxSearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TableLayoutPanel tablePanelHives;
        private MetroFramework.Controls.MetroPanel panelHiveControls;
        private MetroFramework.Controls.MetroButton buttonAddData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroProgressSpinner progressSpinner;
    }
}
