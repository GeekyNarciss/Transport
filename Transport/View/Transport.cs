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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Fuel fuel = new Fuel();
            fuel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicles vehicle = new Vehicles();
            vehicle.FormClosed += _presenter.ShowVehicles;
            vehicle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presenter.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _presenter.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Log newform = new Log();
            newform.ShowDialog();
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
    }
}
