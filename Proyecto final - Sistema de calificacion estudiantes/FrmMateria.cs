using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final___Sistema_de_calificacion_estudiantes
{
    public partial class FrmMateria : Form
    {
        public FrmMateria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                DataTable tabla = new DataTable();
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    string comandoString = "SELECT * FROM Materia";
                    using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                        DgvMostrarMaterias.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    string ComandoStr = "Insert into MATERIA(MATERIA_ID, NOMBRE_MATERIA, CREDITOS) Values(@ID, @Nombre, @Creditos) ";
                    using (SqlCommand comando = new SqlCommand(ComandoStr, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID",Convert.ToInt64(txtIDMateria.Text));
                        comando.Parameters.AddWithValue("@Nombre", txtNombreMateria.Text);
                        comando.Parameters.AddWithValue("@Creditos", txtCreditos.Text);
                        if(comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Materia Agregada");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }
    }
}
