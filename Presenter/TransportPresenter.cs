using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using View;
using AppContext = Models.AppContext;

namespace Presenter
{
    public class TransportPresenter
    {
        private ITransportView _view;
        public TransportPresenter(ITransportView view)
        {
            _view = view;
        }

        public void ShowVehicles(object sender, EventArgs e)
        {
            List<VehicleDisplay> vehicleInForms = new List<VehicleDisplay>();
            var vehicles = Models.AppContext.Vehicles;
            var pictureBoxes = _view.GetPictureBoxWithVehicle();
            var toolStripProgressBars = _view.GetProgressBArList();
            var vehicleLogs = _view.GetVehiclelogs();
           

            vehicleInForms.Add(new VehicleDisplay(vehicles[0], pictureBoxes[0], toolStripProgressBars[0], vehicleLogs[0]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[1], pictureBoxes[1], toolStripProgressBars[1], vehicleLogs[1]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[2], pictureBoxes[2], toolStripProgressBars[2], vehicleLogs[2]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[3], pictureBoxes[3], toolStripProgressBars[3], vehicleLogs[3]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[4], pictureBoxes[4], toolStripProgressBars[4], vehicleLogs[4]));

            Models.AppContext.VehicleDisplay = vehicleInForms;
        }

        public void Start()
        {
            Models.AppContext.VehicleDisplay.ForEach(v => v.Launch());
        }

        public void Stop()
        {
            AppContext.VehicleDisplay.ForEach(v => v.Stop());
        }

        public void Log()
        {
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
            if (_view.TxtChecked() == true)
            {
                System.IO.File.WriteAllLines($@".\Log_{DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss")}.txt",
                    logs.ToArray());
            }

            if (_view.DocChecked() == true)
            {
                System.IO.File.WriteAllLines($@".\Log_{DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss")}.doc",
                    logs.ToArray());
            }
        }
    }
}
