using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Models;
using AppContext = Models.AppContext;

namespace Presenter
{
    public class LogPresenter
    {
        private ILogView _view;
        public LogPresenter(ILogView view)
        {
            _view = view;
            _view.SetLogs(AppContext.Vehicles[0].LogString);
            //_view.SetLogs(AppContext.Vehicles[1].LogString);
            //_view.SetLogs(AppContext.Vehicles[2].LogString);
            //_view.SetLogs(AppContext.Vehicles[3].LogString);
            //_view.SetLogs(AppContext.Vehicles[4].LogString);
        }
    }
}
