namespace Proyecto_final___Sistema_de_calificacion_estudiantes
{
    partial class FrmEstudiantes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            DtpNacimiento = new DateTimePicker();
            BtnLimpiar = new Button();
            BtnEnviar = new Button();
            txtCarrera = new TextBox();
            txtMatricula = new TextBox();
            txtNombreEstudiante = new TextBox();
            txtID = new TextBox();
            groupBox2 = new GroupBox();
            BtnMostrar = new Button();
            DgvMostrar = new DataGridView();
            groupBox3 = new GroupBox();
            DtpFechaAct = new DateTimePicker();
            BtnLimpiarAct = new Button();
            BtnActualizar = new Button();
            txtCarreraAct = new TextBox();
            txtMatriculaAct = new TextBox();
            txtNombreAct = new TextBox();
            txtIDActualizar = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            BtnEliminar = new Button();
            txtIDEliminar = new TextBox();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMostrar).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 92);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "MATRICULA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 127);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 3;
            label4.Text = "FECHA NACIMIENTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 162);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "CARRERA";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(DtpNacimiento);
            groupBox1.Controls.Add(BtnLimpiar);
            groupBox1.Controls.Add(BtnEnviar);
            groupBox1.Controls.Add(txtCarrera);
            groupBox1.Controls.Add(txtMatricula);
            groupBox1.Controls.Add(txtNombreEstudiante);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 245);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "AGREGAR ESTUDIANTE";
            // 
            // DtpNacimiento
            // 
            DtpNacimiento.Location = new Point(179, 124);
            DtpNacimiento.Name = "DtpNacimiento";
            DtpNacimiento.Size = new Size(149, 26);
            DtpNacimiento.TabIndex = 12;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.Location = new Point(251, 197);
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
            BtnEnviar.Location = new Point(138, 197);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(86, 31);
            BtnEnviar.TabIndex = 10;
            BtnEnviar.Text = "ENVIAR";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(105, 158);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(154, 26);
            txtCarrera.TabIndex = 9;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(105, 89);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(154, 26);
            txtMatricula.TabIndex = 7;
            // 
            // txtNombreEstudiante
            // 
            txtNombreEstudiante.Location = new Point(104, 54);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(204, 26);
            txtNombreEstudiante.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(104, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(170, 26);
            txtID.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(BtnMostrar);
            groupBox2.Controls.Add(DgvMostrar);
            groupBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(412, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 356);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "LISTADO DE ESTUDIANTES";
            // 
            // BtnMostrar
            // 
            BtnMostrar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMostrar.Location = new Point(393, 307);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(116, 43);
            BtnMostrar.TabIndex = 11;
            BtnMostrar.Text = "MOSTRAR";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // DgvMostrar
            // 
            DgvMostrar.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMostrar.Location = new Point(18, 28);
            DgvMostrar.Name = "DgvMostrar";
            DgvMostrar.Size = new Size(554, 273);
            DgvMostrar.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(DtpFechaAct);
            groupBox3.Controls.Add(BtnLimpiarAct);
            groupBox3.Controls.Add(BtnActualizar);
            groupBox3.Controls.Add(txtCarreraAct);
            groupBox3.Controls.Add(txtMatriculaAct);
            groupBox3.Controls.Add(txtNombreAct);
            groupBox3.Controls.Add(txtIDActualizar);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 282);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 245);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar informaciones de estudiantes";
            // 
            // DtpFechaAct
            // 
            DtpFechaAct.Location = new Point(159, 127);
            DtpFechaAct.Name = "DtpFechaAct";
            DtpFechaAct.Size = new Size(149, 26);
            DtpFechaAct.TabIndex = 12;
            // 
            // BtnLimpiarAct
            // 
            BtnLimpiarAct.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiarAct.Location = new Point(251, 197);
            BtnLimpiarAct.Name = "BtnLimpiarAct";
            BtnLimpiarAct.Size = new Size(86, 31);
            BtnLimpiarAct.TabIndex = 11;
            BtnLimpiarAct.Text = "LIMPIAR";
            BtnLimpiarAct.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnActualizar.Location = new Point(128, 197);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(112, 31);
            BtnActualizar.TabIndex = 10;
            BtnActualizar.Text = "ACTUALIZAR";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // txtCarreraAct
            // 
            txtCarreraAct.Location = new Point(154, 159);
            txtCarreraAct.Name = "txtCarreraAct";
            txtCarreraAct.Size = new Size(154, 26);
            txtCarreraAct.TabIndex = 9;
            // 
            // txtMatriculaAct
            // 
            txtMatriculaAct.Location = new Point(105, 92);
            txtMatriculaAct.Name = "txtMatriculaAct";
            txtMatriculaAct.Size = new Size(154, 26);
            txtMatriculaAct.TabIndex = 7;
            // 
            // txtNombreAct
            // 
            txtNombreAct.Location = new Point(105, 60);
            txtNombreAct.Name = "txtNombreAct";
            txtNombreAct.Size = new Size(204, 26);
            txtNombreAct.TabIndex = 6;
            // 
            // txtIDActualizar
            // 
            txtIDActualizar.Location = new Point(105, 28);
            txtIDActualizar.Name = "txtIDActualizar";
            txtIDActualizar.Size = new Size(170, 26);
            txtIDActualizar.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 127);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 3;
            label6.Text = "FECHA NACIMIENTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 162);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 4;
            label7.Text = "CARRERA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 28);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 0;
            label8.Text = "Ingrese ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 60);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 1;
            label9.Text = "NOMBRE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 92);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 2;
            label10.Text = "MATRICULA";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(BtnEliminar);
            groupBox4.Controls.Add(txtIDEliminar);
            groupBox4.Controls.Add(label13);
            groupBox4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(483, 392);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(349, 118);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar Estudiante";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(105, 72);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(86, 31);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // txtIDEliminar
            // 
            txtIDEliminar.Location = new Point(105, 28);
            txtIDEliminar.Name = "txtIDEliminar";
            txtIDEliminar.Size = new Size(170, 26);
            txtIDEliminar.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 28);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 0;
            label13.Text = "Ingrese ID";
            // 
            // FrmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1014, 585);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmEstudiantes";
            Text = "Formulario Estudiantes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMostrar).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button BtnLimpiar;
        private Button BtnEnviar;
        private TextBox txtCarrera;
        private TextBox txtMatricula;
        private TextBox txtNombreEstudiante;
        private TextBox txtID;
        private GroupBox groupBox2;
        private Button BtnMostrar;
        private DataGridView DgvMostrar;
        private DateTimePicker DtpNacimiento;
        private GroupBox groupBox3;
        private DateTimePicker DtpFechaAct;
        private Button BtnLimpiarAct;
        private Button BtnActualizar;
        private TextBox txtCarreraAct;
        private TextBox txtMatriculaAct;
        private TextBox txtNombreAct;
        private TextBox txtIDActualizar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private GroupBox groupBox4;
        private Button BtnEliminar;
        private TextBox txtIDEliminar;
        private Label label13;
    }
}