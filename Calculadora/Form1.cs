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

        private double var1 = 0;
        private double var2 = 0;
        private string operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = txtOperacion.Text + "0";
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(txtOperacion.Text);
            lblOperacion.Text = txtOperacion.Text + "  " + " +";
            txtOperacion.Text = " ";
            operacion = "Suma";

        }

        private void Resta_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(txtOperacion.Text);
            lblOperacion.Text = txtOperacion.Text + "  " + " -";
            txtOperacion.Text = " ";
            operacion = "Resta";
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(txtOperacion.Text);
            lblOperacion.Text = txtOperacion.Text + "  " + " *";
            txtOperacion.Text = " ";
            operacion = "Multiplicacion";

        }

        private void Division_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(txtOperacion.Text);
            lblOperacion.Text = txtOperacion.Text + "  " + " /";
            txtOperacion.Text = " ";
            operacion = "Division";
        }


        private void Egual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operacion) && var1 >= 0)
            {
                if (!string.IsNullOrEmpty(txtOperacion.Text))
                {
                    if (operacion == "Suma")
                    {
                        double resultado = var1 + Convert.ToDouble(txtOperacion.Text);
                        lblResultado.Text = resultado.ToString();

                    }
                }

                if (!string.IsNullOrEmpty(txtOperacion.Text))
                {

                    if (operacion == "Resta")
                    {
                        double resultado = var1 - Convert.ToDouble(txtOperacion.Text);
                        lblResultado.Text = resultado.ToString();
                    }
                }
            }

            if (!string.IsNullOrEmpty(operacion) && var2 >= 0)
            {
                if (!string.IsNullOrEmpty(txtOperacion.Text))
                {
                    if (operacion == "Multiplicacion")
                    {
                        double resultado = var1 * Convert.ToDouble(txtOperacion.Text);
                        lblResultado.Text = resultado.ToString();

                    }
                }
            }

            if (!string.IsNullOrEmpty(operacion) && var1 >= 0)
            {
                if (!string.IsNullOrEmpty(txtOperacion.Text))
                {
                    if (operacion == "Division")
                    {
                        double resultado = var1 / Convert.ToDouble(txtOperacion.Text);
                        lblResultado.Text = resultado.ToString();

                    }
                }
            }

            btnReiniciar.Enabled = true;


            //private void Division_Click(object sender, EventArgs e)
            //{
            //    var1 = Convert.ToDouble(txtOperacion.Text);
            //    lblOperacion.Text = txtOperacion.Text + "  " + " /";
            //    txtOperacion.Text = " ";
            //    operacion = "Division";
            //}


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtOperacion.Text = "";
            lblOperacion.Text = "";
            lblResultado.Text = "";
            btnReiniciar.Enabled = false;
        }
    } 
}
