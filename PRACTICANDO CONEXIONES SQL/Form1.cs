using Microsoft.Data.SqlClient;
namespace PRACTICANDO_CONEXIONES_SQL
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexionStr = @"DATA SOURCE=.;Initial Catalog= TiendaDB;Integrated Security=true;TrustServerCertificate=true";
            using SqlConnection connection = new SqlConnection(conexionStr);
            connection.Open();
            MessageBox.Show("CONEXION ESTABLECIDA");
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            string conexion = "Data source = localhost;initial catalog= TiendaDB; integrated security= true; TrustServerCertificate=true";
            using SqlConnection connection = new SqlConnection(conexion);
            connection.Close();
            MessageBox.Show("CONEXION CERRADA");
        }
    }
}
