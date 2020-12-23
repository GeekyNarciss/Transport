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
    public partial class Fuel : Form, IFuelView
    {
        private FuelPresenter _presenter;
        public Fuel()
        {
            InitializeComponent();
            _presenter = new FuelPresenter(this);
            _presenter.LoadFuel();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presenter.Submit();
        }

        public List<string> GetListFuelNames()
        {
            List<string> fuels = new List<string>();
            if (checkBoxPetrol.Checked)
            {
                fuels.Add(checkBoxPetrol.Text);
            }

            if (checkBoxDiesel.Checked)
            {
                fuels.Add(checkBoxDiesel.Text);
            }

            if (checkBoxGas.Checked)
            {
                fuels.Add(checkBoxGas.Text);
            }

            if (checkBoxElectricity.Checked)
            {
                fuels.Add(checkBoxElectricity.Text);
            }

            if (checkBoxHorsePower.Checked)
            {
                fuels.Add(checkBoxHorsePower.Text);
            }

            if (checkBoxHumanPower.Checked)
            {
                fuels.Add(checkBoxHumanPower.Text);
            }

            if (checkBoxJet.Checked)
            { 
                fuels.Add(checkBoxJet.Text);
            }

            return fuels;
        }

        public void CloseForm()
        {
            this.Close();
        }

        public void SetFuels(List<string> fuelNames)
        {
            if (fuelNames.IndexOf("Бензин") != -1)
            {
                checkBoxPetrol.Checked = true;
            }

            if (fuelNames.IndexOf("Дизель") != -1)
            {
                checkBoxDiesel.Checked = true;
            }

            if (fuelNames.IndexOf("Газ") != -1)
            {
                checkBoxGas.Checked = true;
            }

            if (fuelNames.IndexOf("Электричество") != -1)
            {
                checkBoxElectricity.Checked = true;
            }

            if (fuelNames.IndexOf("Лошадиная сила") != -1)
            {
                checkBoxHorsePower.Checked = true;
            }
            if (fuelNames.IndexOf("Человеческая сила") != -1)
            {
                checkBoxHumanPower.Checked = true;
            }
            if (fuelNames.IndexOf("Реактивное") != -1)
            {
                checkBoxJet.Checked = true;
            }
        }
    }
 }
