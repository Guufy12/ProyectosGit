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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label4.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nuevoArchivo = saveFileDialog1.FileName;
                saveFileDialog1.Title = "GuardadoTxt";
                string contenido = "Hola, soy el texto dentro del documento";
                File.WriteAllText(nuevoArchivo,contenido);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ruta = label4.Text;
            //StreamReader lector = new StreamReader(ruta);
            string contenido = File.ReadAllText(ruta);
            textBox1.Text = contenido;
        }
    }
}
