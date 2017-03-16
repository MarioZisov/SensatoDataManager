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

        public SetTimePresenter(SetTimeView timeView)
        {
            this.timeView = timeView;
        }

        protected override void SubscribeEvents()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            this.timeView.BringToFront();
        }
    }
}
