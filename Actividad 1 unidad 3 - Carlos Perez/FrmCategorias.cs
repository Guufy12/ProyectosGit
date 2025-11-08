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
                using (var context = new TiendaDbContext())
                {
                    var categoria = new Categoria
                    {
                        CategoriaId = Convert.ToInt32(txtCategoriaId.Text),
                        NombreCategoria = cbCategorias.Text
                    };

                    context.Categorias.Add(categoria);
                    context.SaveChanges();

                    MessageBox.Show("Categoría agregada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                using (var context = new TiendaDbContext())
                {
                    var categorias = context.Categorias.ToList();
                    dgvCategorias.DataSource = categorias;
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
                    int categoriaId = Convert.ToInt32(txtActualizarCategoria.Text);

                    var categoria = context.Categorias.FirstOrDefault(c => c.CategoriaId == categoriaId);

                    if (categoria != null)
                    {
                        categoria.NombreCategoria = cbActualizarCategoria.Text;
                        context.SaveChanges();

                        MessageBox.Show("Categoría actualizada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Categoría no encontrada");
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
                    int categoriaID = Convert.ToInt32(txtEliminarCategoria.Text);

                    var categoria = context.Categorias.Find(categoriaID);

                    if (categoria != null)
                    {
                        context.Categorias.Remove(categoria);
                        context.SaveChanges();

                        MessageBox.Show("Categoría eliminada correctamente");
                        txtEliminarCategoria.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una categoría con ese ID");
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
