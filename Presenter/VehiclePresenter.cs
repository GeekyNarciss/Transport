using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using View;

namespace Presenter
{
    public class VehiclePresenter
    {
        private IVehicleView _view;
        public VehiclePresenter(IVehicleView view)
        {
            _view = view;
            List<string> fuels = new List<string>();
            for (int i = 0; i < Models.AppContext.Fuels.Count; i++)
            {
                fuels.Add(Models.AppContext.Fuels[i].Name);
            }

            _view.SetFuel(fuels);
        }

        public void Submit()
        {
            Models.AppContext.Vehicles = new List<Vehicle>();

            for (int i = 0; i < 5; i++)
            {
                Models.AppContext.Vehicles.Add(ChoiseOfVehicle.CreateVehicle(
                    _view.GetVehicleList()[i],
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
