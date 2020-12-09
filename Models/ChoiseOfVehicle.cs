using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ChoiseOfVehicle
    {
        public static Vehicle CreateVehicle(string type, string brand, Fuel fuel, int startSpeed, int maxSpeed, double fuelConsumption, int tankVolume, int numberOfPassengers)
        {
            if (type == "Автомобиль")
            {
                return new Car(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }
            if (type == "Грузовик")
            {
                return new Truck(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Погрузчик")
            {
                return new Loader(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Автобус")
            {
                return new Bus(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Троллейбус")
            {
                return new Trolleybus(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Трамвай")
            {
                return new Tram(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Мотоцикл")
            {
                return new Motorcycle(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Гужевая повозка")
            {
                return new Cart(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Велосипед")
            {
                return new Bike(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }

            if (type == "Самокат")
            {
                return new Scooter(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            } 
            
            if (type == "Танк")
            {
                return new Tank(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
            }
            
            return new Car(brand, fuel, startSpeed, maxSpeed, fuelConsumption, tankVolume, numberOfPassengers);
        }
    }
}
