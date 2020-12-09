using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models
{
    public class VehicleDisplay
    {
        public Vehicle Vehicle { get; set; }
        public PictureBox PictureBox { get; set; }

        private Thread launchThread;
        private ToolStripProgressBar ProgressBar { get; set; }
        private RichTextBox RichTextBox { get; set; }

        public VehicleDisplay(Vehicle vehicle, PictureBox pictureBox, ToolStripProgressBar progressBar, RichTextBox vehicleLogs)
        {
            Vehicle = vehicle;
            PictureBox = pictureBox;
            ProgressBar = progressBar;
            ProgressBar.Maximum = Vehicle.TankVolume;
            ProgressBar.Value = (int)Vehicle.CurrentFuelLevel;
            RichTextBox = vehicleLogs;
            pictureBox.Image = GetImage();
        }

        public void Launch()
        {
            launchThread = new Thread(new ThreadStart(LaunchThread));
            launchThread.Start(); 
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
                    PictureBox.Left = 10 + (int)((Vehicle.PassedWay / 500.0) * 480.0);
                    ProgressBar.Value = (int)Vehicle.CurrentFuelLevel;
                    RichTextBox.Text = $"{Vehicle.Brand}\n{Vehicle.CurrentSpeed}км/ч\n{Vehicle.PassedWay}км\n{Vehicle.Time.ToString("HH:mm:ss")}";
                });
                Thread.Sleep(100);
            }
        }

        private Image GetImage()
        {
            if (Vehicle.Type == "Велосипед")
            {
                return (Image)Properties.Resources.Bike;
            }
            return (Image)Properties.Resources.Bus;
        }
    }
}
