namespace T2___Practicando_con_formularios
{
    partial class Form4
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
            Universidades = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // Universidades
            // 
            Universidades.FormattingEnabled = true;
            Universidades.ItemHeight = 15;
            Universidades.Location = new Point(293, 44);
            Universidades.Name = "Universidades";
            Universidades.Size = new Size(120, 94);
            Universidades.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(81, 97);
            button1.Name = "button1";
            button1.Size = new Size(87, 41);
            button1.TabIndex = 2;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 21);
            label1.TabIndex = 3;
            label1.Text = "AGREGA LA UNIVERSIDAD";
            // 
            // button2
            // 
            button2.Location = new Point(305, 179);
            button2.Name = "button2";
            button2.Size = new Size(87, 41);
            button2.TabIndex = 4;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(522, 123);
            button3.Name = "button3";
            button3.Size = new Size(92, 55);
            button3.TabIndex = 5;
            button3.Text = "CLICKEA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(522, 80);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 6;
            label2.Text = "CONTADOR";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Universidades);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Universidades;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}