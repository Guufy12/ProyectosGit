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
    public partial class FrmCalificaciones : Form
    {
        public FrmCalificaciones()
        {
            InitializeComponent();
        }

        private void BtnMostrarCalificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                DataTable tabla = new DataTable();
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    // MessageBox.Show("CONEXION EXITOSA"); Ya no es necesario
                    string comandoString = "SELECT * FROM Calificacion";
                    using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                        DgvMostrarCalificaciones.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    decimal cal1 = Convert.ToDecimal(txtCal1.Text);
                    decimal cal2 = Convert.ToDecimal(txtCal2.Text);
                    decimal cal3 = Convert.ToDecimal(txtCal3.Text);
                    decimal cal4 = Convert.ToDecimal(txtCal4.Text);
                    decimal examen = Convert.ToDecimal(txtExamen.Text);

                    decimal totalCal = ((((cal1 + cal2 + cal3 + cal4) / 4) * 70) / 100) + examen;
                    char clasificacion;
                    if (totalCal >= 90 && totalCal <=100) 
                        clasificacion = 'A';
                    if (totalCal >= 80 && totalCal <= 89)
                        clasificacion = 'B';
                    if (totalCal >= 70 && totalCal <= 79)
                        clasificacion = 'C';
                    if (totalCal >= 60 && totalCal <= 69)
                        clasificacion = 'D';
                    if (totalCal >= 0 && totalCal <= 59)
                        clasificacion = 'F';
                    if (totalCal < 0 && totalCal > 100)
                        MessageBox.Show("Nota invalida");
                    /*
                    switch (totalCal)
                    {
                        case  >= 90 && <101:
                            {
                                clasificacion = 'A';
                                break;
                            }
                        case >= 80:
                            {
                                clasificacion = 'A';
                                break;
                            }
                        case >= 0:
                            {
                                clasificacion = 'A';
                                break;
                            }
                        case >= 90:
                            {
                                clasificacion = 'A';
                                break;
                            }
                        case >= 90:
                            {
                                clasificacion = 'A';
                                break;
                            }

                    }
                    */

                    conexion.Open();
                    string ComandoStr = @$"Insert into Calificacion(ID_CALIFICACION,ID_Estudiante, MATERIA_ID, CALIFICACION1,CALIFICACION2, CALIFICACION3, CALIFICACION4, EXAMEN, TOTAL_CALIFICACION, CLASIFICACION, ESTADO)
                                        Values(@ID, @IdEstudiante, @MateriaId, @calificacion1, @calififacion2, @Calififacion3, @Califiacion4, @Examen, {totalCal}, ) ";
                    using (SqlCommand comando = new SqlCommand(ComandoStr, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtID.Text));
                        comando.Parameters.AddWithValue("@EstudianteId", Convert.ToInt64(txtIdEstudiante.Text));
                        comando.Parameters.AddWithValue("@MateriaId", Convert.ToInt64(txtMateriaId.Text));
                        comando.Parameters.AddWithValue("@calificacion1", Convert.ToDecimal(txtCal1.Text));
                        comando.Parameters.AddWithValue("@calificacion2", Convert.ToDecimal(txtCal2.Text));
                        comando.Parameters.AddWithValue("@calificacion3", Convert.ToDecimal(txtCal3.Text));
                        comando.Parameters.AddWithValue("@calificacion4", Convert.ToDecimal(txtCal4.Text));
                        comando.Parameters.AddWithValue("@Examen", Convert.ToDecimal(txtExamen.Text));

                   


                        /*
                        comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIDMateria.Text));
                        comando.Parameters.AddWithValue("@Nombre", txtNombreMateria.Text);
                        comando.Parameters.AddWithValue("@Creditos", txtCreditos.Text);
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Materia Agregada");
                        } 
                        */
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }
    }
}
