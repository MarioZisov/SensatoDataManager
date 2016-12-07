using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Presenters
{
    public abstract class AbstractPresenter
    {
        protected abstract void SubscribeEvents();
    }
}
