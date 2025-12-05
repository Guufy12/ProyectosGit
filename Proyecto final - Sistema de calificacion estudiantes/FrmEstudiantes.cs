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

namespace Proyecto_final___Sistema_de_calificacion_estudiantes
{
    public partial class FrmEstudiantes : Form
    {
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;
            DateTime fechaIngresada = DtpNacimiento.Value;
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaIngresada.Year;

            if (string.IsNullOrEmpty(txtID.Text))
            {
                Mensaje += "Id Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtNombreEstudiante.Text))
            {
                Mensaje += "Nombre Vacio\n";
                error = true;
            }
            if (txtNombreEstudiante.Text.Any(char.IsDigit))
            {
                Mensaje += "Nombre Invalido. Agregue su nombre en texto\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                Mensaje += "Matricula Vacia\n";
                error = true;
            }
            if (txtMatricula.Text.Length > 15)
            {
                Mensaje += "El tamaño maximo de caracteres de la matricula es 15\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtCarrera.Text))
            {
                Mensaje += "Carrera Vacio \n";
                error = true;
            }

            if (!int.TryParse(txtID.Text, out id))
            {
                Mensaje += "El Id debe ser un numero\n";
                error = true;
            }

            if (edad < 15)
            {
                Mensaje += $"No es posible ingresar menores de 15. Tienes: {edad} años\n";
                error = true;
            }

            if (edad > 100)
            {
                Mensaje += $"No es posible ingresar mayores de 100. Tienes: {edad} años\n";
                error = true;
            }

            //lo ultimo
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
                        string ComandoStr = "Insert into Estudiante(ESTUDIANTE_ID,NOMBRE, MATRICULA, FECHA_NACIMIENTO, CARRERA) Values(@ID, @NOMBRE, @MATRICULA, @FECHANACIMIENTO, @CARRERA) ";
                        using (SqlCommand comando = new SqlCommand(ComandoStr, conexion))
                        {
                            comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtID.Text));
                            comando.Parameters.AddWithValue("@NOMBRE", txtNombreEstudiante.Text);
                            comando.Parameters.AddWithValue("@MATRICULA", txtMatricula.Text);//poner que el maximo sean 15 digitos
                            comando.Parameters.AddWithValue("@FECHANACIMIENTO", DtpNacimiento.Value);
                            comando.Parameters.AddWithValue("@CARRERA", txtCarrera.Text);

                            if (comando.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Estudiante Agregado");
                                txtID.Clear();
                                txtNombreEstudiante.Clear();
                                txtMatricula.Clear();
                                txtCarrera.Clear();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex);
                }
            }
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
                    string comandoString = "SELECT * FROM ESTUDIANTE";
                    using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                        DgvMostrar.DataSource = tabla;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 207)
                {
                    MessageBox.Show("No se puede visualizar el registro. No existe la columna o esta mal escrita.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombreEstudiante.Clear();
            txtMatricula.Clear();
            txtCarrera.Clear();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;
            DateTime fechaIngresada = DtpFechaAct.Value;
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaIngresada.Year;

            if (string.IsNullOrEmpty(txtIDActualizar.Text))
            {
                Mensaje += "Id Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtNombreAct.Text))
            {
                Mensaje += "Nombre Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtMatriculaAct.Text))
            {
                Mensaje += "Matricula Vacia\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtCarreraAct.Text))
            {
                Mensaje += "Cerrera Vacio \n";
                error = true;
            }
            if (txtNombreAct.Text.Any(char.IsDigit))
            {
                Mensaje += "Nombre Invalido. Agregue su nombre en texto\n";
                error = true;
            }

            if (!int.TryParse(txtIDActualizar.Text, out id))
            {
                Mensaje += "El Id debe ser un numero\n";
                error = true;
            }
            if (edad < 15)
            {
                Mensaje += $"No es posible ingresar menores de 15. Tienes: {edad} años\n";
                error = true;
            }

            if (edad > 100)
            {
                Mensaje += $"No es posible ingresar mayores de 100. Tienes: {edad} años\n";
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
                        string comandoString = $"Update Estudiante set Nombre = @Nombre, Matricula = @Matricula, Fecha_Nacimiento = @FechaNacimiento, Carrera = @Carrera Where ESTUDIANTE_ID = @ID";
                        using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                        {
                            comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIDActualizar.Text));
                            comando.Parameters.AddWithValue("@Nombre", txtNombreAct.Text);
                            comando.Parameters.AddWithValue("@Matricula", txtMatriculaAct.Text);
                            comando.Parameters.AddWithValue("@FechaNacimiento", DtpFechaAct.Value);
                            comando.Parameters.AddWithValue("@Carrera", txtCarreraAct.Text);
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Estudiante Actualizado");
                                txtIDActualizar.Clear();
                                txtNombreAct.Clear();
                                txtMatriculaAct.Clear();
                                txtCarreraAct.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Ningun registro Actualizado");

                            }

                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 207)
                    {
                        MessageBox.Show("No se puede actualizar el registro. No existe la columna o esta mal escrita.");
                    }
                    else if (ex.Number == 547)
                    {
                        MessageBox.Show("No se puede actualizar el registro. Error con la relacion de la Fk.");
                    }
                    else if (ex.Number == 2628)
                    {
                        MessageBox.Show("No se puede agregar registro. El texto excede el maximo de digitos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;

            if (string.IsNullOrEmpty(txtIDEliminar.Text))
            {
                Mensaje += "Id Vacio\n";
                error = true;
            }
            if (!int.TryParse(txtIDEliminar.Text, out id))
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
                        string comandoString = $"Delete Estudiante Where ESTUDIANTE_ID = @ID";
                        using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                        {
                            comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIDEliminar.Text));
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Estudiante ELiminado");
                                txtIDEliminar.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No hubo registro ELiminado");

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

                for (int i = 0; i < DgvMostrar.Columns.Count; i++)
                {
                    texto += DgvMostrar.Columns[i].HeaderText;

                    if (i < DgvMostrar.Columns.Count - 1)
                        texto += ",";
                }

                texto += Environment.NewLine;

                foreach (DataGridViewRow fila in DgvMostrar.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        for (int i = 0; i < DgvMostrar.Columns.Count; i++)
                        {
                            texto += fila.Cells[i].Value?.ToString();

                            if (i < DgvMostrar.Columns.Count - 1)
                                texto += ",";
                        }

                        texto += Environment.NewLine;
                    }
                }

                string ruta = Application.StartupPath + "\\LsitadoEstudiantes.csv";

                File.WriteAllText(ruta, texto);

                MessageBox.Show("Archivo exportado correctamente en: " + ruta);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void BtnLimpiarAct_Click(object sender, EventArgs e)
        {
            txtIDActualizar.Clear();
            txtNombreAct.Clear();
            txtMatriculaAct.Clear();
            txtCarreraAct.Clear();
        }
    }

}
