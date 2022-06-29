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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.checkedListBoxNotificaciones.Location = new System.Drawing.Point(0, 2);
            this.checkedListBoxNotificaciones.Name = "checkedListBoxNotificaciones";
            this.checkedListBoxNotificaciones.Size = new System.Drawing.Size(530, 497);
            this.checkedListBoxNotificaciones.TabIndex = 0;
            this.checkedListBoxNotificaciones.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(374, 464);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxNotificaciones);
            this.Name = "Notificaciones";
            this.Text = "Elegitr notificaciones";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxNotificaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}