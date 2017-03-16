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
using SensatoClient.Contracts;

namespace SensatoClient.Views
{
    public partial class FrameView : MetroUserControl, IFrameView
    {
        public event EventHandler FrameButtonClick;
        public event EventHandler SaveButtonClick;
        public event EventHandler BackButtonClick;

        public FrameView()
        {
            InitializeComponent();
            this.SubscribeViewButtons();
        }

        public MetroPanel FramesPanel
        {
            get
            {
                return this.panelFrames;
            }
        }

        public string HiveName
        {
            get { return this.labelHiveName.Text; }
            set { this.labelHiveName.Text = value; }
        }

        private void SubscribeViewButtons()
        {
            var buttons = this.FramesPanel.Controls.OfType<MetroButton>();
            foreach (MetroButton button in buttons)
            {
                button.Click += delegate
                {
                    this.FrameButtonClick?.Invoke(button, EventArgs.Empty);
                };
            }

            buttonSave.Click += delegate
            {
                this.SaveButtonClick?.Invoke(this, EventArgs.Empty);
            };

            buttonBack.Click += delegate
            {
                this.BackButtonClick?.Invoke(this, EventArgs.Empty);
            };


        }
    }
}
