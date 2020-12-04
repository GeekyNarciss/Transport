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

        private Thread launchThread;
        private ToolStripProgressBar ProgressBar { get; set; }

        public VehicleDisplay(Vehicle vehicle, PictureBox pictureBox, ToolStripProgressBar progressBar)
        {
            Vehicle = vehicle;
            PictureBox = pictureBox;
            ProgressBar = progressBar;
            ProgressBar.Maximum = Vehicle.TankVolume;
            ProgressBar.Value = (int)Vehicle.CurrentFuelLevel;
       
            pictureBox.Image = (Image)Properties.Resources.Car;
        }

        public void Launch()
        {
            launchThread = new Thread(new ThreadStart(LaunchThread));
            launchThread.Start(); // запускаем поток
        }

        public void Stop()
        {
            Vehicle.Stop();
            launchThread.Abort();
            launchThread.Join();
        }

        private void LaunchThread()
        {
            Vehicle.Start();
            while (Vehicle.CurrentFuelLevel > 0)
            {
                PictureBox.Invoke((MethodInvoker)delegate
                {
                    //PictureBox.Left += 5;
                    Vehicle.Boost(50.0);
                    PictureBox.Left = 10 + (int)((Vehicle.PassedWay / 500.0) * 450.0);
                    ProgressBar.Value = (int)Vehicle.CurrentFuelLevel;
                });
                Thread.Sleep(200);
            }
        }
    }
}
