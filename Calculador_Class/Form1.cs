using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           txtResultado.Text = txtResultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text +  "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text +  "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numero1 = txtResultado.Text
            txtResultado. Clear();
            operador = "Suma";
        }

        private void btmResta_Click(object sender, EventArgs e)
        {
            numero1 = txtResultado.Text
            txtResultado. Clear();
            operador = "Resta";
        }

        private void btmDivision_Click(object sender, EventArgs e)
        {
            numero1 = txtResultado.Text
            txtResultado. Clear();
            operador = "Division";
        }

        private void btmMultiplicación_Click(object sender, EventArgs e)
        {
            numero1 = txtResultado.Text
            txtResultado. Clear();
            operador = "Multiplicación";
        }


    }
}
 