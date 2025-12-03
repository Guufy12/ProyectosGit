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
            groupBox3 = new GroupBox();
            lblTotalAct = new Label();
            lblClasifAct = new Label();
            lblEstadoAct = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtExamAct = new TextBox();
            label18 = new Label();
            txtcal3Act = new TextBox();
            txtCal4Act = new TextBox();
            label19 = new Label();
            label20 = new Label();
            txtCal1Act = new TextBox();
            button1 = new Button();
            button2 = new Button();
            txtCal2Act = new TextBox();
            txtMateriaAct = new TextBox();
            txtEstuAct = new TextBox();
            txtIdAct = new TextBox();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            groupBox4 = new GroupBox();
            lblEstudianteEliminado = new Label();
            label14 = new Label();
            BtnEliminar = new Button();
            txtIDEliminar = new TextBox();
            label13 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMostrarCalificaciones).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(BtnMostrarCalificaciones);
            groupBox1.Controls.Add(DgvMostrarCalificaciones);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1322, 185);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "LISTADO DE CALIFICACIONES";
            // 
            // BtnMostrarCalificaciones
            // 
            BtnMostrarCalificaciones.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnMostrarCalificaciones.Location = new Point(1200, 48);
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
            DgvMostrarCalificaciones.Size = new Size(1176, 151);
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
            groupBox2.Size = new Size(890, 235);
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
            lblCalificacion.Click += lblCalificacion_Click;
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
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblTotalAct);
            groupBox3.Controls.Add(lblClasifAct);
            groupBox3.Controls.Add(lblEstadoAct);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtExamAct);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(txtcal3Act);
            groupBox3.Controls.Add(txtCal4Act);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(txtCal1Act);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(txtCal2Act);
            groupBox3.Controls.Add(txtMateriaAct);
            groupBox3.Controls.Add(txtEstuAct);
            groupBox3.Controls.Add(txtIdAct);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label25);
            groupBox3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 444);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(890, 235);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar Calificaciones";
            // 
            // lblTotalAct
            // 
            lblTotalAct.AutoSize = true;
            lblTotalAct.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTotalAct.Location = new Point(794, 49);
            lblTotalAct.Name = "lblTotalAct";
            lblTotalAct.Size = new Size(18, 19);
            lblTotalAct.TabIndex = 22;
            lblTotalAct.Text = "0";
            // 
            // lblClasifAct
            // 
            lblClasifAct.AutoSize = true;
            lblClasifAct.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblClasifAct.Location = new Point(794, 90);
            lblClasifAct.Name = "lblClasifAct";
            lblClasifAct.Size = new Size(86, 19);
            lblClasifAct.TabIndex = 23;
            lblClasifAct.Text = "Pendiente";
            // 
            // lblEstadoAct
            // 
            lblEstadoAct.AutoSize = true;
            lblEstadoAct.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblEstadoAct.Location = new Point(794, 131);
            lblEstadoAct.Name = "lblEstadoAct";
            lblEstadoAct.Size = new Size(86, 19);
            lblEstadoAct.TabIndex = 24;
            lblEstadoAct.Text = "Pendiente";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Narrow", 14.25F);
            label15.Location = new Point(570, 45);
            label15.Name = "label15";
            label15.Size = new Size(148, 23);
            label15.TabIndex = 19;
            label15.Text = "Total de calificacion:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Narrow", 14.25F);
            label16.Location = new Point(570, 86);
            label16.Name = "label16";
            label16.Size = new Size(200, 23);
            label16.TabIndex = 20;
            label16.Text = "Clasificacion del estudiante:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 14.25F);
            label17.Location = new Point(570, 127);
            label17.Name = "label17";
            label17.Size = new Size(62, 23);
            label17.TabIndex = 21;
            label17.Text = "Estado:";
            // 
            // txtExamAct
            // 
            txtExamAct.Location = new Point(372, 155);
            txtExamAct.Name = "txtExamAct";
            txtExamAct.Size = new Size(154, 26);
            txtExamAct.TabIndex = 18;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(269, 158);
            label18.Name = "label18";
            label18.Size = new Size(58, 20);
            label18.TabIndex = 17;
            label18.Text = "Examen";
            // 
            // txtcal3Act
            // 
            txtcal3Act.Location = new Point(372, 86);
            txtcal3Act.Name = "txtcal3Act";
            txtcal3Act.Size = new Size(154, 26);
            txtcal3Act.TabIndex = 16;
            // 
            // txtCal4Act
            // 
            txtCal4Act.Location = new Point(372, 121);
            txtCal4Act.Name = "txtCal4Act";
            txtCal4Act.Size = new Size(154, 26);
            txtCal4Act.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(269, 89);
            label19.Name = "label19";
            label19.Size = new Size(87, 20);
            label19.TabIndex = 13;
            label19.Text = "Calificacion 3";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(269, 124);
            label20.Name = "label20";
            label20.Size = new Size(90, 20);
            label20.TabIndex = 14;
            label20.Text = "Calififcacion 4";
            // 
            // txtCal1Act
            // 
            txtCal1Act.Location = new Point(372, 19);
            txtCal1Act.Name = "txtCal1Act";
            txtCal1Act.Size = new Size(154, 26);
            txtCal1Act.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(251, 197);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 11;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(123, 197);
            button2.Name = "button2";
            button2.Size = new Size(101, 31);
            button2.TabIndex = 10;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCal2Act
            // 
            txtCal2Act.Location = new Point(372, 54);
            txtCal2Act.Name = "txtCal2Act";
            txtCal2Act.Size = new Size(154, 26);
            txtCal2Act.TabIndex = 9;
            // 
            // txtMateriaAct
            // 
            txtMateriaAct.Location = new Point(133, 140);
            txtMateriaAct.Name = "txtMateriaAct";
            txtMateriaAct.Size = new Size(103, 26);
            txtMateriaAct.TabIndex = 7;
            // 
            // txtEstuAct
            // 
            txtEstuAct.Location = new Point(133, 98);
            txtEstuAct.Name = "txtEstuAct";
            txtEstuAct.Size = new Size(103, 26);
            txtEstuAct.TabIndex = 6;
            // 
            // txtIdAct
            // 
            txtIdAct.Location = new Point(133, 54);
            txtIdAct.Name = "txtIdAct";
            txtIdAct.Size = new Size(103, 26);
            txtIdAct.TabIndex = 5;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(269, 22);
            label21.Name = "label21";
            label21.Size = new Size(87, 20);
            label21.TabIndex = 3;
            label21.Text = "Calificacion 1";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(269, 54);
            label22.Name = "label22";
            label22.Size = new Size(90, 20);
            label22.TabIndex = 4;
            label22.Text = "Calififcacion 2";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(21, 54);
            label23.Name = "label23";
            label23.Size = new Size(112, 20);
            label23.TabIndex = 0;
            label23.Text = "ID de Calificacion";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(20, 101);
            label24.Name = "label24";
            label24.Size = new Size(107, 20);
            label24.TabIndex = 1;
            label24.Text = "ID de Estudiante";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(23, 143);
            label25.Name = "label25";
            label25.Size = new Size(88, 20);
            label25.TabIndex = 2;
            label25.Text = "ID de Materia";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(lblEstudianteEliminado);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(BtnEliminar);
            groupBox4.Controls.Add(txtIDEliminar);
            groupBox4.Controls.Add(label13);
            groupBox4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(908, 205);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(320, 474);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Eliminar calificacion";
            // 
            // lblEstudianteEliminado
            // 
            lblEstudianteEliminado.AutoSize = true;
            lblEstudianteEliminado.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblEstudianteEliminado.Location = new Point(57, 258);
            lblEstudianteEliminado.Name = "lblEstudianteEliminado";
            lblEstudianteEliminado.Size = new Size(34, 19);
            lblEstudianteEliminado.TabIndex = 24;
            lblEstudianteEliminado.Text = "N/a";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 14.25F);
            label14.Location = new Point(53, 203);
            label14.Name = "label14";
            label14.Size = new Size(160, 23);
            label14.TabIndex = 23;
            label14.Text = "Calificacion Eliminada";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEliminar.Location = new Point(57, 136);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(86, 31);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // txtIDEliminar
            // 
            txtIDEliminar.Location = new Point(57, 95);
            txtIDEliminar.Name = "txtIDEliminar";
            txtIDEliminar.Size = new Size(170, 29);
            txtIDEliminar.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(57, 50);
            label13.Name = "label13";
            label13.Size = new Size(80, 23);
            label13.TabIndex = 0;
            label13.Text = "Ingrese ID";
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1200, 112);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 12;
            button3.Text = "Exportar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1346, 749);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCalificaciones";
            Text = "FrmCalificaciones";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMostrarCalificaciones).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private TextBox txtExamen;
        private Label label8;
        private TextBox txtCal3;
        private TextBox txtCal4;
        private Label label6;
        private Label label7;
        private Label lblCalificacion;
        private Label lblClasificacion;
        private Label lblEstado;
        private Label label11;
        private GroupBox groupBox3;
        private Label lblTotalAct;
        private Label lblClasifAct;
        private Label lblEstadoAct;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtExamAct;
        private Label label18;
        private TextBox txtcal3Act;
        private TextBox txtCal4Act;
        private Label label19;
        private Label label20;
        private TextBox txtCal1Act;
        private Button button1;
        private Button button2;
        private TextBox txtCal2Act;
        private TextBox txtMateriaAct;
        private TextBox txtEstuAct;
        private TextBox txtIdAct;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private GroupBox groupBox4;
        private Button BtnEliminar;
        private TextBox txtIDEliminar;
        private Label label13;
        private Label lblEstudianteEliminado;
        private Label label14;
        private Button button3;
    }
}