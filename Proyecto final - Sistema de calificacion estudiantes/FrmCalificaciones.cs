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

                    if (cal1 < 0 || cal1 > 100)
                        MessageBox.Show("Calificacion 1: invalida");
                    if (cal2 < 0 || cal2 > 100)
                        MessageBox.Show("Calificacion 2: invalida");
                    if (cal3 < 0 || cal3 > 100)
                        MessageBox.Show("Calificacion 3: invalida");
                    if (cal4 < 0 || cal4 > 100)
                        MessageBox.Show("Calificacion 4: invalida");
                    if (examen < 0 || examen > 30)
                        MessageBox.Show("Calificacion examen: invalida");

                    decimal totalCal = ((((cal1 + cal2 + cal3 + cal4) / 4) * 70) / 100) + examen;
                    char clasificacion = 'I';
                    bool estado;
                    string strEstado = "Pendiente";

                    if (totalCal >= 90 && totalCal <= 100)
                        clasificacion = 'A';
                    else if (totalCal >= 80 && totalCal <= 89)
                        clasificacion = 'B';
                    else if (totalCal >= 70 && totalCal <= 79)
                        clasificacion = 'C';
                    else if (totalCal >= 60 && totalCal <= 69)
                        clasificacion = 'D';
                    else if (totalCal >= 0 && totalCal <= 59)
                        clasificacion = 'F';
                    else if (totalCal < 0 || totalCal > 100)
                        MessageBox.Show("Nota invalida");
                    else
                        clasificacion = 'F';

                    if (totalCal >= 70 && totalCal <= 100)
                    {
                        estado = true;
                        strEstado = "Promovido";
                    }
                    else
                    {
                        estado = false;
                        strEstado = "Reprobado";
                    }

                    conexion.Open();
                    string ComandoStr = @$"Insert into Calificacion(ID_CALIFICACION,ESTUDIANTE_ID, MATERIA_ID, CALIFICACION1,CALIFICACION2, CALIFICACION3, CALIFICACION4, EXAMEN, TOTAL_CALIFICACION, CLASIFICACION, ESTADO)
                                        Values(@ID, @EstudianteId, @MateriaId, @calificacion1, @calificacion2, @Calificacion3, @Calificacion4, @Examen, @Total, @Clasificacion , @Estado) ";
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
                        comando.Parameters.AddWithValue("@Clasificacion", clasificacion);
                        comando.Parameters.AddWithValue("@Total", totalCal);
                        comando.Parameters.AddWithValue("@Estado", estado);

                        lblCalificacion.Text = totalCal.ToString();
                        lblClasificacion.Text = clasificacion.ToString();
                        lblEstado.Text = strEstado;

                        if (comando.ExecuteNonQuery() == 0)
                            MessageBox.Show("Calificacion agregada");


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void lblCalificacion_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string conexionStr = "Data Source= localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    decimal cal1 = Convert.ToDecimal(txtCal1Act.Text);
                    decimal cal2 = Convert.ToDecimal(txtCal2Act.Text);
                    decimal cal3 = Convert.ToDecimal(txtcal3Act.Text);
                    decimal cal4 = Convert.ToDecimal(txtCal4Act.Text);
                    decimal examen = Convert.ToDecimal(txtExamAct.Text);

                    if (cal1 < 0 || cal1 > 100)
                        MessageBox.Show("Calificacion 1: invalida");
                    if (cal2 < 0 || cal2 > 100)
                        MessageBox.Show("Calificacion 2: invalida");
                    if (cal3 < 0 || cal3 > 100)
                        MessageBox.Show("Calificacion 3: invalida");
                    if (cal4 < 0 || cal4 > 100)
                        MessageBox.Show("Calificacion 4: invalida");
                    if (examen < 0 || examen > 30)
                        MessageBox.Show("Calificacion examen: invalida");

                    decimal totalCal = ((((cal1 + cal2 + cal3 + cal4) / 4) * 70) / 100) + examen;
                    char clasificacion = 'I';
                    bool estado;
                    string strEstado = "Pendiente";

                    if (totalCal >= 90 && totalCal <= 100)
                        clasificacion = 'A';
                    else if (totalCal >= 80 && totalCal <= 89)
                        clasificacion = 'B';
                    else if (totalCal >= 70 && totalCal <= 79)
                        clasificacion = 'C';
                    else if (totalCal >= 60 && totalCal <= 69)
                        clasificacion = 'D';
                    else if (totalCal >= 0 && totalCal <= 59)
                        clasificacion = 'F';
                    else if (totalCal < 0 || totalCal > 100)
                        MessageBox.Show("Nota invalida");
                    else
                        clasificacion = 'F';

                    if (totalCal >= 70 && totalCal <= 100)
                    {
                        estado = true;
                        strEstado = "Promovido";
                    }
                    else
                    {
                        estado = false;
                        strEstado = "Reprobado";
                    }

                    conexion.Open();
                    string ComandoStr = @$"UPDATE CALIFICACION SET ESTUDIANTE_ID = @EstudianteId, MATERIA_ID = @MateriaId , CALIFICACION1 = @calificacion1,
                                            CALIFICACION2 = @calificacion2, CALIFICACION3 = @calificacion3, CALIFICACION4 = @calificacion4, 
                                             EXAMEN = @Examen, TOTAL_CALIFICACION = @Total, CLASIFICACION = @Clasificacion, ESTADO = @Estado WHERE ID_CALIFICACION = @ID ";
                    using (SqlCommand comando = new SqlCommand(ComandoStr, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIdAct.Text));
                        comando.Parameters.AddWithValue("@EstudianteId", Convert.ToInt64(txtEstuAct.Text));
                        comando.Parameters.AddWithValue("@MateriaId", Convert.ToInt64(txtMateriaAct.Text));
                        comando.Parameters.AddWithValue("@calificacion1", Convert.ToDecimal(txtCal1Act.Text));
                        comando.Parameters.AddWithValue("@calificacion2", Convert.ToDecimal(txtCal2Act.Text));
                        comando.Parameters.AddWithValue("@calificacion3", Convert.ToDecimal(txtcal3Act.Text));
                        comando.Parameters.AddWithValue("@calificacion4", Convert.ToDecimal(txtCal4Act.Text));
                        comando.Parameters.AddWithValue("@Examen", Convert.ToDecimal(txtExamAct.Text));
                        comando.Parameters.AddWithValue("@Clasificacion", clasificacion);
                        comando.Parameters.AddWithValue("@Total", totalCal);
                        comando.Parameters.AddWithValue("@Estado", estado);

                        lblTotalAct.Text = totalCal.ToString();
                        lblClasifAct.Text = clasificacion.ToString();
                        lblEstadoAct.Text = strEstado;

                        if (comando.ExecuteNonQuery() == 0)
                            MessageBox.Show("Calificacion Actualizada");
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
                string conexionStr = "Data Source=localhost;initial catalog=DBCalificacionesEstudiantes;integrated security=true;TrustServerCertificate=true";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    string comandoString = $"Delete Calificacion Where ID_CALIFICACION = @ID";
                    using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", Convert.ToInt64(txtIDEliminar.Text));
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Calificacion ELiminada");
                            lblEstudianteEliminado.Text = txtIDEliminar.Text;
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
    }
}
