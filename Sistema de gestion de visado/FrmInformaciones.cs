using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_gestion_de_visado
{
    public partial class FrmInformaciones : Form
    {
        public FrmInformaciones()
        {
            InitializeComponent();
        }
        FrmPago frmPago = new FrmPago();

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionaste la: " + cbVisas.Text);
            //Abrir Formulario seleccionado
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmPago.Show();
            }
            catch (Exception ex) {

                MessageBox.Show("Hubo un error: "+ex);
;            }
        }
    }
}
