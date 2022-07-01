namespace WindowsFormsApp10
{
    partial class Perfil
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMiembro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(200, 89);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(200, 186);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 24);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(200, 389);
            this.lblPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(133, 24);
            this.lblPago.TabIndex = 2;
            this.lblPago.Text = "Miembro pago";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(200, 283);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(374, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 28);
            this.txtNombre.TabIndex = 4;
            // 
            // txtMiembro
            // 
            this.txtMiembro.Location = new System.Drawing.Point(374, 382);
            this.txtMiembro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMiembro.Name = "txtMiembro";
            this.txtMiembro.Size = new System.Drawing.Size(222, 28);
            this.txtMiembro.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(374, 276);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 28);
            this.txtEmail.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(374, 179);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(222, 28);
            this.txtApellido.TabIndex = 7;
            // 
            // btnAplicar
            // 
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAplicar.Location = new System.Drawing.Point(323, 500);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(105, 33);
            this.btnAplicar.TabIndex = 8;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // btnDescartar
            // 
            this.btnDescartar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDescartar.Location = new System.Drawing.Point(530, 499);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(116, 33);
            this.btnDescartar.TabIndex = 9;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMiembro);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Perfil";
            this.Text = "Ver/Modificar perfil";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnDescartar;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtMiembro;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtApellido;
    }
}