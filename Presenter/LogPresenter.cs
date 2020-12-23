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
            List<string> logs = new List<string>();
            logs.Add("------ТС1----------------------------------------------------------------------------");
            logs.AddRange(AppContext.Vehicles[0].LogString);
            logs.Add("------ТС2----------------------------------------------------------------------------");
            logs.AddRange(AppContext.Vehicles[1].LogString);
            logs.Add("------ТС3----------------------------------------------------------------------------");
            logs.AddRange(AppContext.Vehicles[2].LogString);
            logs.Add("------ТС4----------------------------------------------------------------------------");
            logs.AddRange(AppContext.Vehicles[3].LogString);
            logs.Add("------ТС5----------------------------------------------------------------------------");
            logs.AddRange(AppContext.Vehicles[4].LogString);
            _view.SetLogs(logs) ;
            //_view.SetLogs(AppContext.Vehicles[1].LogString);
            //_view.SetLogs(AppContext.Vehicles[2].LogString);
            //_view.SetLogs(AppContext.Vehicles[3].LogString);
            //_view.SetLogs(AppContext.Vehicles[4].LogString);
        }
    }
}
