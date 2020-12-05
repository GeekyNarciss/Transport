using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class Tank : Vehicle
    {
        public Tank(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Танк";
            NumberOfDoors = 3;
            NumberOfWheels = 2;
            Propeller = "ДВС";
            BasicPurpose = "Военное ТС";
            Alarm = false;
            BrakingSystem = true;
            Lighting = false;
            LiftingCapacity = 20000;
            Trailer = true;
            GasStation(TankVolume);
        }
    }
}
