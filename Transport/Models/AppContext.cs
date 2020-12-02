using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class AppContext
    {
        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public static List<Fuel> Fuels { get; set; } = new List<Fuel>();
        public static List<VehicleDisplay> VehicleDisplay { get; set; } = new List<VehicleDisplay>();
    }
}