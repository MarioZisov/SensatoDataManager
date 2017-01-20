using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensatoClient.Contracts
{
    public interface IReportView : IView
    {
        event EventHandler SendClick;

        string UserEmail { get; }

        string Subject { get; }

        string Message { get; }

        MetroLabel LoadLabel { get; }

        void Show();

        void Close();
    }
}
