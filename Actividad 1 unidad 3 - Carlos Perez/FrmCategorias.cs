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

namespace Actividad_1_unidad_3___Carlos_Perez
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionStr = "Data source = localhost; initial catalog= TiendaDB; Integrated security=True;TrustServerCertificate=True";
                using (SqlConnection conexion = new SqlConnection(connectionStr))
                {
                    conexion.Open();
                    int categoriaID = Convert.ToInt32(txtCategoriaId.Text);
                    string comandoInsertar = @$"Insert into Categorias(Categoria_ID, NOMBRE_Categoria)
                                           VALUES({categoriaID}, '{cbCategorias.Text}')";


                    using (SqlCommand comando = new SqlCommand(comandoInsertar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Categoria Agregada");

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void lblClienteID_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionStr = "Data source = localhost; initial catalog= TiendaDB; Integrated security=True;TrustServerCertificate=True";
                using (SqlConnection conexion = new SqlConnection(connectionStr))
                {
                    conexion.Open();
                    string comandoMostrar = "Select * From CATEGORIAS";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            DataTable Tabla = new DataTable();
                            adapter.Fill(Tabla);
                            dgvCategorias.DataSource = Tabla;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionStr = "Data source = localhost; initial catalog= TiendaDB; Integrated security=True;TrustServerCertificate=True";
                using (SqlConnection conexion = new SqlConnection(connectionStr))
                {
                    conexion.Open();
                    int categoriaID = Convert.ToInt32(txtActualizarCategoria.Text);
                    string comandoActualizar = @$"Update Categorias Set NOMBRE_Categoria  = '{cbActualizarCategoria.Text}' 
                                                  Where Categoria_ID = {categoriaID}";

                    using (SqlCommand comando = new SqlCommand(comandoActualizar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {

                            MessageBox.Show("CATEGORIA ACTUALIZADA");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionStr = "Data source = localhost; initial catalog= TiendaDB; Integrated security=True;TrustServerCertificate=True";
                using (SqlConnection conexion = new SqlConnection(connectionStr))
                {
                    conexion.Open();
                    int categoriaID = Convert.ToInt32(txtEliminarCategoria.Text);
                    string comandoMostrar = $"Delete from Categorias where Categoria_ID = {categoriaID}";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Categoria ELIMINADA");
                            txtEliminarCategoria.Clear();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
