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
                    string comandoString = "SELECT * FROM Calificacion";
                    using (SqlCommand comando = new SqlCommand(comandoString, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                        DgvMostrarCalificaciones.DataSource = tabla;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;
            int idEstudiante;
            int idMateria;
            decimal cal1;
            decimal cal2;
            decimal cal3;
            decimal cal4;
            decimal examen;

            if (string.IsNullOrEmpty(txtID.Text))
            {
                Mensaje += "campo Id Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtIdEstudiante.Text))
            {
                Mensaje += "Id de Estudiante Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtMateriaId.Text))
            {
                Mensaje += "Id de Materia Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtCal1.Text))
            {
                Mensaje += "Calificacion 1 Vacia\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtCal2.Text))
            {
                Mensaje += "Calificacion 2 Vacia Vacia\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtCal3.Text))
            {
                Mensaje += "Calificacion 3 vacia Vacio\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtCal4.Text))
            {
                Mensaje += "Calificacion 4 vacia\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtExamen.Text))
            {
                Mensaje += "Puntuacion de examen vacio\n";
                error = true;

            }
            if (!int.TryParse(txtID.Text, out id))
            {
                Mensaje += "El Id de calificacion debe ser un numero\n";
                error = true;
            }
            if (!int.TryParse(txtIdEstudiante.Text, out idEstudiante))
            {
                Mensaje += "El Id de estudiante debe ser un numero\n";
                error = true;
            }
            if (!int.TryParse(txtMateriaId.Text, out idMateria))
            {
                Mensaje += "El Id de la materia debe ser un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtCal1.Text, out cal1))
            {
                Mensaje += "campo calificacion 1 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtCal2.Text, out cal2))
            {
                Mensaje += "campo calificacion 2 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtCal3.Text, out cal3))
            {
                Mensaje += "campo calificacion 3 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtCal4.Text, out cal4))
            {
                Mensaje += "campo calificacion 4 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtExamen.Text, out examen))
            {
                Mensaje += "campo examen invalido. Se debe ingresar un numero\n";
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

                            if (comando.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Calificacion agregada");
                                txtID.Clear();
                                txtIdEstudiante.Clear();
                                txtMateriaId.Clear();
                                txtCal1.Clear();
                                txtCal2.Clear();
                                txtCal3.Clear();
                                txtCal4.Clear();
                                txtExamen.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Ningun registro agregado");
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex);
                }
            }
        }

        private void lblCalificacion_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Mensaje = "Se detectaron los siguientes errores: \n\n";
            bool error = false;
            int id;
            int idEstudiante;
            int idMateria;
            decimal cal1;
            decimal cal2;
            decimal cal3;
            decimal cal4;
            decimal examen;

            if (string.IsNullOrEmpty(txtIdAct.Text))
            {
                Mensaje += "campo Id Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtEstuAct.Text))
            {
                Mensaje += "Id de Estudiante Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtMateriaAct.Text))
            {
                Mensaje += "Id de Materia Vacio\n";
                error = true;
            }
            if (string.IsNullOrEmpty(txtCal1Act.Text))
            {
                Mensaje += "Calificacion 1 Vacia\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtCal2Act.Text))
            {
                Mensaje += "Calificacion 2 Vacia Vacia\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtcal3Act.Text))
            {
                Mensaje += "Calificacion 3 vacia Vacio\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtCal4Act.Text))
            {
                Mensaje += "Calificacion 4 vacia\n";
                error = true;

            }
            if (string.IsNullOrEmpty(txtExamAct.Text))
            {
                Mensaje += "Puntuacion de examen vacio\n";
                error = true;

            }
            if (!int.TryParse(txtIdAct.Text, out id))
            {
                Mensaje += "El Id de calificacion debe ser un numero\n";
                error = true;
            }
            if (!int.TryParse(txtEstuAct.Text, out idEstudiante))
            {
                Mensaje += "El Id de estudiante debe ser un numero\n";
                error = true;
            }
            if (!int.TryParse(txtMateriaAct.Text, out idMateria))
            {
                Mensaje += "El Id de la materia debe ser un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtCal1Act.Text, out cal1))
            {
                Mensaje += "campo calificacion 1 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtCal2Act.Text, out cal2))
            {
                Mensaje += "campo calificacion 2 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtcal3Act.Text, out cal3))
            {
                Mensaje += "campo calificacion 3 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtCal4Act.Text, out cal4))
            {
                Mensaje += "campo calificacion 4 invalido. Se debe ingresar un numero\n";
                error = true;
            }
            if (!decimal.TryParse(txtExamAct.Text, out examen))
            {
                Mensaje += "campo examen invalido. Se debe ingresar un numero\n";
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
                            
                            if (comando.ExecuteNonQuery() > 0)
                                MessageBox.Show("Calificacion Actualizada");
                            else
                            {
                                MessageBox.Show("No se actualizo ningun registro.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("No se puede agregar registro. No hay relacion valida en la Fk.");
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
                            else
                            {
                                MessageBox.Show("No se encontro ningun registro");

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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string texto = "";

                for (int i = 0; i < DgvMostrarCalificaciones.Columns.Count; i++)
                {
                    texto += DgvMostrarCalificaciones.Columns[i].HeaderText;

                    if (i < DgvMostrarCalificaciones.Columns.Count - 1)
                        texto += ",";
                }

                texto += Environment.NewLine;

                foreach (DataGridViewRow fila in DgvMostrarCalificaciones.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        for (int i = 0; i < DgvMostrarCalificaciones.Columns.Count; i++)
                        {
                            texto += fila.Cells[i].Value?.ToString();

                            if (i < DgvMostrarCalificaciones.Columns.Count - 1)
                                texto += ",";
                        }

                        texto += Environment.NewLine;
                    }
                }

                string ruta = Application.StartupPath + "\\ListaCalificaciones.csv";

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
            txtID.Clear();
            txtIdEstudiante.Clear();
            txtMateriaId.Clear();
            txtCal1.Clear();
            txtCal2.Clear();
            txtCal3.Clear();
            txtCal4.Clear();
            txtExamen.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdAct.Clear();
            txtEstuAct.Clear();
            txtMateriaAct.Clear();
            txtCal1Act.Clear();
            txtCal2Act.Clear();
            txtcal3Act.Clear();
            txtCal4Act.Clear();
            txtExamAct.Clear();
        }
    }
}
