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

                string conexionStr = "Data source=DESKTOP-SN2CAL3;initial catalog=loginUsuarios;Integrated security=true;TrustServerCertificate=true;";
                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();
                    string comandoStr = "insert into datosUsuarios(Correo, Contraseña) values(@correo, @contraseña)";
                    using (SqlCommand comando = new SqlCommand(comandoStr, conexion))
                    {
                        //comando.Parameters.AddWithValue("@id", id += id + 1);
                        comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@contraseña", txtCorreo.Text);

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Usuario Registrado correctamente.");
                            //FrmRegistrar.ActiveForm.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no se registro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex);
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            frmpago.ShowDialog();
        }
    }
}
