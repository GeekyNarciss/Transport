using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class Scooter : Vehicle
    {
        public Scooter(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Самокат";
            NumberOfDoors = 0;
            NumberOfWheels = 2;
            Propeller = "Человек";
            BasicPurpose = "Пассажирское ТС";
            Alarm = false;
            BrakingSystem = false;
            Lighting = false;
            LiftingCapacity = 120;
            Trailer = false;
            GasStation(TankVolume);
        }
    }
}
