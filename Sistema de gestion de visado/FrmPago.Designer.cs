namespace Sistema_de_gestion_de_visado
{
    partial class FrmPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnPago = new Button();
            label5 = new Label();
            txtfvencimiento = new TextBox();
            label3 = new Label();
            txtnumero = new TextBox();
            label4 = new Label();
            txtnombre = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtcvc = new TextBox();
            cbCitainicial = new CheckBox();
            cbCItaconsular = new CheckBox();
            cbImpuestos = new CheckBox();
            txtImpuestos = new TextBox();
            label6 = new Label();
            lblMonto = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateGray;
            groupBox1.Controls.Add(lblMonto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtImpuestos);
            groupBox1.Controls.Add(cbImpuestos);
            groupBox1.Controls.Add(cbCItaconsular);
            groupBox1.Controls.Add(cbCitainicial);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtcvc);
            groupBox1.Controls.Add(btnPago);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtfvencimiento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtnumero);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(30, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 479);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Realizacion de pago correspondientes";
            // 
            // btnPago
            // 
            btnPago.ForeColor = Color.Teal;
            btnPago.Location = new Point(349, 356);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(188, 50);
            btnPago.TabIndex = 13;
            btnPago.Text = "Realizar pago";
            btnPago.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 271);
            label5.Name = "label5";
            label5.Size = new Size(202, 23);
            label5.TabIndex = 10;
            label5.Text = "Fecha de vencimiento";
            // 
            // txtfvencimiento
            // 
            txtfvencimiento.Location = new Point(28, 307);
            txtfvencimiento.Name = "txtfvencimiento";
            txtfvencimiento.Size = new Size(93, 30);
            txtfvencimiento.TabIndex = 9;
            txtfvencimiento.Text = "  /";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 106);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 8;
            label3.Text = "Numero de tarjeta";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(25, 138);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(207, 30);
            txtnumero.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 35);
            label4.Name = "label4";
            label4.Size = new Size(174, 23);
            label4.TabIndex = 6;
            label4.Text = "Nombre del titular";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(22, 71);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(207, 26);
            txtnombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 187);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 1;
            label1.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(25, 227);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 26);
            txtCorreo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 356);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 15;
            label2.Text = "Codigo CVC";
            // 
            // txtcvc
            // 
            txtcvc.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtcvc.Location = new Point(28, 389);
            txtcvc.Name = "txtcvc";
            txtcvc.Size = new Size(78, 26);
            txtcvc.TabIndex = 14;
            // 
            // cbCitainicial
            // 
            cbCitainicial.AutoSize = true;
            cbCitainicial.Location = new Point(334, 71);
            cbCitainicial.Name = "cbCitainicial";
            cbCitainicial.Size = new Size(124, 27);
            cbCitainicial.TabIndex = 16;
            cbCitainicial.Text = "Cita inicial";
            cbCitainicial.UseVisualStyleBackColor = true;
            // 
            // cbCItaconsular
            // 
            cbCItaconsular.AutoSize = true;
            cbCItaconsular.Location = new Point(335, 122);
            cbCItaconsular.Name = "cbCItaconsular";
            cbCItaconsular.Size = new Size(144, 27);
            cbCItaconsular.TabIndex = 17;
            cbCItaconsular.Text = "Cita consular";
            cbCItaconsular.UseVisualStyleBackColor = true;
            // 
            // cbImpuestos
            // 
            cbImpuestos.AutoSize = true;
            cbImpuestos.Location = new Point(334, 171);
            cbImpuestos.Name = "cbImpuestos";
            cbImpuestos.Size = new Size(176, 27);
            cbImpuestos.TabIndex = 18;
            cbImpuestos.Text = "Impuestos extras";
            cbImpuestos.UseVisualStyleBackColor = true;
            // 
            // txtImpuestos
            // 
            txtImpuestos.Location = new Point(525, 169);
            txtImpuestos.Name = "txtImpuestos";
            txtImpuestos.Size = new Size(100, 30);
            txtImpuestos.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 294);
            label6.Name = "label6";
            label6.Size = new Size(149, 23);
            label6.TabIndex = 20;
            label6.Text = "Monto a pagar: ";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(489, 294);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(20, 23);
            lblMonto.TabIndex = 21;
            lblMonto.Text = "0";
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmPago";
            Text = "FrmPago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPago;
        private Label label5;
        private TextBox txtfvencimiento;
        private Label label3;
        private TextBox txtnumero;
        private Label label4;
        private TextBox txtnombre;
        private Label label1;
        private TextBox txtCorreo;
        private CheckBox cbCitainicial;
        private Label label2;
        private TextBox txtcvc;
        private Label lblMonto;
        private Label label6;
        private TextBox txtImpuestos;
        private CheckBox cbImpuestos;
        private CheckBox cbCItaconsular;
    }
}