using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class Trolleybus : Vehicle
    {
        public Trolleybus(string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            Brand = brand;
            Fuel = fuel;
            StartSpeed = startSpeed;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TankVolume = tankVolume;
            NumberOfPassengers = numberOfPassengers;

            Type = "Троллейбус";
            NumberOfDoors = 3;
            NumberOfWheels = 4;
            Propeller = "Электродвигатель";
            BasicPurpose = "Пассажирское ТС";
            Alarm = true;
            BrakingSystem = true;
            Lighting = true;
            LiftingCapacity = 12000;
            Trailer = false;
            GasStation(TankVolume);
        }
    }
}
