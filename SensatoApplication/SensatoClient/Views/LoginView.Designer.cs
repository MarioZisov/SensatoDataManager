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
            this.labelUsernameError = new MetroFramework.Controls.MetroLabel();
            this.labelPasswordError = new MetroFramework.Controls.MetroLabel();
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
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(116, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSelectable = true;
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
            // labelUsernameError
            // 
            this.labelUsernameError.AutoSize = true;
            this.labelUsernameError.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelUsernameError.ForeColor = System.Drawing.Color.Red;
            this.labelUsernameError.Location = new System.Drawing.Point(363, 311);
            this.labelUsernameError.Name = "labelUsernameError";
            this.labelUsernameError.Size = new System.Drawing.Size(70, 15);
            this.labelUsernameError.TabIndex = 5;
            this.labelUsernameError.Text = "metroLabel1";
            this.labelUsernameError.UseCustomForeColor = true;
            this.labelUsernameError.Visible = false;
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.AutoSize = true;
            this.labelPasswordError.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelPasswordError.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordError.Location = new System.Drawing.Point(363, 326);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.Size = new System.Drawing.Size(70, 15);
            this.labelPasswordError.TabIndex = 6;
            this.labelPasswordError.Text = "metroLabel2";
            this.labelPasswordError.UseCustomForeColor = true;
            this.labelPasswordError.Visible = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPasswordError);
            this.Controls.Add(this.labelUsernameError);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.tetBoxUsername);
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(800, 428);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tetBoxUsername;
        private MetroFramework.Controls.MetroTextBox textBoxPassword;
        private MetroFramework.Controls.MetroLabel labelUsername;
        private MetroFramework.Controls.MetroLabel labelPassword;
        private MetroFramework.Controls.MetroButton buttonLogin;
        private MetroFramework.Controls.MetroLabel labelUsernameError;
        private MetroFramework.Controls.MetroLabel labelPasswordError;
    }
}
