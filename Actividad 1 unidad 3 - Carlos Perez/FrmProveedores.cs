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
                using (var context = new TiendaDbContext())
                {
                    var proveedor = new Proveedore
                    {
                        ProveedoresId = Convert.ToInt32(txtProveedorID.Text),
                        NombreProveedor = txtProveedorNombre.Text,
                        Telefono = txtTelefono.Text,
                        CorreoElectronico = txtCorreo.Text
                    };

                    context.Proveedores.Add(proveedor);
                    context.SaveChanges();

                    MessageBox.Show("Proveedor agregado correctamente");

                    txtProveedorID.Clear();
                    txtTelefono.Clear();
                    txtProveedorNombre.Clear();
                    txtCorreo.Clear();
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
                    var proveedores = context.Proveedores.ToList();
                    dgvProveedores.DataSource = proveedores;
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
                    int proveedorId = Convert.ToInt32(txtActualizarProveedorID.Text);

                    var proveedor = context.Proveedores.FirstOrDefault(p => p.ProveedoresId == proveedorId);

                    if (proveedor != null)
                    {
                        proveedor.NombreProveedor = txtActualizarNombre.Text;
                        proveedor.Telefono = txtActualizarTelefono.Text;
                        proveedor.CorreoElectronico = TxtActualizarCorreo.Text;

                        context.SaveChanges();

                        MessageBox.Show("Proveedor actualizado correctamente");

                        txtActualizarProveedorID.Clear();
                        txtActualizarNombre.Clear();
                        txtActualizarTelefono.Clear();
                        TxtActualizarCorreo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado");
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
                    int proveedorId = Convert.ToInt32(txtEliminarProveedor.Text);

                    var proveedor = context.Proveedores.FirstOrDefault(p => p.ProveedoresId == proveedorId);

                    if (proveedor != null)
                    {
                        context.Proveedores.Remove(proveedor);
                        context.SaveChanges();

                        MessageBox.Show("Proveedor eliminado correctamente");
                        txtEliminarProveedor.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado");
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