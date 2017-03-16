namespace SensatoClient.Views
{
    using System;
    using MetroFramework.Controls;
    using Contracts;
    using System.Windows.Forms;
    using System.Linq;
    using System.Collections.Generic;

    public partial class HiveView : MetroUserControl, IHiveView
    {
        public event EventHandler LogoutClick;
        public event EventHandler HiveButtonClick;
        public event EventHandler AddHiveClick;
        public event EventHandler RenameHiveClick;
        public event EventHandler RemoveHiveClick;
        public event EventHandler FrameClick;
        public event EventHandler DataClick;
        public event EventHandler AddDataFileClick;
        public event EventHandler SearchTextChanged;

        public event EventHandler CheckTimeClick;
        public event EventHandler SetTimeClick;
        public event EventHandler GetDataClick;
        public event EventHandler SetNumberClick;
        public event EventHandler ShowNumberClick;


        public HiveView()
        {
            this.InitializeComponent();
            this.SubscribeViewButtons();
        }

        public TableLayoutPanel HivesTable
        {
            get
            {
                return this.tablePanelHives;
            }
        }

        public MetroPanel HiveControls
        {
            get
            {
                return this.metroPanel2;
            }
        }

        public OpenFileDialog FileDialog
        {
            get { return this.openFileDialog; }
        }

        public bool IsEnabled
        {
            get
            {
                return this.Enabled;
            }

            set
            {
                this.Enabled = value;
            }
        }

        public MetroProgressSpinner Spinner
        {
            get
            {
                return this.progressSpinner;
            }
        }

        MetroTabControl IHiveView.TabControl
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ResetHiveView()
        {
            this.HivesTable.Height = 0;
            this.HivesTable.Controls.Clear();

            this.HiveControls.Enabled = false;
        }

        public void SubscibeHiveButtons(IEnumerable<Control> buttonsToSubscribe)
        {
            foreach (MetroButton button in buttonsToSubscribe)
            {
                button.Click += delegate
                {
                    this.HiveButtonClick?.Invoke(button, EventArgs.Empty);
                };
            }
        }

        private void SubscribeViewButtons()
        {
            this.buttonLogout.Click += delegate
            {
                this.LogoutClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonAddHive.Click += delegate
            {
                this.AddHiveClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonRename.Click += delegate
            {
                this.RenameHiveClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonRemove.Click += delegate
            {
                this.RemoveHiveClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonFrame.Click += delegate
            {
                this.FrameClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonData.Click += delegate
            {
                this.DataClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonAddData.Click += delegate
            {
                this.AddDataFileClick?.Invoke(this, EventArgs.Empty);
            };

            this.textBoxSearch.TextChanged += delegate
            {
                this.SearchTextChanged?.Invoke(textBoxSearch, EventArgs.Empty);
            };

            this.buttonCheckTime.Click += delegate
            {
                this.CheckTimeClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonSetTime.Click += delegate
            {
                this.SetTimeClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonShowNumber.Click += delegate
            {
                this.ShowNumberClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonSetNumber.Click += delegate
            {
                this.SetNumberClick?.Invoke(this, EventArgs.Empty);
            };

            this.buttonGetData.Click += delegate
            {
                this.GetDataClick?.Invoke(this, EventArgs.Empty);
            };
        }
    }
}