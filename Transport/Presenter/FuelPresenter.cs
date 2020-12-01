using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Models;
using Transport.View;

namespace Transport.Presenter
{
    class FuelPresenter
    {
        private IFuelView _view;

        public FuelPresenter(IFuelView view)
        {
            _view = view;
        }

        public void Submit()
        {
            List<string> fuelNames = _view.GetListFuelNames();
            List<Models.Fuel> fuels = new List<Models.Fuel>();
            foreach (string name in fuelNames)
            {
                fuels.Add(new Models.Fuel { Name = name });
                Console.WriteLine(name);
            }

            Models.AppContext.Fuels = fuels;

            _view.CloseForm();
        }

        public void LoadFuel()
        {
            List<Models.Fuel> fuels = Models.AppContext.Fuels;
            if (fuels is null || fuels.Count == 0)
            {
                return;
            }

            List<string> fuelNames = new List<string>();
            for (int i = 0; i < fuels.Count; i++)
            {
                fuelNames.Add(fuels[i].Name);
            }
            _view.SetFuels(fuelNames);

        }
    }
}
