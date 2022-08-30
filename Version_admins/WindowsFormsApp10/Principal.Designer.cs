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
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.menuContenedor.SuspendLayout();
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
            this.menuGestionUsuarios.Name = "menuGestionUsuarios";
            resources.ApplyResources(this.menuGestionUsuarios, "menuGestionUsuarios");
            this.menuGestionUsuarios.Click += new System.EventHandler(this.menuGestionUsuarios_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            resources.ApplyResources(this.menuLogin, "menuLogin");
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuContenedor
            // 
            resources.ApplyResources(this.menuContenedor, "menuContenedor");
            this.menuContenedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEventos,
            this.menuGestionUsuarios,
            this.menuLogin});
            this.menuContenedor.Name = "menuContenedor";
            // 
            // menuEventos
            // 
            this.menuEventos.Name = "menuEventos";
            resources.ApplyResources(this.menuEventos, "menuEventos");
            this.menuEventos.Click += new System.EventHandler(this.menuEventos_Click);
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp10.Properties.Resources.pngtree_sports_motion_silhouette_sports_poster_image_14841;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbLogin;
        public System.Windows.Forms.ToolStripMenuItem menuGestionUsuarios;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.MenuStrip menuContenedor;
        public System.Windows.Forms.ToolStripMenuItem menuEventos;
    }
}

