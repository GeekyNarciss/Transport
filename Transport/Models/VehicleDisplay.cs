using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport.Models
{
    class VehicleDisplay
    {
        public Vehicle Vehicle { get; set; }
        public PictureBox PictureBox { get; set; }

        public VehicleDisplay(Vehicle vehicle, PictureBox pictureBox)
        {
            Vehicle = vehicle;
            PictureBox = pictureBox;

            pictureBox.Image = (Image)Properties.Resources.Car;
        }

        public void Launch()
        {
            Thread launchThread = new Thread(new ThreadStart(LaunchThread));
            launchThread.Start(); // запускаем поток
        }

        private void LaunchThread()
        {
            Vehicle.Start();
            for (int i = 0; i < 100; i++)
            {
                PictureBox.Invoke((MethodInvoker)delegate
                {
                    PictureBox.Left += 5;
                });
                Thread.Sleep(500);
            }
        }
    }
}
