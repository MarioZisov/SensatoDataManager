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
            this.back = new MetroFramework.Controls.MetroButton();
            this.forward = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(74, 176);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "metroButton1";
            this.back.UseSelectable = true;
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(614, 176);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(75, 23);
            this.forward.TabIndex = 1;
            this.forward.Text = "metroButton2";
            this.forward.UseSelectable = true;
            // 
            // HiveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "HiveView";
            this.Size = new System.Drawing.Size(800, 428);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton back;
        private MetroFramework.Controls.MetroButton forward;
    }
}
