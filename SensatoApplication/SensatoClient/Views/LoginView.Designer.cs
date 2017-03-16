namespace SensatoClient.Views
{
    partial class LoginView
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
            this.tetBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.textBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.labelUsername = new MetroFramework.Controls.MetroLabel();
            this.labelPassword = new MetroFramework.Controls.MetroLabel();
            this.buttonLogin = new MetroFramework.Controls.MetroButton();
            this.labelError = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.labelReport = new MetroFramework.Controls.MetroLink();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tetBoxUsername
            // 
            // 
            // 
            // 
            this.tetBoxUsername.CustomButton.Image = null;
            this.tetBoxUsername.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.tetBoxUsername.CustomButton.Name = "";
            this.tetBoxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tetBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tetBoxUsername.CustomButton.TabIndex = 1;
            this.tetBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tetBoxUsername.CustomButton.UseSelectable = true;
            this.tetBoxUsername.CustomButton.Visible = false;
            this.tetBoxUsername.Lines = new string[0];
            this.tetBoxUsername.Location = new System.Drawing.Point(342, 158);
            this.tetBoxUsername.MaxLength = 32767;
            this.tetBoxUsername.Name = "tetBoxUsername";
            this.tetBoxUsername.PasswordChar = '\0';
            this.tetBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tetBoxUsername.SelectedText = "";
            this.tetBoxUsername.SelectionLength = 0;
            this.tetBoxUsername.SelectionStart = 0;
            this.tetBoxUsername.ShortcutsEnabled = true;
            this.tetBoxUsername.Size = new System.Drawing.Size(116, 23);
            this.tetBoxUsername.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tetBoxUsername.TabIndex = 0;
            this.tetBoxUsername.UseSelectable = true;
            this.tetBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tetBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            this.textBoxPassword.CustomButton.Image = null;
            this.textBoxPassword.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.textBoxPassword.CustomButton.Name = "";
            this.textBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPassword.CustomButton.TabIndex = 1;
            this.textBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPassword.CustomButton.UseSelectable = true;
            this.textBoxPassword.CustomButton.Visible = false;
            this.textBoxPassword.Lines = new string[0];
            this.textBoxPassword.Location = new System.Drawing.Point(342, 228);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(116, 23);
            this.textBoxPassword.Style = MetroFramework.MetroColorStyle.Yellow;
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSelectable = true;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(363, 136);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(68, 19);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(367, 204);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 19);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(342, 280);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(116, 28);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseSelectable = true;
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelError.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(0, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(800, 27);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "error";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.UseCustomForeColor = true;
            this.labelError.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.labelError);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 315);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(800, 27);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // labelReport
            // 
            this.labelReport.BackColor = System.Drawing.Color.Transparent;
            this.labelReport.ForeColor = System.Drawing.Color.Red;
            this.labelReport.Location = new System.Drawing.Point(354, 345);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(93, 23);
            this.labelReport.TabIndex = 8;
            this.labelReport.Text = "Report a bug";
            this.labelReport.UseCustomBackColor = true;
            this.labelReport.UseCustomForeColor = true;
            this.labelReport.UseSelectable = true;
            this.labelReport.MouseEnter += new System.EventHandler(this.labelReport_MouseEnter);
            this.labelReport.MouseLeave += new System.EventHandler(this.labelReport_MouseLeave);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(342, 87);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(116, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.tetBoxUsername);
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(800, 428);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tetBoxUsername;
        private MetroFramework.Controls.MetroTextBox textBoxPassword;
        private MetroFramework.Controls.MetroLabel labelUsername;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private MetroFramework.Controls.MetroButton buttonLogin;
        private MetroFramework.Controls.MetroLabel labelError;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink labelReport;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
