namespace PokeAlanis94
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtHabilidad01 = new System.Windows.Forms.TextBox();
            this.txtHabilidad02 = new System.Windows.Forms.TextBox();
            this.txtHabilidadOculta = new System.Windows.Forms.TextBox();
            this.txtTipo01 = new System.Windows.Forms.TextBox();
            this.txtTipo02 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHabilidad01 = new System.Windows.Forms.Label();
            this.lblHabilidad02 = new System.Windows.Forms.Label();
            this.lblHabilidadOculta = new System.Windows.Forms.Label();
            this.lblTipo01 = new System.Windows.Forms.Label();
            this.lblTipo02 = new System.Windows.Forms.Label();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(112, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtHabilidad01
            // 
            this.txtHabilidad01.Location = new System.Drawing.Point(113, 90);
            this.txtHabilidad01.Name = "txtHabilidad01";
            this.txtHabilidad01.Size = new System.Drawing.Size(218, 20);
            this.txtHabilidad01.TabIndex = 2;
            // 
            // txtHabilidad02
            // 
            this.txtHabilidad02.Location = new System.Drawing.Point(113, 64);
            this.txtHabilidad02.Name = "txtHabilidad02";
            this.txtHabilidad02.Size = new System.Drawing.Size(218, 20);
            this.txtHabilidad02.TabIndex = 3;
            this.txtHabilidad02.TextChanged += new System.EventHandler(this.txtHabilidad02_TextChanged);
            // 
            // txtHabilidadOculta
            // 
            this.txtHabilidadOculta.Location = new System.Drawing.Point(144, 116);
            this.txtHabilidadOculta.Name = "txtHabilidadOculta";
            this.txtHabilidadOculta.Size = new System.Drawing.Size(187, 20);
            this.txtHabilidadOculta.TabIndex = 4;
            // 
            // txtTipo01
            // 
            this.txtTipo01.Location = new System.Drawing.Point(73, 142);
            this.txtTipo01.Name = "txtTipo01";
            this.txtTipo01.Size = new System.Drawing.Size(258, 20);
            this.txtTipo01.TabIndex = 5;
            // 
            // txtTipo02
            // 
            this.txtTipo02.Location = new System.Drawing.Point(73, 168);
            this.txtTipo02.Name = "txtTipo02";
            this.txtTipo02.Size = new System.Drawing.Size(258, 20);
            this.txtTipo02.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(3, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(103, 20);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblHabilidad01
            // 
            this.lblHabilidad01.AutoSize = true;
            this.lblHabilidad01.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilidad01.Location = new System.Drawing.Point(3, 64);
            this.lblHabilidad01.Name = "lblHabilidad01";
            this.lblHabilidad01.Size = new System.Drawing.Size(104, 20);
            this.lblHabilidad01.TabIndex = 9;
            this.lblHabilidad01.Text = "Habilidad01";
            // 
            // lblHabilidad02
            // 
            this.lblHabilidad02.AutoSize = true;
            this.lblHabilidad02.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilidad02.Location = new System.Drawing.Point(3, 90);
            this.lblHabilidad02.Name = "lblHabilidad02";
            this.lblHabilidad02.Size = new System.Drawing.Size(104, 20);
            this.lblHabilidad02.TabIndex = 10;
            this.lblHabilidad02.Text = "Habilidad02";
            // 
            // lblHabilidadOculta
            // 
            this.lblHabilidadOculta.AutoSize = true;
            this.lblHabilidadOculta.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilidadOculta.Location = new System.Drawing.Point(3, 116);
            this.lblHabilidadOculta.Name = "lblHabilidadOculta";
            this.lblHabilidadOculta.Size = new System.Drawing.Size(135, 20);
            this.lblHabilidadOculta.TabIndex = 12;
            this.lblHabilidadOculta.Text = "HabilidadOculta";
            // 
            // lblTipo01
            // 
            this.lblTipo01.AutoSize = true;
            this.lblTipo01.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo01.Location = new System.Drawing.Point(3, 142);
            this.lblTipo01.Name = "lblTipo01";
            this.lblTipo01.Size = new System.Drawing.Size(64, 20);
            this.lblTipo01.TabIndex = 13;
            this.lblTipo01.Text = "Tipo01";
            // 
            // lblTipo02
            // 
            this.lblTipo02.AutoSize = true;
            this.lblTipo02.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo02.Location = new System.Drawing.Point(3, 168);
            this.lblTipo02.Name = "lblTipo02";
            this.lblTipo02.Size = new System.Drawing.Size(64, 20);
            this.lblTipo02.TabIndex = 14;
            this.lblTipo02.Text = "Tipo02";
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevo.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarNuevo.Image")));
            this.btnAgregarNuevo.Location = new System.Drawing.Point(7, 195);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(324, 30);
            this.btnAgregarNuevo.TabIndex = 19;
            this.btnAgregarNuevo.Text = "Agregar Nuevo";
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 242);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.lblTipo02);
            this.Controls.Add(this.lblTipo01);
            this.Controls.Add(this.lblHabilidadOculta);
            this.Controls.Add(this.lblHabilidad02);
            this.Controls.Add(this.lblHabilidad01);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtTipo02);
            this.Controls.Add(this.txtTipo01);
            this.Controls.Add(this.txtHabilidadOculta);
            this.Controls.Add(this.txtHabilidad02);
            this.Controls.Add(this.txtHabilidad01);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form2";
            this.Text = "AddPokemonForm.cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHabilidad01;
        private System.Windows.Forms.TextBox txtHabilidad02;
        private System.Windows.Forms.TextBox txtHabilidadOculta;
        private System.Windows.Forms.TextBox txtTipo01;
        private System.Windows.Forms.TextBox txtTipo02;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHabilidad01;
        private System.Windows.Forms.Label lblHabilidad02;
        private System.Windows.Forms.Label lblHabilidadOculta;
        private System.Windows.Forms.Label lblTipo01;
        private System.Windows.Forms.Label lblTipo02;
        private System.Windows.Forms.Button btnAgregarNuevo;
    }
}