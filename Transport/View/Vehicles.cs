using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.View;

namespace Transport
{
    public partial class Vehicles : Form, IVehicleView
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public List<string> GetVehicleList()
        {
            List<string> Vehicle = new List<string>();
            Vehicle.Add(comboBox1.SelectedItem.ToString());
            Vehicle.Add(comboBox2.SelectedItem.ToString());
            Vehicle.Add(comboBox3.SelectedItem.ToString());
            Vehicle.Add(comboBox4.SelectedItem.ToString());
            Vehicle.Add(comboBox5.SelectedItem.ToString());

            return Vehicle;
        }

        public List<string> GetFuelList()
        {
            List<string> Fuels = new List<string>();
            Fuels.Add(comboBox6.SelectedItem.ToString());
            Fuels.Add(comboBox7.SelectedItem.ToString());
            Fuels.Add(comboBox8.SelectedItem.ToString());
            Fuels.Add(comboBox9.SelectedItem.ToString());
            Fuels.Add(comboBox10.SelectedItem.ToString());

            return Fuels;
        }


        public List<string> GetBrandList()
        {
            List<string> Brands = new List<string>();
            Brands.Add(maskedTextBox1.Text);
            Brands.Add(maskedTextBox2.Text);
            Brands.Add(maskedTextBox3.Text);
            Brands.Add(maskedTextBox4.Text);
            Brands.Add(maskedTextBox5.Text);

            return Brands;
        }


        public List<int> GetStartSpeedList()
        {
            List<int> StartSpeed = new List<int>();
            StartSpeed.Add((int)numericUpDown1.Value);
            StartSpeed.Add((int)numericUpDown7.Value);
            StartSpeed.Add((int)numericUpDown12.Value);
            StartSpeed.Add((int)numericUpDown17.Value);
            StartSpeed.Add((int)numericUpDown22.Value);

            return StartSpeed;
        }
        public List<int> GetMaxSpeedList()
        {
            List<int> MaxSpeed = new List<int>();
            MaxSpeed.Add((int)numericUpDown3.Value);
            MaxSpeed.Add((int)numericUpDown8.Value);
            MaxSpeed.Add((int)numericUpDown13.Value);
            MaxSpeed.Add((int)numericUpDown18.Value);
            MaxSpeed.Add((int)numericUpDown23.Value);

            return MaxSpeed;
        }

        public List<double> GetFuelConsumptionList()
        {
            List<double> FuelConsumption = new List<double>();
            FuelConsumption.Add((double)numericUpDown4.Value);
            FuelConsumption.Add((double)numericUpDown9.Value);
            FuelConsumption.Add((double)numericUpDown14.Value);
            FuelConsumption.Add((double)numericUpDown19.Value);
            FuelConsumption.Add((double)numericUpDown24.Value);

            return FuelConsumption;
        }

        public List<int> GetFuelTankCapasityList()
        {
            List<int> TankCapacity = new List<int>();
            TankCapacity.Add((int)numericUpDown5.Value);
            TankCapacity.Add((int)numericUpDown10.Value);
            TankCapacity.Add((int)numericUpDown15.Value);
            TankCapacity.Add((int)numericUpDown20.Value);
            TankCapacity.Add((int)numericUpDown25.Value);

            return TankCapacity;
        }
        public List<int> GetNumderOfPasangersList()
        {
            List<int> Passengers = new List<int>();
            Passengers.Add((int)numericUpDown6.Value);
            Passengers.Add((int)numericUpDown11.Value);
            Passengers.Add((int)numericUpDown16.Value);
            Passengers.Add((int)numericUpDown21.Value);
            Passengers.Add((int)numericUpDown26.Value);

            return Passengers;
        }

        public void SetFuel(List<Models.Fuel> fuels)
        {
            List<string> NameFuels = new List<string>();

        }

        public void CloseForm()
        {
            Close();
        }
    }
}
