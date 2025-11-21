using System.Diagnostics.Eventing.Reader;

namespace Proyecto_final___Sistema_de_calificacion_estudiantes
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "ESTUDIANTE":
                    MessageBox.Show("ESTUDIANTE FUNCIONA");
                    break;
                case "MATERIA":
                    MessageBox.Show("MATERIA FUNCIONA");
                    break;
                case "CALIFICACIONES":
                    MessageBox.Show("CALIFICACIONES FUNCIONA");
                    break;
                default:
                    MessageBox.Show("NADA SELECCIONADO FUNCIONA");
                    break;
            }
        }
    }
}
