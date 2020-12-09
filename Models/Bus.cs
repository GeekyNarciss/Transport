using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Bus : Vehicle
    {
        public Bus(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Автобус";
            NumberOfDoors = 5;
            NumberOfWheels = 6;
            Propeller = "ДВС";
            BasicPurpose = "Пассажирское ТС";
            Alarm = true;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 20000;
            Trailer = false;
            GasStation(TankVolume);
        }
    }
}
