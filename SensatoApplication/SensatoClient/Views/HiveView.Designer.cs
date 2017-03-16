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
            this.buttonAddHive = new MetroFramework.Controls.MetroButton();
            this.buttonLogout = new MetroFramework.Controls.MetroButton();
            this.textBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tablePanelHives = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.buttonSetTime = new MetroFramework.Controls.MetroButton();
            this.buttonGetData = new MetroFramework.Controls.MetroButton();
            this.buttonShowNumber = new MetroFramework.Controls.MetroButton();
            this.buttonSetNumber = new MetroFramework.Controls.MetroButton();
            this.buttonCheckTime = new MetroFramework.Controls.MetroButton();
            this.tabPage = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.buttonAddData = new MetroFramework.Controls.MetroButton();
            this.buttonData = new MetroFramework.Controls.MetroButton();
            this.buttonFrame = new MetroFramework.Controls.MetroButton();
            this.buttonRename = new MetroFramework.Controls.MetroButton();
            this.buttonRemove = new MetroFramework.Controls.MetroButton();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddHive
            // 
            this.buttonAddHive.Location = new System.Drawing.Point(10, 281);
            this.buttonAddHive.Name = "buttonAddHive";
            this.buttonAddHive.Size = new System.Drawing.Size(129, 31);
            this.buttonAddHive.TabIndex = 6;
            this.buttonAddHive.Text = "Add Hive";
            this.buttonAddHive.UseSelectable = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(10, 364);
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
            this.textBoxSearch.Location = new System.Drawing.Point(10, 318);
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // progressSpinner
            // 
            this.progressSpinner.Location = new System.Drawing.Point(49, 113);
            this.progressSpinner.Maximum = 100;
            this.progressSpinner.Name = "progressSpinner";
            this.progressSpinner.Size = new System.Drawing.Size(60, 10);
            this.progressSpinner.Spinning = false;
            this.progressSpinner.Style = MetroFramework.MetroColorStyle.Yellow;
            this.progressSpinner.TabIndex = 3;
            this.progressSpinner.UseSelectable = true;
            this.progressSpinner.Value = 100;
            this.progressSpinner.Visible = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.buttonSetTime);
            this.metroTabPage2.Controls.Add(this.buttonGetData);
            this.metroTabPage2.Controls.Add(this.buttonShowNumber);
            this.metroTabPage2.Controls.Add(this.buttonSetNumber);
            this.metroTabPage2.Controls.Add(this.buttonCheckTime);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(146, 230);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Device";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // buttonSetTime
            // 
            this.buttonSetTime.Location = new System.Drawing.Point(3, 62);
            this.buttonSetTime.Name = "buttonSetTime";
            this.buttonSetTime.Size = new System.Drawing.Size(132, 31);
            this.buttonSetTime.TabIndex = 10;
            this.buttonSetTime.Text = "Set Device Time";
            this.buttonSetTime.UseSelectable = true;
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(3, 99);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(132, 31);
            this.buttonGetData.TabIndex = 9;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseSelectable = true;
            // 
            // buttonShowNumber
            // 
            this.buttonShowNumber.Location = new System.Drawing.Point(3, 173);
            this.buttonShowNumber.Name = "buttonShowNumber";
            this.buttonShowNumber.Size = new System.Drawing.Size(132, 31);
            this.buttonShowNumber.TabIndex = 8;
            this.buttonShowNumber.Text = "Show Hive Number";
            this.buttonShowNumber.UseSelectable = true;
            // 
            // buttonSetNumber
            // 
            this.buttonSetNumber.Location = new System.Drawing.Point(3, 136);
            this.buttonSetNumber.Name = "buttonSetNumber";
            this.buttonSetNumber.Size = new System.Drawing.Size(132, 31);
            this.buttonSetNumber.TabIndex = 7;
            this.buttonSetNumber.Text = "Set Hive Number";
            this.buttonSetNumber.UseSelectable = true;
            // 
            // buttonCheckTime
            // 
            this.buttonCheckTime.Location = new System.Drawing.Point(3, 28);
            this.buttonCheckTime.Name = "buttonCheckTime";
            this.buttonCheckTime.Size = new System.Drawing.Size(132, 31);
            this.buttonCheckTime.TabIndex = 6;
            this.buttonCheckTime.Text = "Check Device Time";
            this.buttonCheckTime.UseSelectable = true;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.metroPanel2);
            this.tabPage.HorizontalScrollbarBarColor = true;
            this.tabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage.HorizontalScrollbarSize = 10;
            this.tabPage.Location = new System.Drawing.Point(4, 38);
            this.tabPage.Name = "tabPage";
            this.tabPage.Size = new System.Drawing.Size(146, 230);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Hive";
            this.tabPage.VerticalScrollbarBarColor = true;
            this.tabPage.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.buttonAddData);
            this.metroPanel2.Controls.Add(this.buttonData);
            this.metroPanel2.Controls.Add(this.buttonFrame);
            this.metroPanel2.Controls.Add(this.buttonRename);
            this.metroPanel2.Controls.Add(this.buttonRemove);
            this.metroPanel2.Enabled = false;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 28);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(142, 192);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(154, 272);
            this.tabControl.TabIndex = 2;
            this.tabControl.UseSelectable = true;
            // 
            // HiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.progressSpinner);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonAddHive);
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "HiveView";
            this.Size = new System.Drawing.Size(800, 428);
            this.UseSelectable = false;
            this.metroPanel1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton buttonAddHive;
        private MetroFramework.Controls.MetroButton buttonLogout;
        private MetroFramework.Controls.MetroTextBox textBoxSearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TableLayoutPanel tablePanelHives;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroProgressSpinner progressSpinner;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton buttonSetTime;
        private MetroFramework.Controls.MetroButton buttonGetData;
        private MetroFramework.Controls.MetroButton buttonShowNumber;
        private MetroFramework.Controls.MetroButton buttonSetNumber;
        private MetroFramework.Controls.MetroButton buttonCheckTime;
        private MetroFramework.Controls.MetroTabPage tabPage;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton buttonAddData;
        private MetroFramework.Controls.MetroButton buttonData;
        private MetroFramework.Controls.MetroButton buttonFrame;
        private MetroFramework.Controls.MetroButton buttonRename;
        private MetroFramework.Controls.MetroButton buttonRemove;
        private MetroFramework.Controls.MetroTabControl tabControl;
    }
}
