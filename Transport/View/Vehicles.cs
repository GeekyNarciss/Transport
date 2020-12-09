using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using Presenter;

namespace Transport
{
    public partial class Vehicles : Form, IVehicleView
    {
        private VehiclePresenter _presenter;

        public Vehicles()
        {
            InitializeComponent();
            _presenter = new VehiclePresenter(this);
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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                _presenter.Submit();
                Close();
            }
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public List<string> GetVehicleList()
        {
            List<string> Vehicle = new List<string>();
            Vehicle.Add(comboBox1.Text);
            Vehicle.Add(comboBox2.Text);
            Vehicle.Add(comboBox3.Text);
            Vehicle.Add(comboBox4.Text);
            Vehicle.Add(comboBox5.Text);

            return Vehicle;
        }

        public List<string> GetFuelList()
        {
            List<string> Fuels = new List<string>();
            Fuels.Add(comboBox6.Text);
            Fuels.Add(comboBox7.Text);
            Fuels.Add(comboBox8.Text);
            Fuels.Add(comboBox9.Text);
            Fuels.Add(comboBox10.Text);

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

        public void CloseForm()
        {
            Close();
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                e.Cancel = true;
                maskedTextBox1.Focus();
                errorProvider1.SetError(maskedTextBox1, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(maskedTextBox1, "");
            }
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                e.Cancel = true;
                maskedTextBox2.Focus();
                errorProvider1.SetError(maskedTextBox2, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(maskedTextBox2, "");
            }
        }

        private void maskedTextBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox3.Text))
            {
                e.Cancel = true;
                maskedTextBox3.Focus();
                errorProvider1.SetError(maskedTextBox3, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(maskedTextBox3, "");
            }
        }

        private void maskedTextBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox4.Text))
            {
                e.Cancel = true;
                maskedTextBox4.Focus();
                errorProvider1.SetError(maskedTextBox4, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(maskedTextBox4, "");
            }
        }

        private void maskedTextBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox5.Text))
            {
                e.Cancel = true;
                maskedTextBox5.Focus();
                errorProvider1.SetError(maskedTextBox5, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(maskedTextBox5, "");
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider1.SetError(comboBox1, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox1, "");
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                e.Cancel = true;
                comboBox2.Focus();
                errorProvider1.SetError(comboBox2, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox2, "");
            }
        }

        private void comboBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                e.Cancel = true;
                comboBox3.Focus();
                errorProvider1.SetError(comboBox3, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox3, "");
            }
        }

        private void comboBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                e.Cancel = true;
                comboBox4.Focus();
                errorProvider1.SetError(comboBox4, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox4, "");
            }
        }

        private void comboBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox5.Text))
            {
                e.Cancel = true;
                comboBox5.Focus();
                errorProvider1.SetError(comboBox5, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox5, "");
            }
        }

        private void comboBox6_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox6.Text))
            {
                e.Cancel = true;
                comboBox6.Focus();
                errorProvider1.SetError(comboBox6, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox6, "");
            }
        }

        private void comboBox7_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox7.Text))
            {
                e.Cancel = true;
                comboBox7.Focus();
                errorProvider1.SetError(comboBox7, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox7, "");
            }
        }

        private void comboBox8_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox8.Text))
            {
                e.Cancel = true;
                comboBox8.Focus();
                errorProvider1.SetError(comboBox8, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox8, "");
            }
        }

        private void comboBox9_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox9.Text))
            {
                e.Cancel = true;
                comboBox9.Focus();
                errorProvider1.SetError(comboBox9, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox9, "");
            }
        }

        private void comboBox10_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox10.Text))
            {
                e.Cancel = true;
                comboBox10.Focus();
                errorProvider1.SetError(comboBox10, "Модель должна быть существующей!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox10, "");
            }
        }

        public void SetFuel(List<string> fuels)
        {
            comboBox6.Items.AddRange(fuels.ToArray());
            comboBox7.Items.AddRange(fuels.ToArray());
            comboBox8.Items.AddRange(fuels.ToArray());
            comboBox9.Items.AddRange(fuels.ToArray());
            comboBox10.Items.AddRange(fuels.ToArray());
        }
    }
}
