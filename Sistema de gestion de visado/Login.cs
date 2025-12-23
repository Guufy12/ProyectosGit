using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sistema_de_gestion_de_visado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        FrmRegistrar registrar = new FrmRegistrar();
        FrmInformaciones frmInformaciones = new FrmInformaciones();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Debe ingresar un correo.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtcontraseña.Text))
                {
                    MessageBox.Show("Debe ingresar una contraseña.");
                    return;
                }

                try
                {
                    var correo = new System.Net.Mail.MailAddress(txtCorreo.Text);
                }
                catch
                {
                    MessageBox.Show("El formato del correo no es válido.");
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

                    string comandoStr = "INSERT INTO datosUsuarios (Correo, Contraseña) VALUES (@correo, @contraseña)";

                    using (SqlCommand comando = new SqlCommand(comandoStr, conexion))
                    {
                        comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@contraseña", txtcontraseña.Text);

                        int resultado = comando.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Has ingresado correctamente.");
                            frmInformaciones.Show();
                        }
                        else
                        {
                            MessageBox.Show("Disculpa, no se pudo realizar el registro.");
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
                MessageBox.Show("Hubo un error inesperado: " + ex.Message);
            }
        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrar.ShowDialog();
        }
    }
}
