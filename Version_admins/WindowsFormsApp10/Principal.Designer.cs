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
            this.menuGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContenedor = new System.Windows.Forms.MenuStrip();
            this.menuEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripGestionDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.menuContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            resources.ApplyResources(this.pbLogin, "pbLogin");
            this.pbLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.TabStop = false;
            this.pbLogin.Tag = "";
            this.pbLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuGestionUsuarios
            // 
            resources.ApplyResources(this.menuGestionUsuarios, "menuGestionUsuarios");
            this.menuGestionUsuarios.Name = "menuGestionUsuarios";
            this.menuGestionUsuarios.Click += new System.EventHandler(this.menuGestionUsuarios_Click);
            // 
            // menuLogin
            // 
            resources.ApplyResources(this.menuLogin, "menuLogin");
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuContenedor
            // 
            resources.ApplyResources(this.menuContenedor, "menuContenedor");
            this.menuContenedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEventos,
            this.menuGestionUsuarios,
            this.menuLogin,
            this.menuStripGestionDetalles});
            this.menuContenedor.Name = "menuContenedor";
            // 
            // menuEventos
            // 
            resources.ApplyResources(this.menuEventos, "menuEventos");
            this.menuEventos.Name = "menuEventos";
            this.menuEventos.Click += new System.EventHandler(this.menuEventos_Click);
            // 
            // menuStripGestionDetalles
            // 
            this.menuStripGestionDetalles.Name = "menuStripGestionDetalles";
            resources.ApplyResources(this.menuStripGestionDetalles, "menuStripGestionDetalles");
            this.menuStripGestionDetalles.Click += new System.EventHandler(this.gestionDeDetallesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::WindowsFormsApp10.Properties.Resources.imagen;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.pngtree_sports_motion_silhouette_sports_poster_image_14841;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.menuContenedor);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuContenedor;
            this.Name = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.menuContenedor.ResumeLayout(false);
            this.menuContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbLogin;
        public System.Windows.Forms.ToolStripMenuItem menuGestionUsuarios;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.MenuStrip menuContenedor;
        public System.Windows.Forms.ToolStripMenuItem menuEventos;
        public System.Windows.Forms.ToolStripMenuItem menuStripGestionDetalles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

