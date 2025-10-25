namespace Actividad_1_unidad_3___Carlos_Perez
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form FrmClientes = new Form();
            //FrmClientes.ShowDialog();
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.ShowDialog();
        }
    }
}
