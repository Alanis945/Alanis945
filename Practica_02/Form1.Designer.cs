namespace Practica_02
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
            butcon1 = new Button();
            butcon2 = new Button();
            txtFahrenheit = new TextBox();
            txtCelsius = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblCelsius = new Label();
            lblFahrenheit = new Label();
            SuspendLayout();
            // 
            // butcon1
            // 
            butcon1.BackColor = Color.Blue;
            butcon1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butcon1.ForeColor = SystemColors.ControlText;
            butcon1.Location = new Point(67, 80);
            butcon1.Name = "butcon1";
            butcon1.Size = new Size(91, 23);
            butcon1.TabIndex = 0;
            butcon1.Text = "CONVERTIR";
            butcon1.TextImageRelation = TextImageRelation.TextAboveImage;
            butcon1.UseVisualStyleBackColor = false;
            butcon1.Click += butcon1_Click;
            // 
            // butcon2
            // 
            butcon2.BackColor = Color.Blue;
            butcon2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butcon2.Location = new Point(67, 141);
            butcon2.Name = "butcon2";
            butcon2.Size = new Size(91, 23);
            butcon2.TabIndex = 1;
            butcon2.Text = "CONVERTIR";
            butcon2.UseVisualStyleBackColor = false;
            butcon2.Click += button2_Click;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(12, 141);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(49, 23);
            txtFahrenheit.TabIndex = 2;
            txtFahrenheit.TextChanged += txtFahrenheit_TextChanged;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(12, 80);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(49, 23);
            txtCelsius.TabIndex = 3;
            txtCelsius.TextChanged += txtCelsius_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 4;
            label1.Text = "Ingrese Celsius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(123, 17);
            label2.TabIndex = 5;
            label2.Text = "Ingrese Fahrenheit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(320, 37);
            label3.TabIndex = 8;
            label3.Text = "CELSIUS A FAHRENHEIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 46);
            label4.Name = "label4";
            label4.Size = new Size(222, 17);
            label4.TabIndex = 9;
            label4.Text = "FORMULA:(Celsius x 9/5) + 32 = °F";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 106);
            label5.Name = "label5";
            label5.Size = new Size(242, 17);
            label5.TabIndex = 10;
            label5.Text = "FORMULA:(Fahrenheit - 32) x 5/9 = °C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(164, 61);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 11;
            label6.Text = "Resultado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(164, 123);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 12;
            label7.Text = "Resultado";
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCelsius.Location = new Point(164, 80);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(29, 17);
            lblCelsius.TabIndex = 13;
            lblCelsius.Text = "000";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFahrenheit.Location = new Point(167, 144);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(29, 17);
            lblFahrenheit.TabIndex = 14;
            lblFahrenheit.Text = "000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(339, 174);
            Controls.Add(lblFahrenheit);
            Controls.Add(lblCelsius);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCelsius);
            Controls.Add(txtFahrenheit);
            Controls.Add(butcon2);
            Controls.Add(butcon1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butcon1;
        private Button butcon2;
        private TextBox txtFahrenheit;
        private TextBox txtCelsius;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblCelsius;
        private Label lblFahrenheit;
    }
}
