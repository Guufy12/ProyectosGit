using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_gestion_de_visado
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }
        FrmPago frmpago = new FrmPago();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtcedula.Text) ||
                    string.IsNullOrWhiteSpace(txtpasaporte.Text) ||
                    string.IsNullOrWhiteSpace(txttelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtcontraseña.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }

                try
                {
                    var correo = new System.Net.Mail.MailAddress(txtCorreo.Text);
                }
                catch
                {
                    MessageBox.Show("El correo no es válido.");
                    return;
                }

                if (txtcontraseña.Text.Length < 6)
                {
                    MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                    return;
                }

                string conexionStr = "Data source=DESKTOP-SN2CAL3;initial catalog=loginUsuarios;Integrated security=true;TrustServerCertificate=true;";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    string comandoStr = "insert into RegistarUsuarios(Nombre, cedula, pasaporte, telefono, correo, contraseña) values(@nombre, @cedula, @pasaporte, @telefono, @correo, @contraseña)";
                    using (SqlCommand comando = new SqlCommand(comandoStr, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", txtnombre.Text);
                        comando.Parameters.AddWithValue("@cedula", txtcedula.Text);
                        comando.Parameters.AddWithValue("@pasaporte", txtpasaporte.Text);
                        comando.Parameters.AddWithValue("@telefono", txttelefono.Text);
                        comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@contraseña", txtcontraseña.Text);

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Usuario Registrado correctamente.");
                            FrmRegistrar.ActiveForm.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no se registró.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message);
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            frmpago.ShowDialog();
        }
    }
}
