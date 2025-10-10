using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2___Practicando_con_formularios
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(textBox1.Text);
                MessageBox.Show($"Valor ingresado: {valor}, es un numero");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El valor no es un numero, Error: " + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, soy Carlos Perez de matricula: SD-2023-04835");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Value.ToString(); 
        }
    }
}
