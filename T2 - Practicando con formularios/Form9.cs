using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2___Practicando_con_formularios
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        double valor1;
        double valor2;
        double resultado;
        int opcion;
        private void button1_Click(object sender, EventArgs e)
        {
            int numero0 = 0;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            int numero0 = 1;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int numero0 = 2;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int numero0 = 3;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int numero0 = 4;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int numero0 = 5;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int numero0 = 6;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int numero0 = 7;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int numero0 = 8;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int numero0 = 9;
            textBox1.Text = textBox1.Text + Convert.ToString(numero0);

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            opcion = 1;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        

        private void btnResta_Click(object sender, EventArgs e)
        {
            opcion = 2;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            opcion = 3;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnMultipplicar_Click(object sender, EventArgs e)
        {
            opcion = 4;
            valor1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void btnIgualdad_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (opcion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 3:
                    resultado = valor1 / valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                case 4:
                    resultado = valor1 * valor2;
                    textBox1.Text = resultado.ToString();
                    break;
                default:
                    MessageBox.Show("Opcion no encontrada");
                    break;
            }


        }
    }
}
