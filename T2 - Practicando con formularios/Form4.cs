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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Universidades.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Universidades.Items.Clear();
        }
        //contador de clicks, declarado desde fuera para que no afecte el conteo
        int clicks = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            //El bucle fue innecesario

            //bool clickeando = true;
            //while (clickeando == true)
           //{
                clicks++;
                label2.Text = clicks.ToString();
                //clickeando = false;
           //}


        }
    }
}
