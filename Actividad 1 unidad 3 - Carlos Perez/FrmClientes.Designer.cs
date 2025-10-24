namespace Actividad_1_unidad_3___Carlos_Perez
{
    partial class FrmClientes
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
            groupBox2 = new GroupBox();
            btnMostrar = new Button();
            dgvClientes = new DataGridView();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            txtEliminarCliente = new TextBox();
            label10 = new Label();
            groupBox4 = new GroupBox();
            txtActualizarClienteid = new TextBox();
            label9 = new Label();
            btnActualizar = new Button();
            txtActualizarDireccion = new TextBox();
            txtActualizarTelefono = new TextBox();
            TxtActualizarCorreo = new TextBox();
            txtActualizarNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblClienteID = new Label();
            txtClienteID = new TextBox();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnMostrar);
            groupBox2.Controls.Add(dgvClientes);
            groupBox2.Location = new Point(433, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 236);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "LISTA CLIENTES";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(278, 196);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(106, 34);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = SystemColors.Control;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(17, 31);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(412, 159);
            dgvClientes.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Azure;
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(txtEliminarCliente);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(477, 302);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(306, 107);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "ELIMINAR CLIENTE";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(147, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 34);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtEliminarCliente
            // 
            txtEliminarCliente.Location = new Point(133, 31);
            txtEliminarCliente.Name = "txtEliminarCliente";
            txtEliminarCliente.Size = new Size(143, 25);
            txtEliminarCliente.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 35);
            label10.Name = "label10";
            label10.Size = new Size(86, 17);
            label10.TabIndex = 6;
            label10.Text = "CLIENTEID";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonFace;
            groupBox4.Controls.Add(txtActualizarClienteid);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(btnActualizar);
            groupBox4.Controls.Add(txtActualizarDireccion);
            groupBox4.Controls.Add(txtActualizarTelefono);
            groupBox4.Controls.Add(TxtActualizarCorreo);
            groupBox4.Controls.Add(txtActualizarNombre);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 266);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(426, 234);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "ACTUALIZAR DATOS";
            // 
            // txtActualizarClienteid
            // 
            txtActualizarClienteid.Location = new Point(156, 54);
            txtActualizarClienteid.Name = "txtActualizarClienteid";
            txtActualizarClienteid.Size = new Size(143, 22);
            txtActualizarClienteid.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 57);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 25;
            label9.Text = "CLIENTEID";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(194, 194);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 34);
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtActualizarDireccion
            // 
            txtActualizarDireccion.Location = new Point(194, 155);
            txtActualizarDireccion.Name = "txtActualizarDireccion";
            txtActualizarDireccion.Size = new Size(217, 22);
            txtActualizarDireccion.TabIndex = 23;
            // 
            // txtActualizarTelefono
            // 
            txtActualizarTelefono.Location = new Point(156, 93);
            txtActualizarTelefono.Name = "txtActualizarTelefono";
            txtActualizarTelefono.Size = new Size(143, 22);
            txtActualizarTelefono.TabIndex = 22;
            // 
            // TxtActualizarCorreo
            // 
            TxtActualizarCorreo.Location = new Point(194, 122);
            TxtActualizarCorreo.Name = "TxtActualizarCorreo";
            TxtActualizarCorreo.Size = new Size(203, 22);
            TxtActualizarCorreo.TabIndex = 21;
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(184, 22);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(204, 22);
            txtActualizarNombre.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 158);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 19;
            label5.Text = "DIRECCION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 96);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 18;
            label6.Text = "TELEFONO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 129);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 17;
            label7.Text = "CORREO ELECTRONICO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 25);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 16;
            label8.Text = "NOMBRE COMPLETO";
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Location = new Point(15, 68);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(86, 17);
            lblClienteID.TabIndex = 0;
            lblClienteID.Text = "CLIENTEID";
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(122, 60);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(84, 25);
            txtClienteID.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtClienteID);
            groupBox1.Controls.Add(lblClienteID);
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 226);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS CLIENTE";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(185, 186);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 34);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(159, 155);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(190, 25);
            txtDireccion.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(122, 93);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(143, 25);
            txtTelefono.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(194, 124);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(172, 25);
            txtCorreo.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 25);
            txtNombre.TabIndex = 10;
            txtNombre.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 163);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 9;
            label4.Text = "DIRECCION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 101);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 8;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 130);
            label2.Name = "label2";
            label2.Size = new Size(177, 17);
            label2.TabIndex = 7;
            label2.Text = "CORREO ELECTRONICO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 31);
            label1.Name = "label1";
            label1.Size = new Size(157, 17);
            label1.TabIndex = 6;
            label1.Text = "NOMBRE COMPLETO";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(895, 512);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmClientes";
            Text = "FORMULARIO CLIENTES";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblClienteID;
        private TextBox txtClienteID;
        private GroupBox groupBox1;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvClientes;
        private TextBox txtActualizarDireccion;
        private TextBox txtActualizarTelefono;
        private TextBox TxtActualizarCorreo;
        private TextBox txtActualizarNombre;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnMostrar;
        private Button btnEliminar;
        private TextBox txtEliminarCliente;
        private Label label10;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtActualizarClienteid;
        private Label label9;
    }
}