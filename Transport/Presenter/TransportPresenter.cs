using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Models;
using Transport.View;

namespace Transport.Presenter
{
    class TransportPresenter
    {
        private ITransportView _view;
        public TransportPresenter(ITransportView view)
        {
            _view = view;
        }
        public void OpenFormWithCreatingFuel()
        {
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        public void OpenFormWithCreatingVehicles()
        {
            Vehicles vehicle = new Vehicles();
            vehicle.FormClosed += ShowVehicles;
            vehicle.ShowDialog();
        }

        public void ShowVehicles(object sender, EventArgs e)
        {
            List<VehicleDisplay> vehicleInForms = new List<VehicleDisplay>();
            var vehicles = Models.AppContext.Vehicles;
            var pictureBoxes = _view.GetPickureBoxWithVeclise();
            vehicleInForms.Add(new VehicleDisplay(vehicles[0], pictureBoxes[0]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[1], pictureBoxes[1]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[2], pictureBoxes[2]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[3], pictureBoxes[3]));
            vehicleInForms.Add(new VehicleDisplay(vehicles[4], pictureBoxes[4]));

            Models.AppContext.VehicleDisplay = vehicleInForms;
        }

        public void Start()
        {
            Models.AppContext.VehicleDisplay.ForEach(v => v.Launch());
        }
    }
}
