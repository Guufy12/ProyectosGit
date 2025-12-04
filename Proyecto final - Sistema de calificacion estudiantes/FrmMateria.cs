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
          
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;
            int creditos;
            
             

                if (string.IsNullOrEmpty(txtIDMateria.Text))
                {
                    Mensaje += "campo Id Vacio\n";
                    error = true;
                }
                if (string.IsNullOrEmpty(txtNombreMateria.Text))
                {
                    Mensaje += "Nombre de materia Vacio\n";
                    error = true;
                }
                if (string.IsNullOrEmpty(txtCreditos.Text))
                {
                    Mensaje += "Numero de credios Vacia\n";
                    error = true;
                }
                if (!int.TryParse(txtIDMateria.Text, out id))
                {
                    Mensaje += "El Id debe ser un numero\n";
                    error = true;
                }
                if (!int.TryParse(txtCreditos.Text, out id))
                {
                    Mensaje += "El numero de creditos debe ser un numero\n";
                    error = true;
                }
            if (!int.TryParse(txtCreditos.Text, out creditos))
            {
                Mensaje += "campo creditos invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (creditos > 4)
                {
                    Mensaje += "El numero de creditos es muy grande, no debe ser mayor a 4\n";
                    error = true;
                }
                if (creditos < 0)
                {
                    Mensaje += "El numero de creditos es negativo, el minimo es 0\n";
                    error = true;
                }

            if (error)
            {
                MessageBox.Show(Mensaje);
            }
            else
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
                            comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIDMateria.Text));
                            comando.Parameters.AddWithValue("@Nombre", txtNombreMateria.Text);
                            comando.Parameters.AddWithValue("@Creditos", txtCreditos.Text);
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Materia Agregada");
                                txtIDMateria.Clear();
                                txtNombreMateria.Clear();
                                txtCreditos.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se agrego ningun registro");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("No se puede agregar registro. Ya existe la llave primaria.");
                    }
                    if (ex.Number == 2628)
                    {
                        MessageBox.Show("No se puede agregar registro. el texto excede el maximo de digitos");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con la base de datos: " + ex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;
            int creditos;



            if (string.IsNullOrEmpty(txtIDMateria.Text))
            {
                Mensaje += "campo Id Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtNombreMateria.Text))
            {
                Mensaje += "Nombre de materia Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtCreditos.Text))
            {
                Mensaje += "Numero de credios Vacia\n";
                error = true;
            }
            if (!int.TryParse(txtIDMateria.Text, out id))
            {
                Mensaje += "El Id debe ser un numero\n";
                error = true;
            }
            if (!int.TryParse(txtCreditos.Text, out id))
            {
                Mensaje += "El numero de creditos debe ser un numero\n";
                error = true;
            }
            if (!int.TryParse(txtCreditos.Text, out creditos))
            {
                Mensaje += "campo creditos invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (creditos > 4)
            {
                Mensaje += "El numero de creditos es muy grande, no debe ser mayor a 4\n";
                error = true;
            }
            if (creditos < 0)
            {
                Mensaje += "El numero de creditos es negativo, el minimo es 0\n";
                error = true;
            }

            if (error)
            {
                MessageBox.Show(Mensaje);
            }
            else
            {
                try
                {
                    string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                    using (SqlConnection conexion = new SqlConnection(conexionStr))
                    {
                        conexion.Open();
                        string ComandoStr = "Update MATERIA Set NOMBRE_MATERIA = @Nombre, CREDITOS = @Creditos Where Materia_ID = @ID";
                        using (SqlCommand comando = new SqlCommand(ComandoStr, conexion))
                        {
                            comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIdAct.Text));
                            comando.Parameters.AddWithValue("@Nombre", txtNombreAct.Text);
                            comando.Parameters.AddWithValue("@Creditos", txtCreditosAct.Text);
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Materia Actualizada");
                                txtIDMateria.Clear();
                                txtNombreMateria.Clear();
                                txtCreditos.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se actualizo ningun registro");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("No se puede agregar registro. No hay relacion valida.");
                    }
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("No se puede agregar registro. Ya existe la llave primaria.");
                    }
                    if (ex.Number == 2628)
                    {
                        MessageBox.Show("No se puede agregar registro. el texto excede el maximo de digitos");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con la base de datos: " + ex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex);
                }
            }
        }

        private void BtnELiminar_Click(object sender, EventArgs e)
        {
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;

            if (string.IsNullOrEmpty(txtIdEliminar.Text))
            {
                Mensaje += "Id Vacio\n";
                error = true;
            }
            if (!int.TryParse(txtIdEliminar.Text, out id))
            {
                Mensaje += "El Id debe ser un numero\n";
                error = true;
            }
            if (error)
            {
                MessageBox.Show(Mensaje);
            }
            else
            {
                try
                {
                    string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                    using (SqlConnection conexion = new SqlConnection(conexionStr))
                    {
                        conexion.Open();
                        string ComandoStr = "Delete From MATERIA Where Materia_ID = @ID";
                        using (SqlCommand comando = new SqlCommand(ComandoStr, conexion))
                        {
                            comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIdEliminar.Text));
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Materia Eliminada");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro para eliminar.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("No se puede eliminar registro. Otros depende de el.");
                    }
                    if (ex.Number == 207)
                    {
                        MessageBox.Show("No se puede eliminar el registro. No existe la columna o esta mal escrita.");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error con la base de datos: " + ex);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex);
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {

                string texto = "";

                for (int i = 0; i < DgvMostrarMaterias.Columns.Count; i++)
                {
                    texto += DgvMostrarMaterias.Columns[i].HeaderText;

                    if (i < DgvMostrarMaterias.Columns.Count - 1)
                        texto += ",";
                }

                texto += Environment.NewLine;

                foreach (DataGridViewRow fila in DgvMostrarMaterias.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        for (int i = 0; i < DgvMostrarMaterias.Columns.Count; i++)
                        {
                            texto += fila.Cells[i].Value?.ToString();

                            if (i < DgvMostrarMaterias.Columns.Count - 1)
                                texto += ",";
                        }

                        texto += Environment.NewLine;
                    }
                }

                string ruta = Application.StartupPath + "\\ListadoMaterias.csv";

                File.WriteAllText(ruta, texto);

                MessageBox.Show("Archivo exportado correctamente en: " + ruta);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDMateria.Clear();
            txtNombreMateria.Clear();
            txtCreditos.Clear();
        }
    }
}
