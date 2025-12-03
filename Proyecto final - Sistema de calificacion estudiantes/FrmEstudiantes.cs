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
            try
            {
                string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    string ComandoStr = "Insert into Estudiante(ESTUDIANTE_ID,NOMBRE, MATRICULA, FECHA_NACIMIENTO, CARRERA) Values(@ID, @NOMBRE, @MATRICULA, @FECHANACIMIENTO, @CARRERA) ";
                    using (SqlCommand comando = new SqlCommand(ComandoStr, conexion))
                    {
                        //Alternativa, eliminado en el debuggeo

                        //comando.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt64(txtID.Text);
                        // comando.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = txtNombreEstudiante.Text;
                        //comando.Parameters.Add("@MATRICULA", SqlDbType.VarChar).Value = txtMatricula.Text;
                        //comando.Parameters.Add("@FECHANACIMIENTO", SqlDbType.Date).Value = DtpNacimiento.Value;
                        //comando.Parameters.Add("@CARRERA", SqlDbType.VarChar).Value = txtCarrera.Text;

                        comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtID.Text));
                        comando.Parameters.AddWithValue("@NOMBRE", txtNombreEstudiante.Text);
                        comando.Parameters.AddWithValue("@MATRICULA", txtMatricula.Text);
                        comando.Parameters.AddWithValue("@FECHANACIMIENTO", DtpNacimiento.Value);
                        comando.Parameters.AddWithValue("@CARRERA", txtCarrera.Text);
                        //comando.ExecuteNonQuery(); Da error, replica la PK

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Estudiante Agregado");
                            txtID.Clear();
                            txtNombreEstudiante.Clear();
                            txtMatricula.Clear();
                            //DtpNacimiento.Value; //Trato de resetear el DTP
                            txtCarrera.Clear();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
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
                    // MessageBox.Show("CONEXION EXITOSA"); Ya no es necesario
                    string comandoString = "SELECT * FROM ESTUDIANTE";
                    using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                        DgvMostrar.DataSource = tabla;
                    }
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
            DtpNacimiento.Refresh();
            txtCarrera.Clear();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
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
                            txtID.Clear();
                            txtNombreEstudiante.Clear();
                            txtMatricula.Clear();
                            txtCarrera.Clear();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
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
    }

}
