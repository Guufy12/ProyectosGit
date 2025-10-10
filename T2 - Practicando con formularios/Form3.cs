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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label2.Text = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                label2.Text = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                label2.Text = radioButton3.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Azul")
            {
                BackColor  = Color.Blue;
            }
            if (comboBox1.Text == "Verde")
            {
                BackColor = Color.Green;
            }
            if (comboBox1.Text == "Rojo")
            {
                BackColor = Color.Red;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
