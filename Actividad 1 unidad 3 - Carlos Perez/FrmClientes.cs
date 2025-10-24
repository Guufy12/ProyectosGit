using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Actividad_1_unidad_3___Carlos_Perez
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                    int clienteId = Convert.ToInt32(txtClienteID.Text);
                    string comandoInsertar = @$"Insert into Clientes(Cliente_ID, NOMBRE_COMPLETO, CORREO_ELECTRONICO,TELEFONO, DIRECCION)
                                           VALUES({clienteId}, '{txtNombre.Text}', '{txtCorreo.Text}','{txtTelefono.Text}', '{txtDireccion.Text}')";


                    using (SqlCommand comando = new SqlCommand(comandoInsertar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente Agregado");

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
                    string comandoMostrar = "Select * From Clientes";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comando))
                        {
                            DataTable Tabla = new DataTable();
                            adapter.Fill(Tabla);
                            dgvClientes.DataSource = Tabla;
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
                    int clienteId = Convert.ToInt32(txtActualizarClienteid.Text);
                    string comandoActualizar = @$"Update Clientes Set NOMBRE_COMPLETO  = '{txtActualizarNombre.Text}', CORREO_ELECTRONICO ='{TxtActualizarCorreo.Text}' ,TELEFONO = '{txtActualizarTelefono.Text}', DIRECCION= '{txtActualizarDireccion.Text}'
                                                  Where Cliente_id = {clienteId}";

                    using (SqlCommand comando = new SqlCommand(comandoActualizar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente Actualizado");

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
                    int clienteId = Convert.ToInt32(txtEliminarCliente.Text);
                    string comandoMostrar = $"Delete from Clientes where Cliente_ID = {clienteId}";

                    using (SqlCommand comando = new SqlCommand(comandoMostrar, conexion))
                    {
                        int celdasAfectadas = comando.ExecuteNonQuery();
                        if (celdasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente Eliminado");

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
