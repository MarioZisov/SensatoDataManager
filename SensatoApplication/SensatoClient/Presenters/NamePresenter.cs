using MetroFramework.Controls;
using SensatoClient.Contracts;
using SensatoClient.Models;
using SensatoClient.SensatoServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenters
{
    public class NamePresenter : AbstractPresenter
    {
        private INameView nameView;
        private SensatoServiceClient serviceClient;
        private string currentHiveName;

        public event EventHandler RenameSaveComplete;
        public event EventHandler AddSaveComplete;
        public event EventHandler Cancel;

        public NamePresenter(INameView nameView)
        {
            this.nameView = nameView;
            this.serviceClient = new SensatoServiceClient();
            //SubscribeEvents();
        }

        protected override void SubscribeEvents()
        {
            throw new NotImplementedException();
        }

        public void AddInitialize()
        {
            this.nameView.SaveButtonClick += OnAddSaveButtonClick;
            this.nameView.CancelButtonClick += OnCancelButtonClick;
            this.nameView.HideError();
            this.nameView.BringToFront();
        }

        public void RenameInitialize(string currentHiveName)
        {
            this.nameView.SaveButtonClick += OnRenameSaveButtonClick;
            this.nameView.CancelButtonClick += OnCancelButtonClick;
            this.nameView.HideError();
            this.nameView.BringToFront();
            this.currentHiveName = currentHiveName;
        }

        private void OnRenameSaveButtonClick(object sender, EventArgs e)
        {
            this.nameView.HideError();
            MetroTextBox textBox = (MetroTextBox)sender;
            string newHiveName = textBox.Text;

            try
            {
                this.serviceClient.RenameHive(this.User.Username, newHiveName, currentHiveName);
                var hive = this.User.Hives.FirstOrDefault(h => h.Name == currentHiveName);
                hive.Name = newHiveName;

                this.RenameSaveComplete?.Invoke(sender, EventArgs.Empty);
                this.nameView.HiveName = string.Empty;

                this.nameView.SaveButtonClick -= OnRenameSaveButtonClick;
                this.nameView.CancelButtonClick -= OnCancelButtonClick;
            }
            catch (FaultException<AlreadyExistFault> aef)
            {
                this.nameView.ErrorText = aef.Detail.Message;
                this.nameView.ShowError();
            }
        }

        private void OnAddSaveButtonClick(object sender, EventArgs e)
        {
            this.nameView.HideError();
            MetroTextBox textBox = (MetroTextBox)sender;
            string hiveName = textBox.Text;

            try
            {
                this.serviceClient.AddHive(this.User.Username, hiveName);
                HiveModel hive = new HiveModel { Name = hiveName };
                this.User.Hives.Add(hive);

                this.AddSaveComplete?.Invoke(sender, EventArgs.Empty);
                this.nameView.HiveName = string.Empty;

                this.nameView.SaveButtonClick -= OnAddSaveButtonClick;
                this.nameView.CancelButtonClick -= OnCancelButtonClick;
            }
            catch (FaultException<AlreadyExistFault> aef)
            {
                this.nameView.ErrorText = aef.Detail.Message;
                this.nameView.ShowError();
            }
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            this.nameView.HideError();
            this.nameView.HiveName = string.Empty;
            this.Cancel?.Invoke(sender, EventArgs.Empty);
        }
    }
}