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
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvMostrarMaterias).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(BtnMostrar);
            groupBox2.Controls.Add(DgvMostrarMaterias);
            groupBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(469, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 244);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registro de Materias";
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
            groupBox1.Size = new Size(416, 185);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Materia";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLimpiar.Location = new Point(256, 140);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(86, 31);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "LIMPIAR";
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnEnviar
            // 
            BtnEnviar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEnviar.Location = new Point(149, 140);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(86, 31);
            BtnEnviar.TabIndex = 10;
            BtnEnviar.Text = "ENVIAR";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(188, 108);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(154, 27);
            txtCreditos.TabIndex = 7;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(188, 66);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(192, 27);
            txtNombreMateria.TabIndex = 6;
            // 
            // txtIDMateria
            // 
            txtIDMateria.Location = new Point(188, 31);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.Size = new Size(170, 27);
            txtIDMateria.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "ID de Materia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            label2.Location = new Point(19, 69);
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
            label3.Location = new Point(17, 108);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 2;
            label3.Text = "Creditos de materia";
            // 
            // FrmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1021, 450);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FrmMateria";
            Text = "FrmMateria";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvMostrarMaterias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}