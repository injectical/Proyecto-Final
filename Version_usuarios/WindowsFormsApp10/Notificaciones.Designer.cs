namespace WindowsFormsApp10
{
    partial class Notificaciones
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
            this.checkedListBoxNotificaciones = new System.Windows.Forms.CheckedListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clbNotificaciones = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxNotificaciones
            // 
            this.checkedListBoxNotificaciones.BackColor = System.Drawing.SystemColors.InfoText;
            this.checkedListBoxNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxNotificaciones.ForeColor = System.Drawing.Color.Red;
            this.checkedListBoxNotificaciones.FormattingEnabled = true;
            this.checkedListBoxNotificaciones.Items.AddRange(new object[] {
            "Futbol",
            "Basquet",
            "Tenis",
            "Rugby",
            "Handball",
            "Automovilismo",
            "MMA",
            "Futsal",
            "Boxeo",
            "Atletismo"});
            this.checkedListBoxNotificaciones.Location = new System.Drawing.Point(0, -3);
            this.checkedListBoxNotificaciones.MaximumSize = new System.Drawing.Size(4, 30);
            this.checkedListBoxNotificaciones.Name = "checkedListBoxNotificaciones";
            this.checkedListBoxNotificaciones.Size = new System.Drawing.Size(0, 4);
            this.checkedListBoxNotificaciones.TabIndex = 0;
            this.checkedListBoxNotificaciones.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(71, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(74, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // clbNotificaciones
            // 
            this.clbNotificaciones.BackColor = System.Drawing.SystemColors.InfoText;
            this.clbNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbNotificaciones.ForeColor = System.Drawing.Color.Red;
            this.clbNotificaciones.FormattingEnabled = true;
            this.clbNotificaciones.Items.AddRange(new object[] {
            "Futbol",
            "Basquet",
            "Tenis",
            "Rugby",
            "Handball",
            "Automovilismo",
            "MMA",
            "Futsal",
            "Boxeo",
            "Atletismo"});
            this.clbNotificaciones.Location = new System.Drawing.Point(-6, -2);
            this.clbNotificaciones.Name = "clbNotificaciones";
            this.clbNotificaciones.Size = new System.Drawing.Size(386, 468);
            this.clbNotificaciones.TabIndex = 3;
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(374, 464);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.checkedListBoxNotificaciones);
            this.Controls.Add(this.clbNotificaciones);
            this.Name = "Notificaciones";
            this.Text = "Elegitr notificaciones";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxNotificaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckedListBox clbNotificaciones;
    }
}