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
    public partial class Form1 : Form
    {
        string operador;
        double num1 , num2, resultado;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btn_Punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (pantalla.TextLength > 1)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1, 1);
            }
        }

        private void btn_Restar_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(pantalla.Text);
            switch(operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            pantalla.Text = resultado.ToString();
        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
    }
}
