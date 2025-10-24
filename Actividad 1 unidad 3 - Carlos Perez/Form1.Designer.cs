namespace Actividad_1_unidad_3___Carlos_Perez
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            BtnClientes = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(BtnClientes);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(58, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(644, 312);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "OPCIONES";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(376, 174);
            button4.Name = "button4";
            button4.Size = new Size(137, 54);
            button4.TabIndex = 3;
            button4.Text = "PRODUCTOS";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(376, 56);
            button3.Name = "button3";
            button3.Size = new Size(137, 54);
            button3.TabIndex = 2;
            button3.Text = "PROVEEDORES";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(67, 174);
            button2.Name = "button2";
            button2.Size = new Size(152, 54);
            button2.TabIndex = 1;
            button2.Text = "CATEGORIAS";
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            BtnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClientes.ForeColor = SystemColors.ActiveCaptionText;
            BtnClientes.Location = new Point(67, 56);
            BtnClientes.Name = "BtnClientes";
            BtnClientes.Size = new Size(152, 54);
            BtnClientes.TabIndex = 0;
            BtnClientes.Text = "CLIENTES";
            BtnClientes.UseVisualStyleBackColor = true;
            BtnClientes.Click += button1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Control;
            Name = "FrmPrincipal";
            Text = "MENU PRINCIPAL";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button BtnClientes;
    }
}
