namespace main
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button2 = new Button();
            button3 = new Button();
            lblTitulo = new Label();
            lblIniciarComo = new Label();
            lblLegajo = new Label();
            lblClave = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatAppearance.BorderColor = Color.FromArgb(145, 182, 222);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 172, 217);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(135, 258);
            button1.Name = "button1";
            button1.Size = new Size(177, 27);
            button1.TabIndex = 2;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += IniciarSesion;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.GradientInactiveCaption;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(193, 159);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(119, 25);
            txtUserName.TabIndex = 0;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.GradientInactiveCaption;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(193, 210);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(119, 25);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.FlatAppearance.BorderColor = Color.FromArgb(164, 184, 204);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(135, 358);
            button2.Name = "button2";
            button2.Size = new Size(77, 43);
            button2.TabIndex = 3;
            button2.Text = "Supervisor";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AutocompletarSupervisor;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveCaption;
            button3.FlatAppearance.BorderColor = Color.FromArgb(164, 184, 204);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(235, 358);
            button3.Name = "button3";
            button3.Size = new Size(77, 43);
            button3.TabIndex = 4;
            button3.Text = "Operario";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AutocompletarOperario;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft JhengHei", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Azure;
            lblTitulo.Location = new Point(135, 102);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(177, 34);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Iniciar sesión";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += lblIniciarSesion_Click;
            // 
            // lblIniciarComo
            // 
            lblIniciarComo.AutoSize = true;
            lblIniciarComo.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIniciarComo.ForeColor = Color.Azure;
            lblIniciarComo.Location = new Point(168, 310);
            lblIniciarComo.Name = "lblIniciarComo";
            lblIniciarComo.Size = new Size(110, 19);
            lblIniciarComo.TabIndex = 6;
            lblIniciarComo.Text = "O iniciar como";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.ForeColor = Color.Azure;
            lblLegajo.Location = new Point(135, 164);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 7;
            lblLegajo.Text = "Legajo";
            lblLegajo.Click += lblLegajo_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.ForeColor = Color.Azure;
            lblClave.Location = new Point(135, 215);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(36, 15);
            lblClave.TabIndex = 7;
            lblClave.Text = "Clave";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(36, 58, 88);
            ClientSize = new Size(450, 436);
            Controls.Add(pictureBox1);
            Controls.Add(lblClave);
            Controls.Add(lblLegajo);
            Controls.Add(lblIniciarComo);
            Controls.Add(lblTitulo);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button2;
        private Button button3;
        private Label lblTitulo;
        private Label lblIniciarComo;
        private Label lblLegajo;
        private Label lblClave;
        private PictureBox pictureBox1;
    }
}