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
            this.lstNotificaciones = new System.Windows.Forms.ListBox();
            this.lblNotificaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstNotificaciones
            // 
            this.lstNotificaciones.BackColor = System.Drawing.Color.LightBlue;
            this.lstNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNotificaciones.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lstNotificaciones.FormattingEnabled = true;
            this.lstNotificaciones.HorizontalScrollbar = true;
            this.lstNotificaciones.ItemHeight = 16;
            this.lstNotificaciones.Location = new System.Drawing.Point(21, 79);
            this.lstNotificaciones.Name = "lstNotificaciones";
            this.lstNotificaciones.Size = new System.Drawing.Size(359, 130);
            this.lstNotificaciones.TabIndex = 0;
            // 
            // lblNotificaciones
            // 
            this.lblNotificaciones.AutoSize = true;
            this.lblNotificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificaciones.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNotificaciones.Location = new System.Drawing.Point(18, 32);
            this.lblNotificaciones.Name = "lblNotificaciones";
            this.lblNotificaciones.Size = new System.Drawing.Size(227, 18);
            this.lblNotificaciones.TabIndex = 1;
            this.lblNotificaciones.Text = "Recordatorio de tus eventos:";
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(392, 232);
            this.Controls.Add(this.lblNotificaciones);
            this.Controls.Add(this.lstNotificaciones);
            this.Name = "Notificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.Notificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstNotificaciones;
        private System.Windows.Forms.Label lblNotificaciones;
    }
}