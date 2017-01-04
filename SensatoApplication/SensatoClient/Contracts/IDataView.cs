using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Contracts
{
    public interface IDataView : IView
    {
        event EventHandler ShowClick;

        event EventHandler StartDateChange;

        MetroGrid DataGrid { get; }

        MetroDateTime StartDate { get; }

        MetroDateTime EndDate { get; }

        MetroButton ShowButton { get; }

        void Show();
    }
}
