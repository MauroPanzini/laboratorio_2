namespace Vistas
{
    partial class Form3
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
            tabPage2 = new TabPage();
            button17 = new Button();
            button16 = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.SetChildIndex(tabPage2, 0);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button17);
            tabPage2.Controls.Add(button16);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 409);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gestion";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(476, 135);
            button17.Name = "button17";
            button17.Size = new Size(275, 105);
            button17.TabIndex = 1;
            button17.Text = "Stock";
            button17.UseVisualStyleBackColor = true;
            button17.Click += GestionStock;
            // 
            // button16
            // 
            button16.Location = new Point(38, 135);
            button16.Name = "button16";
            button16.Size = new Size(275, 105);
            button16.TabIndex = 0;
            button16.Text = "Empleados";
            button16.UseVisualStyleBackColor = true;
            button16.Click += GestionEmpleados;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 504);
            Name = "Form3";
            Text = "Fabrica";
            Load += Form3_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private Button button17;
        private Button button16;
    }
}