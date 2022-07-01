namespace WindowsFormsApp10
{
    partial class GestionDeEventos
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.chkConfirmacionDeInicio = new System.Windows.Forms.CheckBox();
            this.chkConfirmacionDeFinal = new System.Windows.Forms.CheckBox();
            this.btnAgrgar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(186, 85);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(86, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(86, 199);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(72, 13);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora de inicio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(86, 147);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha De inicio";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(86, 92);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "Pais";
            // 
            // chkConfirmacionDeInicio
            // 
            this.chkConfirmacionDeInicio.AutoSize = true;
            this.chkConfirmacionDeInicio.Location = new System.Drawing.Point(186, 243);
            this.chkConfirmacionDeInicio.Name = "chkConfirmacionDeInicio";
            this.chkConfirmacionDeInicio.Size = new System.Drawing.Size(51, 17);
            this.chkConfirmacionDeInicio.TabIndex = 12;
            this.chkConfirmacionDeInicio.Text = "Inicio";
            this.chkConfirmacionDeInicio.UseVisualStyleBackColor = true;
            // 
            // chkConfirmacionDeFinal
            // 
            this.chkConfirmacionDeFinal.AutoSize = true;
            this.chkConfirmacionDeFinal.Location = new System.Drawing.Point(186, 295);
            this.chkConfirmacionDeFinal.Name = "chkConfirmacionDeFinal";
            this.chkConfirmacionDeFinal.Size = new System.Drawing.Size(48, 17);
            this.chkConfirmacionDeFinal.TabIndex = 13;
            this.chkConfirmacionDeFinal.Text = "Final";
            this.chkConfirmacionDeFinal.UseVisualStyleBackColor = true;
            this.chkConfirmacionDeFinal.CheckedChanged += new System.EventHandler(this.chkConfirmacionDeFinal_CheckedChanged);
            // 
            // btnAgrgar
            // 
            this.btnAgrgar.Location = new System.Drawing.Point(83, 354);
            this.btnAgrgar.Name = "btnAgrgar";
            this.btnAgrgar.Size = new System.Drawing.Size(75, 23);
            this.btnAgrgar.TabIndex = 14;
            this.btnAgrgar.Text = "Agregar";
            this.btnAgrgar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(321, 354);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(199, 354);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // GestionDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgrgar);
            this.Controls.Add(this.chkConfirmacionDeFinal);
            this.Controls.Add(this.chkConfirmacionDeInicio);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "GestionDeEventos";
            this.Text = "Gestion De Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.CheckBox chkConfirmacionDeInicio;
        private System.Windows.Forms.CheckBox chkConfirmacionDeFinal;
        private System.Windows.Forms.Button btnAgrgar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}