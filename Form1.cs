using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdwardChangIn_Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string carMake = txtCarMake.Text;
            double price = double.Parse(txtPrice.Text);
            string carType = cboCarType.Text;
            txtOutput.Text = "The car's make is " + carMake+"." + "\r\n Price is: $"+ price+ "\r\n The Car's Type is a "+ carType+".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCarMake.Text = "";
            cboCarType.SelectedIndex = -1;
            txtOutput.Text = "";
            txtPrice.Text = "";
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
