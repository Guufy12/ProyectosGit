namespace Actividad_1_unidad_3___Carlos_Perez
{
    partial class FrmCategorias
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
            cbActualizarCategoria = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnActualizar = new Button();
            txtActualizarCategoria = new TextBox();
            groupBox3 = new GroupBox();
            btnEliminar = new Button();
            txtEliminarCategoria = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            btnMostrar = new Button();
            dgvCategorias = new DataGridView();
            groupBox1 = new GroupBox();
            txtCategoriaId = new TextBox();
            label1 = new Label();
            cbCategorias = new ComboBox();
            btnAgregar = new Button();
            label4 = new Label();
            lblClienteID = new Label();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonFace;
            groupBox4.Controls.Add(cbActualizarCategoria);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(btnActualizar);
            groupBox4.Controls.Add(txtActualizarCategoria);
            groupBox4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(15, 188);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(410, 162);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "ACTUALIZAR DATOS";
            // 
            // cbActualizarCategoria
            // 
            cbActualizarCategoria.FormattingEnabled = true;
            cbActualizarCategoria.Items.AddRange(new object[] { "CONSUMO", "HIGIENE", "UTILIDAD", "LIMPIEZA", "CUIDADO PERSONAL", "ENTRETENIMIENTO", "DEPORTES" });
            cbActualizarCategoria.Location = new Point(186, 69);
            cbActualizarCategoria.Name = "cbActualizarCategoria";
            cbActualizarCategoria.Size = new Size(121, 23);
            cbActualizarCategoria.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 28;
            label2.Text = "ID CATEGORIAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 72);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 27;
            label3.Text = "NOMBRE CATEGORIA";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(188, 103);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(106, 34);
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtActualizarCategoria
            // 
            txtActualizarCategoria.Location = new Point(164, 31);
            txtActualizarCategoria.Name = "txtActualizarCategoria";
            txtActualizarCategoria.Size = new Size(204, 22);
            txtActualizarCategoria.TabIndex = 20;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Azure;
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(txtEliminarCategoria);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(443, 357);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(429, 107);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "ELIMINAR CATEGORIA";
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
            // txtEliminarCategoria
            // 
            txtEliminarCategoria.Location = new Point(155, 31);
            txtEliminarCategoria.Name = "txtEliminarCategoria";
            txtEliminarCategoria.Size = new Size(143, 25);
            txtEliminarCategoria.TabIndex = 7;
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
            groupBox2.Controls.Add(dgvCategorias);
            groupBox2.Location = new Point(447, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(445, 326);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "LISTA DE CATEGORIAS";
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
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = SystemColors.Control;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(17, 31);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(412, 239);
            dgvCategorias.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtCategoriaId);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbCategorias);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblClienteID);
            groupBox1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 157);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS CATEGORIAS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtCategoriaId
            // 
            txtCategoriaId.Location = new Point(164, 37);
            txtCategoriaId.Name = "txtCategoriaId";
            txtCategoriaId.Size = new Size(204, 25);
            txtCategoriaId.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 29;
            label1.Text = "ID CATEGORIAS";
            // 
            // cbCategorias
            // 
            cbCategorias.FormattingEnabled = true;
            cbCategorias.Items.AddRange(new object[] { "CONSUMO", "HIGIENE", "UTILIDAD", "LIMPIEZA", "CUIDADO PERSONAL", "ENTRETENIMIENTO", "DEPORTES" });
            cbCategorias.Location = new Point(201, 77);
            cbCategorias.Name = "cbCategorias";
            cbCategorias.Size = new Size(184, 25);
            cbCategorias.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(201, 117);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 34);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 163);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 9;
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Location = new Point(15, 77);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(160, 17);
            lblClienteID.TabIndex = 0;
            lblClienteID.Text = "NOMBRE CATEGORIA";
            lblClienteID.Click += lblClienteID_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(904, 503);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button btnActualizar;
        private TextBox txtActualizarCategoria;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private TextBox txtEliminarCategoria;
        private Label label10;
        private GroupBox groupBox2;
        private Button btnMostrar;
        private DataGridView dgvCategorias;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private Label label4;
        private Label lblClienteID;
        private Label label2;
        private Label label3;
        private ComboBox cbCategorias;
        private Label label1;
        private ComboBox cbActualizarCategoria;
        private TextBox txtCategoriaId;
    }
}