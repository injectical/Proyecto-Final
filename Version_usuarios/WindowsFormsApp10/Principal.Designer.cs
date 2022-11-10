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
            this.menuContenedor = new System.Windows.Forms.MenuStrip();
            this.menuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMembresíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNotificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEventos = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.menuContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            this.pbLogin.AccessibleDescription = "";
            this.pbLogin.AccessibleName = "";
            this.pbLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(766, 5);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(39, 40);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            this.pbLogin.Tag = "";
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            // 
            // menuContenedor
            // 
            this.menuContenedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestion,
            this.menuLogout,
            this.MenuIdioma});
            this.menuContenedor.Location = new System.Drawing.Point(0, 0);
            this.menuContenedor.Name = "menuContenedor";
            this.menuContenedor.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuContenedor.Size = new System.Drawing.Size(866, 45);
            this.menuContenedor.TabIndex = 4;
            this.menuContenedor.Text = "menuStrip1";
            // 
            // menuGestion
            // 
            this.menuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPerfilToolStripMenuItem,
            this.verMembresíaToolStripMenuItem});
            this.menuGestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGestion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuGestion.Name = "menuGestion";
            this.menuGestion.Size = new System.Drawing.Size(251, 41);
            this.menuGestion.Text = "Gestion de usuario";
            this.menuGestion.Click += new System.EventHandler(this.menuGestion_Click);
            // 
            // modificarPerfilToolStripMenuItem
            // 
            this.modificarPerfilToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.modificarPerfilToolStripMenuItem.Name = "modificarPerfilToolStripMenuItem";
            this.modificarPerfilToolStripMenuItem.Size = new System.Drawing.Size(275, 42);
            this.modificarPerfilToolStripMenuItem.Text = "Modificar perfil";
            this.modificarPerfilToolStripMenuItem.Click += new System.EventHandler(this.modificarPerfilToolStripMenuItem_Click);
            // 
            // verMembresíaToolStripMenuItem
            // 
            this.verMembresíaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNotificaciones,
            this.verPagisToolStripMenuItem});
            this.verMembresíaToolStripMenuItem.Name = "verMembresíaToolStripMenuItem";
            this.verMembresíaToolStripMenuItem.Size = new System.Drawing.Size(275, 42);
            this.verMembresíaToolStripMenuItem.Text = "Ver membresía";
            this.verMembresíaToolStripMenuItem.Visible = false;
            // 
            // menuNotificaciones
            // 
            this.menuNotificaciones.Name = "menuNotificaciones";
            this.menuNotificaciones.Size = new System.Drawing.Size(262, 42);
            this.menuNotificaciones.Text = "Notificaciones";
            this.menuNotificaciones.Click += new System.EventHandler(this.menuNotificaciones_Click_1);
            // 
            // verPagisToolStripMenuItem
            // 
            this.verPagisToolStripMenuItem.Name = "verPagisToolStripMenuItem";
            this.verPagisToolStripMenuItem.Size = new System.Drawing.Size(262, 42);
            this.verPagisToolStripMenuItem.Text = "Ver pagos";
            this.verPagisToolStripMenuItem.Click += new System.EventHandler(this.verPagisToolStripMenuItem_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(114, 41);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // MenuIdioma
            // 
            this.MenuIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEs,
            this.MenuIn});
            this.MenuIdioma.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuIdioma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MenuIdioma.Name = "MenuIdioma";
            this.MenuIdioma.Size = new System.Drawing.Size(112, 41);
            this.MenuIdioma.Text = "Idioma";
            // 
            // MenuEs
            // 
            this.MenuEs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MenuEs.Name = "MenuEs";
            this.MenuEs.Size = new System.Drawing.Size(180, 42);
            this.MenuEs.Text = "Es";
            this.MenuEs.Click += new System.EventHandler(this.espaToolStripMenuItem_Click);
            // 
            // MenuIn
            // 
            this.MenuIn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MenuIn.Name = "MenuIn";
            this.MenuIn.Size = new System.Drawing.Size(180, 42);
            this.MenuIn.Text = "In";
            this.MenuIn.Click += new System.EventHandler(this.MenuIn_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEventos.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.btnEventos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEventos.Location = new System.Drawing.Point(581, 5);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(150, 33);
            this.btnEventos.TabIndex = 14;
            this.btnEventos.Text = "IR A EVENTOS";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(24, 38);
            this.lblSaludo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(0, 18);
            this.lblSaludo.TabIndex = 16;
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Location = new System.Drawing.Point(514, 164);
            this.lblInicioSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(113, 16);
            this.lblInicioSesion.TabIndex = 5;
            this.lblInicioSesion.Text = "Iniciar Sesion";
            this.lblInicioSesion.Visible = false;
            this.lblInicioSesion.Click += new System.EventHandler(this.lblInicioSesion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 409);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.menuContenedor);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuContenedor;
            this.Name = "Principal";
            this.Text = "Principal Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.menuContenedor.ResumeLayout(false);
            this.menuContenedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuContenedor;
        public System.Windows.Forms.ToolStripMenuItem menuLogout;
        public System.Windows.Forms.PictureBox pbLogin;
        public System.Windows.Forms.ToolStripMenuItem menuGestion;
        private System.Windows.Forms.ToolStripMenuItem verMembresíaToolStripMenuItem;
        public System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.ToolStripMenuItem menuNotificaciones;
        private System.Windows.Forms.ToolStripMenuItem verPagisToolStripMenuItem;
        public System.Windows.Forms.Label lblSaludo;
        public System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.ToolStripMenuItem MenuEs;
        private System.Windows.Forms.ToolStripMenuItem MenuIn;
        public System.Windows.Forms.ToolStripMenuItem modificarPerfilToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuIdioma;
    }
}

