namespace WindowsFormsApp10
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContenedor = new System.Windows.Forms.MenuStrip();
            this.menuEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lnkEventos = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.menuContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            this.pbLogin.AccessibleDescription = "";
            this.pbLogin.AccessibleName = "";
            this.pbLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(494, 32);
            this.pbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(43, 41);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            this.pbLogin.Tag = "";
            this.pbLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(865, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iniciar Sesion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuGestionUsuarios
            // 
            this.menuGestionUsuarios.Name = "menuGestionUsuarios";
            this.menuGestionUsuarios.Size = new System.Drawing.Size(150, 24);
            this.menuGestionUsuarios.Text = "Gestion de usuarios";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(68, 24);
            this.menuLogin.Text = "Logout";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuContenedor
            // 
            this.menuContenedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEventos,
            this.menuGestionUsuarios,
            this.menuLogin});
            this.menuContenedor.Location = new System.Drawing.Point(0, 0);
            this.menuContenedor.Name = "menuContenedor";
            this.menuContenedor.Size = new System.Drawing.Size(1067, 28);
            this.menuContenedor.TabIndex = 4;
            this.menuContenedor.Text = "menuStrip1";
            // 
            // menuEventos
            // 
            this.menuEventos.Name = "menuEventos";
            this.menuEventos.Size = new System.Drawing.Size(72, 24);
            this.menuEventos.Text = "Eventos";
            // 
            // lnkEventos
            // 
            this.lnkEventos.AutoSize = true;
            this.lnkEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEventos.Image = ((System.Drawing.Image)(resources.GetObject("lnkEventos.Image")));
            this.lnkEventos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEventos.LinkColor = System.Drawing.Color.White;
            this.lnkEventos.Location = new System.Drawing.Point(27, 156);
            this.lnkEventos.MinimumSize = new System.Drawing.Size(1000, 250);
            this.lnkEventos.Name = "lnkEventos";
            this.lnkEventos.Padding = new System.Windows.Forms.Padding(400, 0, 0, 0);
            this.lnkEventos.Size = new System.Drawing.Size(1000, 250);
            this.lnkEventos.TabIndex = 6;
            this.lnkEventos.TabStop = true;
            this.lnkEventos.Text = "Ir a eventos";
            this.lnkEventos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEventos_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(474, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Iniciar Sesion";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkEventos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.menuContenedor);
            this.MainMenuStrip = this.menuContenedor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Principal Backoffice";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.menuContenedor.ResumeLayout(false);
            this.menuContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbLogin;
        public System.Windows.Forms.ToolStripMenuItem menuGestionUsuarios;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.MenuStrip menuContenedor;
        public System.Windows.Forms.ToolStripMenuItem menuEventos;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.LinkLabel lnkEventos;
    }
}

