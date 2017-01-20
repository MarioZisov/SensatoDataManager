namespace SensatoClient.Views
{
    partial class ReportView
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
            this.textBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.textBoxSubject = new MetroFramework.Controls.MetroTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSend = new MetroFramework.Controls.MetroButton();
            this.textBoxMessage = new MetroFramework.Controls.MetroTextBox();
            this.labelLoading = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            // 
            // 
            // 
            this.textBoxEmail.CustomButton.Image = null;
            this.textBoxEmail.CustomButton.Location = new System.Drawing.Point(385, 1);
            this.textBoxEmail.CustomButton.Name = "";
            this.textBoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxEmail.CustomButton.TabIndex = 1;
            this.textBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxEmail.CustomButton.UseSelectable = true;
            this.textBoxEmail.CustomButton.Visible = false;
            this.textBoxEmail.Lines = new string[0];
            this.textBoxEmail.Location = new System.Drawing.Point(41, 85);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.ShortcutsEnabled = true;
            this.textBoxEmail.Size = new System.Drawing.Size(407, 23);
            this.textBoxEmail.Style = MetroFramework.MetroColorStyle.Yellow;
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.UseSelectable = true;
            this.textBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxSubject
            // 
            // 
            // 
            // 
            this.textBoxSubject.CustomButton.Image = null;
            this.textBoxSubject.CustomButton.Location = new System.Drawing.Point(385, 1);
            this.textBoxSubject.CustomButton.Name = "";
            this.textBoxSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSubject.CustomButton.TabIndex = 1;
            this.textBoxSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSubject.CustomButton.UseSelectable = true;
            this.textBoxSubject.CustomButton.Visible = false;
            this.textBoxSubject.Lines = new string[0];
            this.textBoxSubject.Location = new System.Drawing.Point(41, 142);
            this.textBoxSubject.MaxLength = 32767;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.PasswordChar = '\0';
            this.textBoxSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSubject.SelectedText = "";
            this.textBoxSubject.SelectionLength = 0;
            this.textBoxSubject.SelectionStart = 0;
            this.textBoxSubject.ShortcutsEnabled = true;
            this.textBoxSubject.Size = new System.Drawing.Size(407, 23);
            this.textBoxSubject.Style = MetroFramework.MetroColorStyle.Yellow;
            this.textBoxSubject.TabIndex = 1;
            this.textBoxSubject.UseSelectable = true;
            this.textBoxSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(38, 69);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(38, 126);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 4;
            this.labelSubject.Text = "Subject";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(38, 184);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Message";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(129, 315);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(240, 22);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseSelectable = true;
            // 
            // textBoxMessage
            // 
            // 
            // 
            // 
            this.textBoxMessage.CustomButton.Image = null;
            this.textBoxMessage.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.textBoxMessage.CustomButton.Name = "";
            this.textBoxMessage.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.textBoxMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxMessage.CustomButton.TabIndex = 1;
            this.textBoxMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxMessage.CustomButton.UseSelectable = true;
            this.textBoxMessage.CustomButton.Visible = false;
            this.textBoxMessage.Lines = new string[0];
            this.textBoxMessage.Location = new System.Drawing.Point(41, 200);
            this.textBoxMessage.MaxLength = 32767;
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.PasswordChar = '\0';
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxMessage.SelectedText = "";
            this.textBoxMessage.SelectionLength = 0;
            this.textBoxMessage.SelectionStart = 0;
            this.textBoxMessage.ShortcutsEnabled = true;
            this.textBoxMessage.Size = new System.Drawing.Size(407, 109);
            this.textBoxMessage.Style = MetroFramework.MetroColorStyle.Yellow;
            this.textBoxMessage.TabIndex = 7;
            this.textBoxMessage.UseSelectable = true;
            this.textBoxMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelLoading
            // 
            this.labelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.labelLoading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelLoading.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelLoading.Location = new System.Drawing.Point(-1, 126);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(488, 58);
            this.labelLoading.TabIndex = 9;
            this.labelLoading.Text = "Sending, please wait...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLoading.UseCustomBackColor = true;
            this.labelLoading.Visible = false;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 349);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "ReportView";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Contact us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBoxEmail;
        private MetroFramework.Controls.MetroTextBox textBoxSubject;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelMessage;
        private MetroFramework.Controls.MetroButton buttonSend;
        private MetroFramework.Controls.MetroTextBox textBoxMessage;
        private MetroFramework.Controls.MetroLabel labelLoading;
    }
}