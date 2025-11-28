using System.Diagnostics.Eventing.Reader;

namespace Proyecto_final___Sistema_de_calificacion_estudiantes
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        FrmEstudiantes frmEstudiante = new FrmEstudiantes();
        Form frmMateria = new Form();
        Form frmCalificaciones = new Form();

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "ESTUDIANTE":
                    MessageBox.Show("ESTUDIANTE FUNCIONA");
                    frmEstudiante.Show();
                    break;
                case "MATERIA":
                    MessageBox.Show("MATERIA FUNCIONA");
                    frmMateria.Show();
                    break;
                case "CALIFICACIONES":
                    MessageBox.Show("CALIFICACIONES FUNCIONA");
                    frmCalificaciones.Show();
                    break;
                default:
                    MessageBox.Show("NADA SELECCIONADO FUNCIONA");
                    break;
            }
        }
    }
}
