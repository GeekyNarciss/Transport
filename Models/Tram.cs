using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Tram : Vehicle
    {
        public Tram(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Трамвай";
            NumberOfDoors = 3;
            NumberOfWheels = 8;
            Propeller = "Электродвигатель";
            BasicPurpose = "Пассажирское ТС";
            Alarm = true;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 20000;
            Trailer = true;
            GasStation(TankVolume);
        }
    }
}
