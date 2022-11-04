namespace A
{
    partial class Altafamilia
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
            this.button1 = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ocupacion = new System.Windows.Forms.Label();
            this.textParentesco = new System.Windows.Forms.TextBox();
            this.textOcupacion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(355, 382);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(53, 66);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parentesco";
            // 
            // ocupacion
            // 
            this.ocupacion.AutoSize = true;
            this.ocupacion.Location = new System.Drawing.Point(58, 322);
            this.ocupacion.Name = "ocupacion";
            this.ocupacion.Size = new System.Drawing.Size(59, 13);
            this.ocupacion.TabIndex = 5;
            this.ocupacion.Text = "Ocupacion";
            // 
            // textParentesco
            // 
            this.textParentesco.Location = new System.Drawing.Point(140, 230);
            this.textParentesco.Name = "textParentesco";
            this.textParentesco.Size = new System.Drawing.Size(100, 20);
            this.textParentesco.TabIndex = 6;
            // 
            // textOcupacion
            // 
            this.textOcupacion.Location = new System.Drawing.Point(140, 322);
            this.textOcupacion.Name = "textOcupacion";
            this.textOcupacion.Size = new System.Drawing.Size(100, 20);
            this.textOcupacion.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(140, 139);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // Altafamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.textOcupacion);
            this.Controls.Add(this.textParentesco);
            this.Controls.Add(this.ocupacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.button1);
            this.Name = "Altafamilia";
            this.Text = "Alta de familia";
            this.Load += new System.EventHandler(this.Altafamilia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ocupacion;
        private System.Windows.Forms.TextBox textParentesco;
        private System.Windows.Forms.TextBox textOcupacion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
    }
}