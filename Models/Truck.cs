using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class Truck : Vehicle
    {
        public Truck(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Грузовик";
            NumberOfDoors = 2;
            NumberOfWheels = 6;
            Propeller = "ДВС";
            BasicPurpose = "Грузовое ТС";
            Alarm = true;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 9000;
            Trailer = true;
            GasStation(TankVolume);
        }
    }
}
