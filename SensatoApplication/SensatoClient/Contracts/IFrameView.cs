using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Contracts
{
    public interface IFrameView : IView
    {
        event EventHandler FrameButtonClick;

        event EventHandler SaveButtonClick;

        event EventHandler BackButtonClick;

        MetroPanel FramesPanel { get; }

        string HiveName { get; set; }
    }
}
