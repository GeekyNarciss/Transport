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
        public double StartSpeed { get; set; } = 0; //стартовая скорость
        public double MaxSpeed { get; set; } = 0; //максимальная скорость
        public double CurrentSpeed { get; set; } = 0; //текущая скорость
        public Fuel Fuel { get; set; } //тип топлива
        public int TankVolume { get; set; } = 0;//объем бака
        public double CurrentFuelLevel { get; set; } = 0; //текущее количество топлива
        public double FuelConsumption { get; set; } = 0; //расход
        public bool CurrentState { get; set; } = false; //состояние ТС (стоит-false/в движении-true)
        public double PassedWay { get; set; } = 0;
        public double Acceleration { get; set; } = 0;
        public double CurrentSpeedKmInH
        {
            get
            {
                return CurrentSpeed * 3.6;
            }

            set
            {
                CurrentSpeed = value / 3.6;
            }
        }
        public DateTime Time { get; set; }
        private string LogFile { get; set; } = ""; //запись лога в строку
        public List<string> LogString { get; private set; } = new List<string>();


        protected void LogMessage(string message)
        {
            //Console.WriteLine($"{DateTime.Now.ToString()}: {Brand} - {message}");
            string logString = $"{DateTime.Now.ToString()}: {Brand}  - {message}";
            Console.WriteLine(logString);
            LogString.Add(logString);
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
                    Acceleration = (MaxSpeed * MaxSpeed - StartSpeed * StartSpeed) / (TankVolume/ FuelConsumption * 100000.0);
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

        public void SpeedChangerUp(int kmph)
        {
            if (CurrentSpeed + kmph <= MaxSpeed)
            {
                CurrentSpeed += kmph;
                LogMessage($"Скорость увеличена на {kmph} км/ч. Текущая скорость {CurrentSpeed} км/ч");
            }
            else 
            {
                CurrentSpeed = MaxSpeed;
                LogMessage($"Достигнут максимум скорости, {MaxSpeed} км/ч");
            };
        }

        public void SpeedChangerDown(int kmph)
        {
            if (CurrentSpeed - kmph >= 0)
            {
                CurrentSpeed -= kmph;
                LogMessage($"Скорость снижена на {kmph} км/ч. Текущая скорость {CurrentSpeed} км/ч");
            }
            else
            {
                CurrentSpeed = 0;
                LogMessage($"ТС остановлено");
            };
        }

        //public void SpeedChanger(double s, double t, double a)
        //{
        //    s = (TankVolume / FuelConsumption) * 100;
        //    a = (MaxSpeed - StartSpeed)*(StartSpeed + MaxSpeed) / s; //по сути это параметр-константа, по которому картинка должна ускоряться до середины пути
        //}

        public void ChangeTheSpeedTo(double deltaSpeed)
        {
            if (CurrentSpeed == 0 && deltaSpeed > 0)
            {
                Start();
            }
            if (CurrentSpeed + deltaSpeed <= MaxSpeed && CurrentSpeed + deltaSpeed >= 0)
            {
                CurrentSpeed += deltaSpeed;
                LogMessage($"Текущая скорость изменилась на {deltaSpeed}. Текущая скорость сейчас {CurrentSpeed}.");
            }
            else if (CurrentSpeed == MaxSpeed)
            {
                LogMessage("ТС движется с максимальной скоростью.");
            }
            else if (CurrentSpeed == 0)
            {
                LogMessage("ТС не может замедлиться, потому что оно уже стоит.");
            }
            else if (CurrentSpeed + deltaSpeed > MaxSpeed)
            {
                CurrentSpeed = MaxSpeed;
                LogMessage($"Текущая скорость изменилась на {MaxSpeed - CurrentSpeed}. Текущая скорость сейчас {MaxSpeed}.");
            }
            else if (CurrentSpeed - deltaSpeed < 0)
            {
                CurrentSpeed = 0;
                LogMessage($"Текущая скорость изменилась на {CurrentSpeed}. Текущая скорость сейчас 0.");
            }
            else if (CurrentSpeed == MaxSpeed)
            {
                LogMessage("ТС движется с максимальной скоростью.");
            }
            else if (CurrentSpeed == 0)
            {
                LogMessage("ТС не может замедлиться, потому что оно уже стоит.");
            }
        }

        public void Boost(double time)
        {
            Time = Time.AddSeconds((int)time);
            double oldSpeed = CurrentSpeed;
            ChangeTheSpeedTo(Acceleration * time);
            double deltaWay = (int)((oldSpeed * time) + (CurrentSpeed * time / 2)) / 1000.0;

            if (Math.Floor(PassedWay / 50.0) < Math.Floor((PassedWay + deltaWay) / 50.0))
            {
                LogMessage($"\tТекущая скорость: {CurrentSpeed};\tПройденный путь: {PassedWay}; \t Уровень топлива: {CurrentFuelLevel}");
            }

            LogMessage($"Уровень топлива: {CurrentFuelLevel}");

            PassedWay += deltaWay;
            CurrentFuelLevel -= FuelConsumption / 100.0 * deltaWay;

            //LogMessage($"\tCS: {CurrentSpeed};\tdeltaWay: {deltaWay}; \tPassedWay: {PassedWay}; \t FuelLavel: {CurrentFuelLevel}");
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
                CurrentFuelLevel = TankVolume;
                LogMessage($"Бак полон, {TankVolume} литров");
            }
        }
    }
}
