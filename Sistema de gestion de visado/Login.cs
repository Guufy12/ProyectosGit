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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string conexionStr = "Data source=DESKTOP-SN2CAL3;initial catalog=loginUsuarios;Integrated security=true;TrustServerCertificate=true;";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    string comandoStr = "insert into datosUsuarios(Correo, Contraseña) values(@correo, @contraseña)";
                    using (SqlCommand comando = new SqlCommand(comandoStr, conexion))
                    {
                        comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@contraseña", txtCorreo.Text);

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Has ingresado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Disculpa, no pudo ingresar.");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrar.ShowDialog();
        }
    }
}
