using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Cart : Vehicle
    {
        public Cart(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Гужевая повозка";
            NumberOfDoors = 0;
            NumberOfWheels = 4;
            Propeller = "Лошадь";
            BasicPurpose = "Пассажирское/грузовое ТС";
            Alarm = false;
            BrakingSystem = false;
            Lighting = false;
            LiftingCapacity = 600;
            Trailer = false;
            GasStation(TankVolume);
        }
    }
}
