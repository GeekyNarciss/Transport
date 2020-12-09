using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Car : Vehicle
    {
        public Car(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Автомобиль";
            NumberOfDoors = 4;
            NumberOfWheels = 4;
            Propeller = "ДВС";
            BasicPurpose = "Пассажирское ТС";
            Alarm = true;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 600;
            Trailer = true;
            GasStation(TankVolume);
        }
    }
}
