using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_C
{
    public partial class Form1 : Form
    {
        //Declaro las variables de instancia
        //operando 1
        double operando1 = 0.0;

        //En el string operacion guardo la operación que ha sido pulsada
        String operacion = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            {
                label1.Text = label1.Text + boton.Text;
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;

            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "^")
            {
                resultado = Math.Pow(operando1, operando2);
            }
            else if (operacion == "√")
            {
                resultado = Math.Sqrt(operando1);
            }
            else if (operacion == "%")
            {
                resultado = operando1 / 100 * operando2;
            }
            else if (operacion == "AC")
            {
                resultado = 0;
                operando1 = 0;
                operando2 = 0;
            }
            
            label1.Text = Convert.ToString(resultado);

        }

    }
}
