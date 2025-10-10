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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            while (barrita.Value < 100)
            {
                barrita.Value = barrita.Value + 10;
                MessageBox.Show($"Progreso de la barra: {barrita.Value}");

            }

            if (barrita.Value >= 100)
            {
                MessageBox.Show("Barra completa");
            }
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            barrita.Value = 0;
            MessageBox.Show("BARRA LIMPIADA");

        }
    }
}
