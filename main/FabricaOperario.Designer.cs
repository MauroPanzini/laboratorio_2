namespace main
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            comboBox1 = new ComboBox();
            progressBar2 = new ProgressBar();
            button15 = new Button();
            progressBar3 = new ProgressBar();
            button14 = new Button();
            progressBar4 = new ProgressBar();
            button13 = new Button();
            progressBar5 = new ProgressBar();
            button12 = new Button();
            button1 = new Button();
            button11 = new Button();
            button2 = new Button();
            numericUpDown3 = new NumericUpDown();
            button3 = new Button();
            numericUpDown2 = new NumericUpDown();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            button5 = new Button();
            button10 = new Button();
            button6 = new Button();
            button9 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 58, 88);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 62);
            panel1.TabIndex = 27;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Azure;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(649, 24);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 1;
            label2.Text = "¡Hola {{usuario}}!";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(339, 24);
            label1.Name = "label1";
            label1.Size = new Size(146, 19);
            label1.TabIndex = 0;
            label1.Text = "Panel de supervisor";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 437);
            tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(240, 241, 246);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(progressBar2);
            tabPage1.Controls.Add(button15);
            tabPage1.Controls.Add(progressBar3);
            tabPage1.Controls.Add(button14);
            tabPage1.Controls.Add(progressBar4);
            tabPage1.Controls.Add(button13);
            tabPage1.Controls.Add(progressBar5);
            tabPage1.Controls.Add(button12);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button11);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(numericUpDown3);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button10);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button9);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button8);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Produccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(686, 202);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 26;
            label5.Text = "BAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(683, 48);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 25;
            label4.Text = "RPM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 121);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 24;
            label3.Text = "ºC";
            label3.Click += label3_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 26);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(385, 60);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.Items.AddRange(new object[] { "Transparente", "Ambar", "Verde" });
            comboBox1.Location = new Point(436, 121);
            comboBox1.MaxDropDownItems = 2;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(71, 23);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += ElegirColor;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(6, 102);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(385, 60);
            progressBar2.TabIndex = 1;
            // 
            // button15
            // 
            button15.Location = new Point(513, 339);
            button15.Name = "button15";
            button15.Size = new Size(146, 40);
            button15.TabIndex = 22;
            button15.Text = "Empaquetar";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Empaquetar;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(6, 178);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(385, 60);
            progressBar3.TabIndex = 2;
            // 
            // button14
            // 
            button14.Location = new Point(513, 264);
            button14.Name = "button14";
            button14.Size = new Size(146, 40);
            button14.TabIndex = 21;
            button14.Text = "Controlar Calidad";
            button14.UseVisualStyleBackColor = true;
            button14.Click += ControlCalidad;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(6, 254);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(385, 60);
            progressBar4.TabIndex = 3;
            // 
            // button13
            // 
            button13.Location = new Point(513, 189);
            button13.Name = "button13";
            button13.Size = new Size(146, 40);
            button13.TabIndex = 20;
            button13.Text = "Moldear";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Moldear;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(6, 330);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(385, 60);
            progressBar5.TabIndex = 4;
            // 
            // button12
            // 
            button12.Location = new Point(513, 110);
            button12.Name = "button12";
            button12.Size = new Size(146, 40);
            button12.TabIndex = 19;
            button12.Text = "Fundir";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Fundir;
            // 
            // button1
            // 
            button1.Location = new Point(397, 26);
            button1.Name = "button1";
            button1.Size = new Size(33, 26);
            button1.TabIndex = 5;
            button1.Text = "On";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EncenderMezcladora;
            // 
            // button11
            // 
            button11.Location = new Point(513, 35);
            button11.Name = "button11";
            button11.Size = new Size(146, 40);
            button11.TabIndex = 18;
            button11.Text = "Mezclar";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Mezclar;
            // 
            // button2
            // 
            button2.Location = new Point(397, 102);
            button2.Name = "button2";
            button2.Size = new Size(33, 26);
            button2.TabIndex = 6;
            button2.Text = "On";
            button2.UseVisualStyleBackColor = true;
            button2.Click += EncenderFundidora;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown3.Location = new Point(721, 200);
            numericUpDown3.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(58, 23);
            numericUpDown3.TabIndex = 17;
            numericUpDown3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown3.ValueChanged += ControlBares;
            // 
            // button3
            // 
            button3.Location = new Point(397, 178);
            button3.Name = "button3";
            button3.Size = new Size(33, 26);
            button3.TabIndex = 7;
            button3.Text = "On";
            button3.UseVisualStyleBackColor = true;
            button3.Click += EncenderInyectora;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown2.Location = new Point(721, 121);
            numericUpDown2.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(58, 23);
            numericUpDown2.TabIndex = 16;
            numericUpDown2.Value = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.ValueChanged += ControlTemperatura;
            // 
            // button4
            // 
            button4.Location = new Point(397, 254);
            button4.Name = "button4";
            button4.Size = new Size(33, 26);
            button4.TabIndex = 8;
            button4.Text = "On";
            button4.UseVisualStyleBackColor = true;
            button4.Click += EncenderControlCalidad;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Location = new Point(721, 45);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 23);
            numericUpDown1.TabIndex = 15;
            numericUpDown1.ValueChanged += ControlRpm;
            // 
            // button5
            // 
            button5.Location = new Point(397, 330);
            button5.Name = "button5";
            button5.Size = new Size(33, 26);
            button5.TabIndex = 9;
            button5.Text = "On";
            button5.UseVisualStyleBackColor = true;
            button5.Click += EncenderEmpaquetadora;
            // 
            // button10
            // 
            button10.Location = new Point(397, 364);
            button10.Name = "button10";
            button10.Size = new Size(33, 26);
            button10.TabIndex = 14;
            button10.Text = "Off";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ApagarEmpaquetadora;
            // 
            // button6
            // 
            button6.Location = new Point(397, 60);
            button6.Name = "button6";
            button6.Size = new Size(33, 26);
            button6.TabIndex = 10;
            button6.Text = "Off";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ApagarMezcladora;
            // 
            // button9
            // 
            button9.Location = new Point(397, 288);
            button9.Name = "button9";
            button9.Size = new Size(33, 26);
            button9.TabIndex = 13;
            button9.Text = "Off";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ApagarControlCalidad;
            // 
            // button7
            // 
            button7.Location = new Point(397, 136);
            button7.Name = "button7";
            button7.Size = new Size(33, 26);
            button7.TabIndex = 11;
            button7.Text = "Off";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ApagarFundidora;
            // 
            // button8
            // 
            button8.Location = new Point(397, 212);
            button8.Name = "button8";
            button8.Size = new Size(33, 26);
            button8.TabIndex = 12;
            button8.Text = "Off";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ApagarInyectora;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(797, 509);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TabPage tabPage1;
        private ProgressBar progressBar1;
        private ComboBox comboBox1;
        private ProgressBar progressBar2;
        private Button button15;
        private ProgressBar progressBar3;
        private Button button14;
        private ProgressBar progressBar4;
        private Button button13;
        private ProgressBar progressBar5;
        private Button button12;
        private Button button1;
        private Button button11;
        private Button button2;
        private NumericUpDown numericUpDown3;
        private Button button3;
        private NumericUpDown numericUpDown2;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private Button button5;
        private Button button10;
        private Button button6;
        private Button button9;
        private Button button7;
        private Button button8;
        public TabControl tabControl1;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}