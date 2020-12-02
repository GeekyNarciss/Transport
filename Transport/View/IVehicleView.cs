using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.View
{
    interface IVehicleView
    {
        List<string> GetBrandList();
        List<string> GetVehicleList();
        List<string> GetFuelList();
        List<double> GetFuelConsumptionList();
        List<int> GetFuelTankCapasityList();
        List<int> GetMaxSpeedList();
        List<int> GetStartSpeedList();
        List<int> GetNumderOfPasangersList();
        void SetFuel(List<Models.Fuel> fuels);
        void CloseForm();
    }
}
