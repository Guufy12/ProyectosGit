namespace Sistema_de_gestion_de_visado
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        Login formLogin = new Login();
        FrmInformaciones frmInformaciones = new FrmInformaciones();

        private void button1_Click(object sender, EventArgs e)
        {
            formLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInformaciones.ShowDialog();
        }
    }
}
