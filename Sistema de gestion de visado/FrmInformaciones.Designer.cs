namespace Sistema_de_gestion_de_visado
{
    partial class FrmInformaciones
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
            cbVisas = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cbVisas
            // 
            cbVisas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbVisas.FormattingEnabled = true;
            cbVisas.Items.AddRange(new object[] { "Visa de Turista (B1/B2, Schengen Tipo C)", "Visa de Estudiante (F-1, J-1)", "Visa de Trabajo Temporal (H-1B, H-2A)", "Visa de Inmigrante por Familia (IR, F-2A/B, F-3, F-4)", "Visa de Negocios (B1)", "Visa de Tránsito (C)", "Visa de Residente Permanente (Green Card)", "Visa de Inversionista (E-2, EB-5)", "Visa de Cónyuge/Prometido(a) (K-1)", "Visa Diplomática/Oficial (A, G)" });
            cbVisas.Location = new Point(241, 194);
            cbVisas.Name = "cbVisas";
            cbVisas.Size = new Size(278, 29);
            cbVisas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(64, 19);
            label1.Name = "label1";
            label1.Size = new Size(636, 154);
            label1.TabIndex = 1;
            label1.Text = "Explora la visa \r\nde tu conveniencia\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(253, 239);
            button1.Name = "button1";
            button1.Size = new Size(116, 50);
            button1.TabIndex = 2;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(392, 239);
            button2.Name = "button2";
            button2.Size = new Size(116, 50);
            button2.TabIndex = 3;
            button2.Text = "Solicitar";
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmInformaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = Properties.Resources.pasaportes_700x415;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(845, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cbVisas);
            Name = "FrmInformaciones";
            Text = "Informaciones generales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVisas;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}