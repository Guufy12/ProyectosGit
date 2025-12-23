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
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            decimal montoTotal = 0;
            int citaConsular = 14000;
            int citaBasica = 2000;
            int impuestoExtras = 0;

            if (!string.IsNullOrWhiteSpace(txtImpuestos.Text))
                impuestoExtras = Convert.ToInt32(txtImpuestos.Text);

            if (cbCitainicial.Checked)
                montoTotal += citaBasica;

            if (cbCItaconsular.Checked)
                montoTotal += citaConsular;

            if (cbImpuestos.Checked)
                montoTotal += impuestoExtras;

            lblMonto.Text = montoTotal.ToString();

            try
            {
                if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtnumero.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtfvencimiento.Text) ||
                    string.IsNullOrWhiteSpace(txtcvc.Text))
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

                string conexionStr = "Data source=DESKTOP-SN2CAL3;initial catalog=loginUsuarios;Integrated security=true;TrustServerCertificate=true;";

                using (SqlConnection conexion = new SqlConnection(conexionStr))
                {
                    conexion.Open();

                    string comandoStr = @"insert into pagos(NombreTitular, NumeroTarjeta, correoElectronico, fechaVencimiento, montoPago, codigoCvc) 
                              values(@NombreTitular, @NumeroTarjeta, @correoElectronico, @fechaVencimiento, @montoPago, @codigoCvc)";

                    using (SqlCommand comando = new SqlCommand(comandoStr, conexion))
                    {
                        comando.Parameters.AddWithValue("@NombreTitular", txtnombre.Text);
                        comando.Parameters.AddWithValue("@NumeroTarjeta", txtnumero.Text);
                        comando.Parameters.AddWithValue("@correoElectronico", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@fechaVencimiento", txtfvencimiento.Text);
                        comando.Parameters.AddWithValue("@montoPago", montoTotal);
                        comando.Parameters.AddWithValue("@codigoCvc", txtcvc.Text);

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Usuario Registrado correctamente.");
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
    }
}
