using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class Loader : Vehicle
    {
        public Loader(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Погрузчик";
            NumberOfDoors = 0;
            NumberOfWheels = 4;
            Propeller = "Электродвигатель";
            BasicPurpose = "Вилочный погрузчик для склада";
            Alarm = true;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 6000;
            Trailer = false;
            GasStation(TankVolume);
        }
    }
}
