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
                using (var context = new TiendaDbContext())
                {
                    var producto = new Producto
                    {
                        ProductoId = Convert.ToInt32(txtIdProducto.Text),
                        NombreProducto = txtNombreProducto.Text,
                        Descripcion = txtDescripcion.Text,
                        Precio = decimal.Parse(txtPrecio.Text),
                        Stock = int.Parse(txtStock.Text),
                        CategoriaId = Convert.ToInt32(txtIdCategoria.Text)
                    };

                    context.Productos.Add(producto);
                    context.SaveChanges();

                    MessageBox.Show("Producto agregado correctamente");
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
                    var productos = context.Productos.ToList();
                    dgvProductos.DataSource = productos;
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
                    int productoId = Convert.ToInt32(txtActualizarNombre.Text);
                    int categoriaId = Convert.ToInt32(txtActualizarIdCategoria.Text);

                    var producto = context.Productos.FirstOrDefault(p => p.ProductoId == productoId);

                    if (producto != null)
                    {
                        producto.NombreProducto = txtActualizarProducto.Text;
                        producto.Descripcion = txtActualizarDesc.Text;
                        producto.Precio = decimal.Parse(txtActualizarPrecio.Text);
                        producto.Stock = int.Parse(txtActualizarStock.Text);
                        producto.CategoriaId = categoriaId;

                        context.SaveChanges();

                        MessageBox.Show("Producto actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
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
                    int productoId = Convert.ToInt32(txtEliminarProducto.Text);

                    var producto = context.Productos.FirstOrDefault(p => p.ProductoId == productoId);

                    if (producto != null)
                    {
                        context.Productos.Remove(producto);
                        context.SaveChanges();

                        MessageBox.Show("Producto eliminado correctamente");
                        txtEliminarProducto.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

}
