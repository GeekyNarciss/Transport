using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Models;
using Transport.View;

namespace Transport.Presenter
{
    class VehiclePresenter
    {
        private IVehicleView _view;
        public VehiclePresenter(IVehicleView view)
        {
            _view = view;
            _view.SetFuel(Models.AppContext.Fuels);
        }

        public void Submit()
        {
            Models.AppContext.Vehicles = new List<Vehicle>();

            for (int i = 0; i < 5; i++)
            {
                Models.AppContext.Vehicles.Add(new Car(
                    _view.GetBrandList()[i],
                    Models.AppContext.Fuels.Where(f => f.Name == _view.GetFuelList()[i]).FirstOrDefault(),
                    _view.GetStartSpeedList()[i],
                    _view.GetMaxSpeedList()[i],
                    _view.GetFuelConsumptionList()[i],
                    _view.GetFuelTankCapasityList()[i],
                    _view.GetNumderOfPasangersList()[i]
                ));
            }

            _view.CloseForm();
        }
    }
}
