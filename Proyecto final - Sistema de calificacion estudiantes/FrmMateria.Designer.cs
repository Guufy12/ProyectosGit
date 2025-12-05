namespace Proyecto_final___Sistema_de_calificacion_estudiantes
{
    partial class FrmMateria
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
            btnExportar = new Button();
            BtnMostrar = new Button();
            DgvMostrarMaterias = new DataGridView();
            groupBox1 = new GroupBox();
            BtnLimpiar = new Button();
            BtnEnviar = new Button();
            txtCreditos = new TextBox();
            txtNombreMateria = new TextBox();
            txtIDMateria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            txtCreditosAct = new TextBox();
            txtNombreAct = new TextBox();
            txtIdAct = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            BtnELiminar = new Button();
            txtIdEliminar = new TextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMostrarMaterias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnExportar);
            groupBox2.Controls.Add(BtnMostrar);
            groupBox2.Controls.Add(DgvMostrarMaterias);
            groupBox2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(469, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 244);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de Materias";
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(179, 196);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(116, 40);
            btnExportar.TabIndex = 13;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMostrar.Location = new Point(23, 195);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(116, 43);
            BtnMostrar.TabIndex = 11;
            BtnMostrar.Text = "MOSTRAR";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // DgvMostrarMaterias
            // 
            DgvMostrarMaterias.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvMostrarMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMostrarMaterias.Location = new Point(23, 28);
            DgvMostrarMaterias.Name = "DgvMostrarMaterias";
            DgvMostrarMaterias.Size = new Size(433, 157);
            DgvMostrarMaterias.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(BtnLimpiar);
            groupBox1.Controls.Add(BtnEnviar);
            groupBox1.Controls.Add(txtCreditos);
            groupBox1.Controls.Add(txtNombreMateria);
            groupBox1.Controls.Add(txtIDMateria);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 211);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Materia";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.Location = new Point(256, 154);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(86, 31);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "LIMPIAR";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnEnviar
            // 
            BtnEnviar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEnviar.Location = new Point(149, 154);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(86, 31);
            BtnEnviar.TabIndex = 10;
            BtnEnviar.Text = "ENVIAR";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(188, 120);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(154, 27);
            txtCreditos.TabIndex = 7;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(188, 80);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(192, 27);
            txtNombreMateria.TabIndex = 6;
            // 
            // txtIDMateria
            // 
            txtIDMateria.Location = new Point(188, 45);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.Size = new Size(170, 27);
            txtIDMateria.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "ID de Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.Location = new Point(19, 83);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Materia";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label3.Location = new Point(17, 122);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 2;
            label3.Text = "Creditos de materia";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(txtCreditosAct);
            groupBox3.Controls.Add(txtNombreAct);
            groupBox3.Controls.Add(txtIdAct);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(27, 229);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(416, 185);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualilzar Materia";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(256, 143);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 11;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(149, 144);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 10;
            button2.Text = "ENVIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCreditosAct
            // 
            txtCreditosAct.Location = new Point(188, 108);
            txtCreditosAct.Name = "txtCreditosAct";
            txtCreditosAct.Size = new Size(154, 27);
            txtCreditosAct.TabIndex = 7;
            // 
            // txtNombreAct
            // 
            txtNombreAct.Location = new Point(188, 66);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(192, 27);
            txtNombreAct.TabIndex = 6;
            // 
            // txtIdAct
            // 
            txtIdAct.Location = new Point(188, 31);
            txtIdAct.Name = "txtIdAct";
            txtIdAct.Size = new Size(170, 27);
            txtIdAct.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 31);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 0;
            label4.Text = "ID de Materia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label5.Location = new Point(19, 69);
            label5.Name = "label5";
            label5.Size = new Size(152, 23);
            label5.TabIndex = 1;
            label5.Text = "Nombre de Materia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label6.Location = new Point(17, 108);
            label6.Name = "label6";
            label6.Size = new Size(157, 23);
            label6.TabIndex = 2;
            label6.Text = "Creditos de materia";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(BtnELiminar);
            groupBox4.Controls.Add(txtIdEliminar);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Font = new Font("Arial Narrow", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(469, 271);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(439, 129);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar Materia";
            // 
            // BtnELiminar
            // 
            BtnELiminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnELiminar.Location = new Point(220, 78);
            BtnELiminar.Name = "BtnELiminar";
            BtnELiminar.Size = new Size(86, 31);
            BtnELiminar.TabIndex = 10;
            BtnELiminar.Text = "Eliminar";
            BtnELiminar.UseVisualStyleBackColor = true;
            BtnELiminar.Click += BtnELiminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(188, 35);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(170, 27);
            txtIdEliminar.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 39);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 0;
            label7.Text = "ID de Materia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label8.Location = new Point(19, 69);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 1;
            // 
            // FrmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1021, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FrmMateria";
            Text = "FrmMateria";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMostrarMaterias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button BtnMostrar;
        private DataGridView DgvMostrarMaterias;
        private GroupBox groupBox1;
        private Button BtnLimpiar;
        private Button BtnEnviar;
        private TextBox txtCreditos;
        private TextBox txtNombreMateria;
        private TextBox txtIDMateria;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private TextBox txtCreditosAct;
        private TextBox txtNombreAct;
        private TextBox txtIdAct;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox4;
        private Button BtnELiminar;
        private TextBox txtIdEliminar;
        private Label label7;
        private Label label8;
        private Button btnExportar;
    }
}