namespace Sistema_de_gestion_de_visado
{
    partial class FrmRegistrar
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
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            txtcedula = new TextBox();
            label4 = new Label();
            txtnombre = new TextBox();
            btnIngresar = new Button();
            label2 = new Label();
            txtcontraseña = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            btnPago = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 64, 64);
            groupBox1.Controls.Add(btnPago);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtcedula);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtcontraseña);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(145, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 385);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 114);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 12;
            label6.Text = "Telefono";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(292, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 30);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 116);
            label5.Name = "label5";
            label5.Size = new Size(96, 23);
            label5.TabIndex = 10;
            label5.Text = "Pasaporte";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 30);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 35);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 8;
            label3.Text = "Cedula";
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(292, 71);
            txtcedula.Name = "txtcedula";
            txtcedula.Size = new Size(207, 30);
            txtcedula.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 35);
            label4.Name = "label4";
            label4.Size = new Size(169, 23);
            label4.TabIndex = 6;
            label4.Text = "Nombre completo";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(22, 71);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(207, 26);
            txtnombre.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.ForeColor = Color.Teal;
            btnIngresar.Location = new Point(84, 296);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(119, 50);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 197);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(292, 232);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(207, 30);
            txtcontraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 196);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 1;
            label1.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(22, 232);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 26);
            txtCorreo.TabIndex = 0;
            txtCorreo.Text = "correo@ejemplo.com";
            // 
            // btnPago
            // 
            btnPago.ForeColor = Color.Teal;
            btnPago.Location = new Point(302, 296);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(188, 50);
            btnPago.TabIndex = 13;
            btnPago.Text = "Realizar pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // FrmRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(985, 450);
            Controls.Add(groupBox1);
            Name = "FrmRegistrar";
            Text = "FrmRegistrar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnIngresar;
        private Label label2;
        private TextBox txtcontraseña;
        private Label label1;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtcedula;
        private Label label4;
        private TextBox txtnombre;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Button btnPago;
    }
}