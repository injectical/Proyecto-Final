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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txthoraInicio = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.chkConfirmacionDeInicio = new System.Windows.Forms.CheckBox();
            this.chkConfirmacionDeFinal = new System.Windows.Forms.CheckBox();
            this.btnAgrgar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(186, 30);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(186, 140);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // txthoraInicio
            // 
            this.txthoraInicio.Location = new System.Drawing.Point(186, 192);
            this.txthoraInicio.Name = "txthoraInicio";
            this.txthoraInicio.Size = new System.Drawing.Size(100, 20);
            this.txthoraInicio.TabIndex = 2;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(186, 85);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 5;
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
            this.chkConfirmacionDeInicio.Location = new System.Drawing.Point(199, 269);
            this.chkConfirmacionDeInicio.Name = "chkConfirmacionDeInicio";
            this.chkConfirmacionDeInicio.Size = new System.Drawing.Size(51, 17);
            this.chkConfirmacionDeInicio.TabIndex = 12;
            this.chkConfirmacionDeInicio.Text = "Inicio";
            this.chkConfirmacionDeInicio.UseVisualStyleBackColor = true;
            // 
            // chkConfirmacionDeFinal
            // 
            this.chkConfirmacionDeFinal.AutoSize = true;
            this.chkConfirmacionDeFinal.Location = new System.Drawing.Point(199, 321);
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
            this.btnAgrgar.Click += new System.EventHandler(this.btnAgrgar_Click);
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
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(186, 243);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 17;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(86, 250);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 18;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // GestionDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgrgar);
            this.Controls.Add(this.chkConfirmacionDeFinal);
            this.Controls.Add(this.chkConfirmacionDeInicio);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txthoraInicio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtnombre);
            this.Name = "GestionDeEventos";
            this.Text = "Gestion De Eventos";
            this.Load += new System.EventHandler(this.GestionDeEventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txthoraInicio;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.CheckBox chkConfirmacionDeInicio;
        private System.Windows.Forms.CheckBox chkConfirmacionDeFinal;
        private System.Windows.Forms.Button btnAgrgar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblresultado;
    }
}