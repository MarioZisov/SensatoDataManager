using SensatoClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenters
{
    public class SetTimePresenter : AbstractPresenter
    {
        private SetTimeView timeView;

        public event EventHandler ViewCancelButtonClick;

        public SetTimePresenter(SetTimeView timeView)
        {
            this.timeView = timeView;
        }

        public void Initialize()
        {
            this.timeView.BringToFront();
            this.SubscribeEvents();
        }

        protected override void SubscribeEvents()
        {
            this.timeView.SetClick += OnSetClick;
            this.timeView.CancelClick += delegate
            {
                this.ViewCancelButtonClick.Invoke(this, EventArgs.Empty);
            };
        }

        private void OnSetClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
