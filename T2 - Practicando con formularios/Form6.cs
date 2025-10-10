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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal grados = Convert.ToDecimal(textBox1.Text);
            decimal Fahrenheit = (grados * 9 / 5) + 32;
            label2.Text = Fahrenheit.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
