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
        MetroPanel FramesPanel { get; }

        event EventHandler FrameButtonClick;       
    }
}
