using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using View;

namespace Transport
{
    public partial class Transport : Form, ITransportView
    {
        private TransportPresenter _presenter;
        public Transport()
        {
            InitializeComponent();
            _presenter = new TransportPresenter(this);
        }

        private void fuel_button_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        private void vehicle_button_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();
            vehicle.FormClosed += _presenter.ShowVehicles;
            vehicle.ShowDialog();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            _presenter.Start();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            _presenter.Stop();
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            Log newform = new Log();
           
            if (checkBox1.Checked == true)
            {
                newform.ShowDialog();
            }
            _presenter.Log();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void CreateVihecle()
        {
            throw new NotImplementedException();
        }

        public void CreateFuels()
        {

        }

        public void ShowAllVehicles()
        {
            throw new NotImplementedException();
        }

        private void createFuelButton_Click(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        private void createVechiclesButton_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();
            vehicle.FormClosed += _presenter.ShowVehicles;
            vehicle.ShowDialog();
        }

        public List<PictureBox> GetPictureBoxWithVehicle()
        {
            List<PictureBox> pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);

            return pictureBoxes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log newform = new Log();
            newform.ShowDialog();
        }

        public List<ToolStripProgressBar> GetProgressBArList()
        {
            List<ToolStripProgressBar> progressBars = new List<ToolStripProgressBar>();
            progressBars.Add(toolStripProgressBar1);
            progressBars.Add(toolStripProgressBar2);
            progressBars.Add(toolStripProgressBar3);
            progressBars.Add(toolStripProgressBar4);
            progressBars.Add(toolStripProgressBar5);

            return progressBars;

        }

        public List<RichTextBox> GetVehiclelogs()
        {
            List<RichTextBox> vehicleLogs = new List<RichTextBox>();
            vehicleLogs.Add(richTextBox1);
            vehicleLogs.Add(richTextBox2);
            vehicleLogs.Add(richTextBox3);
            vehicleLogs.Add(richTextBox4);
            vehicleLogs.Add(richTextBox5);

            return vehicleLogs;
        }

        public bool TxtChecked()
        {
            return checkBox2.Checked;
        }

        public bool DocChecked()
        {
            return checkBox3.Checked;
        }
    }
}
