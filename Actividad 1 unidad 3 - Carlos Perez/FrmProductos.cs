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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionStr = "Data source = localhost; initial catalog= TiendaDB; Integrated security=True;TrustServerCertificate=True";
                using (SqlConnection conexion = new SqlConnection(connectionStr))
                {
                    conexion.Open();
                    int productoId = Convert.ToInt32(txtIdProducto.Text);
                    int categoriaID = Convert.ToInt32(txtIdCategoria.Text);
                    string comandoInsertar = @$"Insert into Productos(Producto_ID, NOMBRE_Producto,Descripcion,Precio, Stock,Categoria_ID)
                                           VALUES({productoId}, '{txtNombreProducto.Text}','{txtDescripcion.Text}', '{txtPrecio.Text}','{txtStock.Text}',{categoriaID})";


                    using (SqlCommand comando = new SqlCommand(comandoInsertar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Producto Agregado");

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionStr = "Data source = localhost; initial catalog= TiendaDB; Integrated security=True;TrustServerCertificate=True";
                using (SqlConnection conexion = new SqlConnection(connectionStr))
                {
                    conexion.Open();
                    string comandoMostrar = "Select * From Productos";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            DataTable Tabla = new DataTable();
                            adapter.Fill(Tabla);
                            dgvProductos.DataSource = Tabla;
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
                    int productoId = Convert.ToInt32(txtActualizarNombre.Text);
                    int categoriaID = Convert.ToInt32(txtActualizarIdCategoria.Text);
                    string comandoActualizar = @$"Update Productos Set Nombre_Producto  = '{txtActualizarProducto.Text}', Descripcion = '{txtActualizarDesc.Text}', Precio = '{txtActualizarPrecio.Text}', Stock = '{txtActualizarStock.Text}', Categoria_ID = {categoriaID}
                                                  Where Producto_ID = {productoId}";

                    using (SqlCommand comando = new SqlCommand(comandoActualizar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {

                            MessageBox.Show("Producto ACTUALIZADA");
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
                    int productoId = Convert.ToInt32(txtEliminarProducto.Text);
                    string comandoMostrar = $"Delete from Productos where Producto_ID = {productoId}";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Producto ELIMINADO");
                            txtEliminarProducto.Clear();
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
