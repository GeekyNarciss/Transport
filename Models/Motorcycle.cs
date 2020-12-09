using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Мотоцикл";
            NumberOfDoors = 0;
            NumberOfWheels = 2;
            Propeller = "ДВС";
            BasicPurpose = "Пассажирское ТС";
            Alarm = true;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 400;
            Trailer = false;
            GasStation(TankVolume);
        }
    }
}
