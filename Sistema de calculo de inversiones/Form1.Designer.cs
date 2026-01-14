namespace Sistema_de_calculo_de_inversiones
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            LBLCAPITAL = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 21);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE GESTION DE INVERSIONES";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LBLCAPITAL);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(49, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 305);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "INTERES SIMPLE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 0;
            // 
            // LBLCAPITAL
            // 
            LBLCAPITAL.AutoSize = true;
            LBLCAPITAL.Location = new Point(29, 40);
            LBLCAPITAL.Name = "LBLCAPITAL";
            LBLCAPITAL.Size = new Size(72, 21);
            LBLCAPITAL.TabIndex = 1;
            LBLCAPITAL.Text = "CAPITAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Sistema de inversiones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label LBLCAPITAL;
        private TextBox textBox1;
    }
}
