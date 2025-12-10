namespace Sistema_de_gestion_de_visado
{
    partial class Login
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
            linkRegistrar = new LinkLabel();
            linkOlvidaste = new LinkLabel();
            btnIngresar = new Button();
            label2 = new Label();
            txtcontraseña = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(linkRegistrar);
            groupBox1.Controls.Add(linkOlvidaste);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtcontraseña);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(263, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 385);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login de usuarios";
            // 
            // linkRegistrar
            // 
            linkRegistrar.ActiveLinkColor = Color.FromArgb(128, 128, 255);
            linkRegistrar.AutoSize = true;
            linkRegistrar.LinkColor = Color.Gray;
            linkRegistrar.Location = new Point(90, 279);
            linkRegistrar.Name = "linkRegistrar";
            linkRegistrar.Size = new Size(124, 22);
            linkRegistrar.TabIndex = 6;
            linkRegistrar.TabStop = true;
            linkRegistrar.Text = "Registrarse";
            linkRegistrar.VisitedLinkColor = Color.FromArgb(64, 64, 64);
            linkRegistrar.LinkClicked += linkRegistrar_LinkClicked;
            // 
            // linkOlvidaste
            // 
            linkOlvidaste.AutoSize = true;
            linkOlvidaste.LinkColor = Color.Gray;
            linkOlvidaste.Location = new Point(25, 315);
            linkOlvidaste.Name = "linkOlvidaste";
            linkOlvidaste.Size = new Size(274, 22);
            linkOlvidaste.TabIndex = 5;
            linkOlvidaste.TabStop = true;
            linkOlvidaste.Text = "¿Olvidaste la constraseña?";
            linkOlvidaste.VisitedLinkColor = Color.FromArgb(64, 64, 64);
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(90, 219);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(119, 39);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 125);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(25, 165);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(207, 30);
            txtcontraseña.TabIndex = 2;
            txtcontraseña.Text = "********";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(193, 22);
            label1.TabIndex = 1;
            label1.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(25, 79);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(207, 26);
            txtCorreo.TabIndex = 0;
            txtCorreo.Text = "correo@ejemplo.com";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.american_flag_sun1;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtCorreo;
        private LinkLabel linkOlvidaste;
        private Button btnIngresar;
        private Label label2;
        private TextBox txtcontraseña;
        private LinkLabel linkRegistrar;
    }
}