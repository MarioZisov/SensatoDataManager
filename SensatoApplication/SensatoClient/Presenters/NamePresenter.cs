namespace SensatoClient.Presenters
{
    using System;
    using System.Linq;
    using System.ServiceModel;
    using Contracts;
    using MetroFramework.Controls;
    using Models;
    using SensatoServiceReference;

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
        }

        protected override void SubscribeEvents()
        {
            throw new NotImplementedException();
        }

        public void AddInitialize()
        {
            this.nameView.SaveButtonClick += this.OnAddSaveButtonClick;
            this.nameView.CancelButtonClick += this.OnCancelButtonClick;
            this.nameView.HideError();
            this.nameView.BringToFront();
        }

        public void RenameInitialize(string currentHiveName)
        {
            this.nameView.SaveButtonClick += this.OnRenameSaveButtonClick;
            this.nameView.CancelButtonClick += this.OnCancelButtonClick;
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
                var hive = this.User.Hives.FirstOrDefault(h => h.Name == this.currentHiveName);
                this.serviceClient.RenameHive(this.User.Username, newHiveName, this.currentHiveName);
                hive.Name = newHiveName;

                this.RenameSaveComplete?.Invoke(sender, EventArgs.Empty);
                this.nameView.HiveName = string.Empty;
                
                this.UnsubscribeMethods();
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
                
                this.UnsubscribeMethods();
            }
            catch (FaultException<AlreadyExistFault> aef)
            {
                this.nameView.ErrorText = aef.Detail.Message;
                this.nameView.ShowError();
            }
        }

        private void OnCancelButtonClick(object sender, EventArgs e)
        {
            this.UnsubscribeMethods();

            this.nameView.HideError();
            this.nameView.HiveName = string.Empty;
            this.Cancel?.Invoke(sender, EventArgs.Empty);
        }

        private void UnsubscribeMethods()
        {
            this.nameView.SaveButtonClick -= this.OnAddSaveButtonClick;
            this.nameView.SaveButtonClick -= this.OnRenameSaveButtonClick;
            this.nameView.CancelButtonClick -= this.OnCancelButtonClick;
        }
    }
}