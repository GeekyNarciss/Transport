using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.Models;

namespace Transport
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Transport());

            Car car = new Car("Мерседес", new Models.Fuel { Name = "Бензин" }, 34, 120, 15.7, 65, 2 );

            car.WindowOpening();
            car.Start();
            car.DoorOpening();
        }
    }
}
