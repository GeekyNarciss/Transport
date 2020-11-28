using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class Bike : Vehicle
    {
        public Bike(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Велосипед";
            NumberOfDoors = 0;
            NumberOfWheels = 2;
            Propeller = "Человек";
            BasicPurpose = "Пассажирское ТС";
            Alarm = false;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 150;
            Trailer = false;
            GasStation(TankVolume);
        }
    }
}
