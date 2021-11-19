using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public enum operaciones
    {
        Nodefinida=0,
        suma=1,
        resta=2,
        dision=3,
        multi=4
    }
    public partial class Form1 : Form
    {
        double val = 0;
        double val1 = 0;
        operaciones operador = operaciones.Nodefinida;
        public Form1()
        {
            InitializeComponent();
             
            
        }
        private double operacion(string opcion)
        {
            double resultado = 0;
            switch (opcion)
            {
                case "+":
                    resultado = val + val1;
                    break;
                case "-":
                    resultado = val - val1;
                    break;
                case "/":
                    resultado = val / val1;
                    break;
                case "*":
                    resultado = val * val1;
                    break;
            }
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(resultado.Text =="0" && resultado.Text != null)
            {
                resultado.Text = "1";
            }
            else
            {
                resultado.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "2";
            }
            else
            {
                resultado.Text += "2";
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if(val1==0)
            {
                val1 = Convert.ToDouble(resultado.Text);
                lblhistorial.Text += val1 + "=";
                double resul = operacion ();
                val = 0;
                val1 = 0;
                resultado.Text = Convert.ToString(resul);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "7";
            }
            else
            {
                resultado.Text += "7";
            }
        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0")
            {
                return;
            }
            else
            {
                resultado.Text += "0";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "3";
            }
            else
            {
                resultado.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "4";
            }
            else
            {
                resultado.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "5";
            }
            else
            {
                resultado.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "6";
            }
            else
            {
                resultado.Text += "6";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "8";
            }
            else
            {
                resultado.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (resultado.Text == "0" && resultado.Text != null)
            {
                resultado.Text = "9";
            }
            else
            {
                resultado.Text += "9";
            }
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = operaciones.suma;
            val = Convert.ToDouble(resultado.Text);
            lblhistorial.Text = resultado.Text + "+";
            resultado.Text = "0";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = operaciones.resta;
            val = Convert.ToDouble(resultado.Text);
            lblhistorial.Text = resultado.Text + "-";
            resultado.Text = "0";
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            operador = operaciones.dision;
            val = Convert.ToDouble(resultado.Text);
            lblhistorial.Text = resultado.Text + "/";
            resultado.Text = "0";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            operador = operaciones.multi;
            val = Convert.ToDouble(resultado.Text);
            lblhistorial.Text = resultado.Text + "*";
            resultado.Text = "0";
        }
    }
}
