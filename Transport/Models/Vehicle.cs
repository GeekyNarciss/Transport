using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    class Vehicle
    {
        public string Brand { get; set; } = ""; //марка
        public string Type { get; set; } = ""; //тип ТС
        public int NumberOfDoors { get; set; } = 0; //количество дверей
        public int NumberOfOpenedDoors { get; set; } = 0; //количество открытых дверей
        public int NumberOfOpenedWindows { get; set; } = 0; //количество открытых окон
        public int NumberOfWheels { get; set; } = 0; //количество колёс
        public int NumberOfPassengers { get; set; } = 0; //количество пассажиров
        public int CurrentNumberOfPassengers { get; set; } = 0; //текущее количество пассажиров
        public string Propeller { get; set; } = ""; //движитель - чем приводится в движение (ДВС, человек, лошадь)
        public string BasicPurpose { get; set; } = ""; //для чего предназначено ТС (пассажирское, грузовое и др.)
        public bool Alarm { get; set; } = false; //сигнализация
        public bool BrakingSystem { get; set; } = false; //тормоза
        public bool Lighting { get; set; } = false; //наличие осветильных приборов(фар)
        public int LiftingCapacity { get; set; } = 100; //грузопоъемность
        public bool Trailer { get; set; } = false;//возможность подсоединения прицепа
        public int StartSpeed { get; set; } = 0; //стартовая скорость
        public int MaxSpeed { get; set; } = 0; //максимальная скорость
        public int CurrentSpeed { get; set; } = 0; //текущая скорость
        public Fuel Fuel { get; set; } //тип топлива
        public int TankVolume { get; set; } = 0;//объем бака
        public double CurrentFuelLevel { get; set; } = 0; //текущее количество топлива
        public double FuelConsumption { get; set; } = 0; //расход
        public bool CurrentState { get; set; } = false; //состояние ТС (стоит-false/в движении-true)
        private string LogFile { get; set; } = ""; //запись лога в строку


        protected void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToString()}: {Brand} - {message}");
        }

        public void DoorOpening()
        {
            if (NumberOfDoors > 0)
            {
                LogMessage("Дверь открыта");
                NumberOfOpenedDoors++;
            }
            else LogMessage("Двери отсутствуют");
        }

        public void DoorClosing()
        {
            if (NumberOfDoors > 0)
            {
                LogMessage("Дверь закрыта");
                NumberOfOpenedDoors--;
            }
            else LogMessage("Двери отсутствуют");
        }

        public void Start()
        {
            if (CurrentFuelLevel > 0)
            {
                if (NumberOfOpenedDoors == 0)
                {
                    LogMessage("Движение началось");
                    CurrentSpeed = StartSpeed;
                    CurrentState = true;
                }
                else LogMessage("Для Вашей безопасности, закройте все двери");
            }
            else LogMessage("Отсутствует топливо");
        }

        public void Stop()
        {
            LogMessage("Движение прекратилось");
            CurrentSpeed = 0;
            CurrentState = false;
        }

        public void WindowOpening()
        { 
            if (NumberOfDoors > 0)
            {
                if(NumberOfOpenedWindows < NumberOfDoors)
                    {
                    LogMessage("Окно открыто");
                    NumberOfOpenedWindows++;
                }
                else LogMessage("Все окна открыты");
            }
            else LogMessage("Окна отсутствуют");
        }

        public void WindowClosing()
        {
            if (NumberOfDoors > 0)
            {
                if (NumberOfOpenedWindows != 0)
                {
                    LogMessage("Окно закрыто");
                    NumberOfOpenedWindows--;
                }
                else LogMessage("Все окна закрыты");
            }
            else LogMessage("Окна отсутствуют");
        }

        public void SpeedChanger()
        {

        }

        public void PassengerTaking()
        {
            if(CurrentNumberOfPassengers < NumberOfPassengers)
            {
                LogMessage("+1 пассажир");
                CurrentNumberOfPassengers++;
            }
            else LogMessage("Достигнуто максимальное количество пассажиров");
        }

        public void PassengerDropping()
        {
            if (CurrentNumberOfPassengers > 0)
            {
                LogMessage("-1 пассажир");
                CurrentNumberOfPassengers--;
            }
            else LogMessage("Пассажиров больше нет");
        }

        public void GasStation(int liters)
        {
            if (CurrentFuelLevel + liters <= TankVolume)
            {
                CurrentFuelLevel += liters;
                LogMessage($"Бак пополнен на {liters} литр(ов). Текущий уровень топлива {CurrentFuelLevel} литров");
            }
            else
            {
                CurrentFuelLevel += TankVolume;
                LogMessage($"Бак полон, {TankVolume} литров");
            }
        }
    }
}
