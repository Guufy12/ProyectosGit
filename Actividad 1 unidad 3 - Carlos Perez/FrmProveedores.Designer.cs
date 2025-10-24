namespace Actividad_1_unidad_3___Carlos_Perez
{
    partial class FrmProveedores
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
            groupBox4 = new GroupBox();
            txtActualizarProveedorID = new TextBox();
            label9 = new Label();
            btnActualizar = new Button();
            txtActualizarTelefono = new TextBox();
            TxtActualizarCorreo = new TextBox();
            txtActualizarNombre = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            txtEliminarProveedor = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            btnMostrar = new Button();
            dgvProveedores = new DataGridView();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtProveedorID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtProveedorNombre = new TextBox();
            lblClienteID = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonFace;
            groupBox4.Controls.Add(txtActualizarProveedorID);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(btnActualizar);
            groupBox4.Controls.Add(txtActualizarTelefono);
            groupBox4.Controls.Add(TxtActualizarCorreo);
            groupBox4.Controls.Add(txtActualizarNombre);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(12, 274);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(410, 234);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "ACTUALIZAR DATOS";
            // 
            // txtActualizarProveedorID
            // 
            txtActualizarProveedorID.Location = new Point(164, 69);
            txtActualizarProveedorID.Name = "txtActualizarProveedorID";
            txtActualizarProveedorID.Size = new Size(143, 22);
            txtActualizarProveedorID.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 69);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 25;
            label9.Text = "CLIENTEID";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(174, 174);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 34);
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtActualizarTelefono
            // 
            txtActualizarTelefono.Location = new Point(164, 107);
            txtActualizarTelefono.Name = "txtActualizarTelefono";
            txtActualizarTelefono.Size = new Size(143, 22);
            txtActualizarTelefono.TabIndex = 22;
            // 
            // TxtActualizarCorreo
            // 
            TxtActualizarCorreo.Location = new Point(174, 142);
            TxtActualizarCorreo.Name = "TxtActualizarCorreo";
            TxtActualizarCorreo.Size = new Size(203, 22);
            TxtActualizarCorreo.TabIndex = 21;
            // 
            // txtActualizarNombre
            // 
            txtActualizarNombre.Location = new Point(164, 31);
            txtActualizarNombre.Name = "txtActualizarNombre";
            txtActualizarNombre.Size = new Size(204, 22);
            txtActualizarNombre.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 107);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 18;
            label6.Text = "TELEFONO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 148);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 17;
            label7.Text = "CORREO ELECTRONICO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 34);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 16;
            label8.Text = "NOMBRE COMPLETO";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Azure;
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(txtEliminarProveedor);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(439, 381);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(429, 107);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "ELIMINAR PROVEEDOR";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(171, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 34);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtEliminarProveedor
            // 
            txtEliminarProveedor.Location = new Point(155, 31);
            txtEliminarProveedor.Name = "txtEliminarProveedor";
            txtEliminarProveedor.Size = new Size(143, 25);
            txtEliminarProveedor.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 35);
            label10.Name = "label10";
            label10.Size = new Size(119, 17);
            label10.TabIndex = 6;
            label10.Text = "ID PROVEEDOR";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnMostrar);
            groupBox2.Controls.Add(dgvProveedores);
            groupBox2.Location = new Point(439, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 326);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "LISTA PROVEEDORES";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(282, 276);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(106, 34);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.BackgroundColor = SystemColors.Control;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(17, 31);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(412, 239);
            dgvProveedores.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtProveedorID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProveedorNombre);
            groupBox1.Controls.Add(lblClienteID);
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 226);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS PROVEEDORES";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(212, 176);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 34);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(133, 98);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(143, 25);
            txtTelefono.TabIndex = 12;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(202, 138);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(172, 25);
            txtCorreo.TabIndex = 11;
            // 
            // txtProveedorID
            // 
            txtProveedorID.Location = new Point(171, 24);
            txtProveedorID.Name = "txtProveedorID";
            txtProveedorID.Size = new Size(166, 25);
            txtProveedorID.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 163);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(85, 17);
            label3.TabIndex = 8;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 146);
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
            label1.Size = new Size(123, 17);
            label1.TabIndex = 6;
            label1.Text = " ID PROVEEDOR";
            label1.Click += label1_Click;
            // 
            // txtProveedorNombre
            // 
            txtProveedorNombre.Location = new Point(185, 57);
            txtProveedorNombre.Name = "txtProveedorNombre";
            txtProveedorNombre.Size = new Size(180, 25);
            txtProveedorNombre.TabIndex = 5;
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Location = new Point(6, 65);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(167, 17);
            lblClienteID.TabIndex = 0;
            lblClienteID.Text = "NOMBRE PROVEEDOR";
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(896, 530);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "FrmProveedores";
            Text = "FrmProveedores";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private TextBox txtActualizarProveedorID;
        private Label label9;
        private Button btnActualizar;
        private TextBox txtActualizarDireccion;
        private TextBox txtActualizarTelefono;
        private TextBox TxtActualizarCorreo;
        private TextBox txtActualizarNombre;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private TextBox txtEliminarProveedor;
        private Label label10;
        private GroupBox groupBox2;
        private Button btnMostrar;
        private DataGridView dgvProveedores;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtProveedorID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtProveedorNombre;
        private Label lblClienteID;
    }
}