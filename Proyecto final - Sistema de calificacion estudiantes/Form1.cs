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
        FrmMateria frmMateria = new FrmMateria();
        FrmCalificaciones frmCalificaciones = new FrmCalificaciones();

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "ESTUDIANTE":
                    //MessageBox.Show("ESTUDIANTE FUNCIONA"); Ya no es necesario
                    frmEstudiante.ShowDialog();
                    break;
                case "MATERIA":
                    //MessageBox.Show("MATERIA FUNCIONA");
                    frmMateria.ShowDialog();
                    break;
                case "CALIFICACIONES":
                    //MessageBox.Show("CALIFICACIONES FUNCIONA");
                    frmCalificaciones.ShowDialog();
                    break;
                default:
                    MessageBox.Show("NADA SELECCIONADO");
                    break;
            }
        }
    }
}
