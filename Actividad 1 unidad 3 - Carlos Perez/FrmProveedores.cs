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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
                    int proveedorId = Convert.ToInt32(txtProveedorID.Text);
                    string comandoInsertar = @$"Insert into Proveedores(Proveedores_ID, NOMBRE_PROVEEDOR,TELEFONO, CORREO_ELECTRONICO)
                                           VALUES({proveedorId}, '{txtProveedorNombre.Text}','{txtTelefono.Text}', '{txtCorreo.Text}')";


                    using (SqlCommand comando = new SqlCommand(comandoInsertar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Proveedor Agregado");
                            txtProveedorID.Clear();
                            txtTelefono.Clear();
                            txtProveedorNombre.Clear();
                            txtCorreo.Clear();
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
                    string comandoMostrar = "Select * From Proveedores";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            DataTable Tabla = new DataTable();
                            adapter.Fill(Tabla);
                            dgvProveedores.DataSource = Tabla;
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
                    int ProveedorID = Convert.ToInt32(txtActualizarProveedorID.Text);
                    string comandoActualizar = @$"Update Proveedores Set NOMBRE_PROVEEDOR  = '{txtActualizarNombre.Text}',TELEFONO = '{txtActualizarTelefono.Text}' , CORREO_ELECTRONICO ='{TxtActualizarCorreo.Text}' 
                                                  Where Proveedores_ID = {ProveedorID}";

                    using (SqlCommand comando = new SqlCommand(comandoActualizar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {

                            MessageBox.Show("PROVEEDOR ACTUALIZADO");
                            txtProveedorID.Clear();
                            txtTelefono.Clear();
                            txtProveedorNombre.Clear();
                            txtCorreo.Clear();
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
                    int proveedorID = Convert.ToInt32(txtEliminarProveedor.Text);
                    string comandoMostrar = $"Delete from Proveedores where Proveedores_ID = {proveedorID}";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("PROVEEDOR ELIMINADO");
                            txtEliminarProveedor.Clear();
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
