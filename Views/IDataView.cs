using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IDataView: IView
    {

        event EventHandler SaveClicked;

        void ShowError(string message);
    }
}
