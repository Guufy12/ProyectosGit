namespace Proyecto_final___Sistema_de_calificacion_estudiantes
{
    partial class FrmCalificaciones
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
            BtnMostrarCalificaciones = new Button();
            DgvMostrarCalificaciones = new DataGridView();
            groupBox2 = new GroupBox();
            lblCalificacion = new Label();
            lblClasificacion = new Label();
            lblEstado = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtExamen = new TextBox();
            label8 = new Label();
            txtCal3 = new TextBox();
            txtCal4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtCal1 = new TextBox();
            BtnLimpiar = new Button();
            BtnEnviar = new Button();
            txtCal2 = new TextBox();
            txtMateriaId = new TextBox();
            txtIdEstudiante = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMostrarCalificaciones).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(BtnMostrarCalificaciones);
            groupBox1.Controls.Add(DgvMostrarCalificaciones);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 185);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "LISTADO DE CALIFICACIONES";
            // 
            // BtnMostrarCalificaciones
            // 
            BtnMostrarCalificaciones.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMostrarCalificaciones.Location = new Point(830, 138);
            BtnMostrarCalificaciones.Name = "BtnMostrarCalificaciones";
            BtnMostrarCalificaciones.Size = new Size(116, 43);
            BtnMostrarCalificaciones.TabIndex = 11;
            BtnMostrarCalificaciones.Text = "MOSTRAR";
            BtnMostrarCalificaciones.UseVisualStyleBackColor = true;
            BtnMostrarCalificaciones.Click += BtnMostrarCalificaciones_Click;
            // 
            // DgvMostrarCalificaciones
            // 
            DgvMostrarCalificaciones.BackgroundColor = Color.FromArgb(224, 224, 224);
            DgvMostrarCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMostrarCalificaciones.Location = new Point(18, 28);
            DgvMostrarCalificaciones.Name = "DgvMostrarCalificaciones";
            DgvMostrarCalificaciones.Size = new Size(955, 104);
            DgvMostrarCalificaciones.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblCalificacion);
            groupBox2.Controls.Add(lblClasificacion);
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtExamen);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCal3);
            groupBox2.Controls.Add(txtCal4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCal1);
            groupBox2.Controls.Add(BtnLimpiar);
            groupBox2.Controls.Add(BtnEnviar);
            groupBox2.Controls.Add(txtCal2);
            groupBox2.Controls.Add(txtMateriaId);
            groupBox2.Controls.Add(txtIdEstudiante);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(979, 235);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Calificaciones";
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCalificacion.Location = new Point(794, 49);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(18, 19);
            lblCalificacion.TabIndex = 22;
            lblCalificacion.Text = "0";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblClasificacion.Location = new Point(794, 90);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(86, 19);
            lblClasificacion.TabIndex = 23;
            lblClasificacion.Text = "Pendiente";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblEstado.Location = new Point(794, 131);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(86, 19);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Pendiente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 14.25F);
            label9.Location = new Point(570, 45);
            label9.Name = "label9";
            label9.Size = new Size(148, 23);
            label9.TabIndex = 19;
            label9.Text = "Total de calificacion:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 14.25F);
            label10.Location = new Point(570, 86);
            label10.Name = "label10";
            label10.Size = new Size(200, 23);
            label10.TabIndex = 20;
            label10.Text = "Clasificacion del estudiante:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 14.25F);
            label11.Location = new Point(570, 127);
            label11.Name = "label11";
            label11.Size = new Size(62, 23);
            label11.TabIndex = 21;
            label11.Text = "Estado:";
            // 
            // txtExamen
            // 
            txtExamen.Location = new Point(372, 155);
            txtExamen.Name = "txtExamen";
            txtExamen.Size = new Size(154, 26);
            txtExamen.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(269, 158);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 17;
            label8.Text = "Examen";
            // 
            // txtCal3
            // 
            txtCal3.Location = new Point(372, 86);
            txtCal3.Name = "txtCal3";
            txtCal3.Size = new Size(154, 26);
            txtCal3.TabIndex = 16;
            // 
            // txtCal4
            // 
            txtCal4.Location = new Point(372, 121);
            txtCal4.Name = "txtCal4";
            txtCal4.Size = new Size(154, 26);
            txtCal4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 89);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 13;
            label6.Text = "Calificacion 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 124);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 14;
            label7.Text = "Calififcacion 4";
            // 
            // txtCal1
            // 
            txtCal1.Location = new Point(372, 19);
            txtCal1.Name = "txtCal1";
            txtCal1.Size = new Size(154, 26);
            txtCal1.TabIndex = 12;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.Location = new Point(251, 197);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(86, 31);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "Borrar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnEnviar
            // 
            BtnEnviar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEnviar.Location = new Point(138, 197);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(86, 31);
            BtnEnviar.TabIndex = 10;
            BtnEnviar.Text = "Guardar";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // txtCal2
            // 
            txtCal2.Location = new Point(372, 54);
            txtCal2.Name = "txtCal2";
            txtCal2.Size = new Size(154, 26);
            txtCal2.TabIndex = 9;
            // 
            // txtMateriaId
            // 
            txtMateriaId.Location = new Point(133, 140);
            txtMateriaId.Name = "txtMateriaId";
            txtMateriaId.Size = new Size(103, 26);
            txtMateriaId.TabIndex = 7;
            // 
            // txtIdEstudiante
            // 
            txtIdEstudiante.Location = new Point(133, 98);
            txtIdEstudiante.Name = "txtIdEstudiante";
            txtIdEstudiante.Size = new Size(103, 26);
            txtIdEstudiante.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(133, 54);
            txtID.Name = "txtID";
            txtID.Size = new Size(103, 26);
            txtID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 22);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Calificacion 1";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 54);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Calififcacion 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 54);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "ID de Calificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 101);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "ID de Estudiante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 143);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "ID de Materia";
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1022, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCalificaciones";
            Text = "FrmCalificaciones";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMostrarCalificaciones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnMostrarCalificaciones;
        private DataGridView DgvMostrarCalificaciones;
        private GroupBox groupBox2;
        private Button BtnLimpiar;
        private Button BtnEnviar;
        private TextBox txtCal2;
        private TextBox txtMateriaId;
        private TextBox txtIdEstudiante;
        private TextBox txtID;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCal1;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtExamen;
        private Label label8;
        private TextBox txtCal3;
        private TextBox txtCal4;
        private Label label6;
        private Label label7;
        private Label lblCalificacion;
        private Label lblClasificacion;
        private Label lblEstado;
    }
}