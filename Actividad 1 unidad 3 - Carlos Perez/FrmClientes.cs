using Actividad_1_unidad_3___Carlos_Perez.Models;
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
                using (var db = new TiendaDbContext())
                {
                    var nuevoCliente = new Cliente
                    {
                        ClienteId = Convert.ToInt32(txtClienteID.Text),
                        NombreCompleto = txtNombre.Text,
                        CorreoElectronico = txtCorreo.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text
                    };

                    db.Clientes.Add(nuevoCliente);
                    int celdasAfectadas = db.SaveChanges();

                    if (celdasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente agregado correctamente.");

                        txtClienteID.Clear();
                        txtNombre.Clear();
                        txtCorreo.Clear();
                        txtTelefono.Clear();
                        txtDireccion.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TiendaDbContext())
                {
                    var clientes = context.Clientes.ToList();
                    dgvClientes.DataSource = clientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TiendaDbContext())
                {
                    int clienteId = Convert.ToInt32(txtActualizarClienteid.Text);

                    var cliente = context.Clientes.FirstOrDefault(c => c.ClienteId == clienteId);

                    if (cliente != null)
                    {
                        cliente.NombreCompleto = txtActualizarNombre.Text;
                        cliente.CorreoElectronico = TxtActualizarCorreo.Text;
                        cliente.Telefono = txtActualizarTelefono.Text;
                        cliente.Direccion = txtActualizarDireccion.Text;
                        context.SaveChanges();

                        MessageBox.Show("Cliente actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                using (var context = new TiendaDbContext())
                {
                    int clienteId = Convert.ToInt32(txtEliminarCliente.Text);

                    var cliente = context.Clientes.FirstOrDefault(c => c.ClienteId == clienteId);

                    if (cliente != null)
                    {
                        context.Clientes.Remove(cliente);
                        context.SaveChanges();
                        MessageBox.Show("Cliente eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
    
}
