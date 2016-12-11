using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Contracts
{
    public interface INameView : IView
    {
        event EventHandler SaveButtonClick;

        event EventHandler CancelButtonClick;

        string HiveName { get; set; }

        string ErrorText { get; set; }

        void ShowError();

        void HideError();
    }
}
