namespace T2___Practicando_con_formularios
{
    partial class Form7
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
            barrita = new ProgressBar();
            BtnIniciar = new Button();
            BtnDetener = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // barrita
            // 
            barrita.Location = new Point(39, 50);
            barrita.Name = "barrita";
            barrita.Size = new Size(346, 23);
            barrita.TabIndex = 0;
            // 
            // BtnIniciar
            // 
            BtnIniciar.Location = new Point(50, 120);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(89, 33);
            BtnIniciar.TabIndex = 1;
            BtnIniciar.Text = "INICIAR";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // BtnDetener
            // 
            BtnDetener.Location = new Point(264, 120);
            BtnDetener.Name = "BtnDetener";
            BtnDetener.Size = new Size(83, 33);
            BtnDetener.TabIndex = 2;
            BtnDetener.Text = "DETENER";
            BtnDetener.UseVisualStyleBackColor = true;
            BtnDetener.Click += BtnDetener_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 20);
            label1.Name = "label1";
            label1.Size = new Size(199, 23);
            label1.TabIndex = 3;
            label1.Text = "PROGRESO DE LA BARRA";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtnDetener);
            Controls.Add(BtnIniciar);
            Controls.Add(barrita);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar barrita;
        private Button BtnIniciar;
        private Button BtnDetener;
        private Label label1;
    }
}