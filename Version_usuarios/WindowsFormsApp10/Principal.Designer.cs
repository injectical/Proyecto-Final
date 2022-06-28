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
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.btnEventos = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.pbLogin.Location = new System.Drawing.Point(816, 47);
            this.pbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(47, 49);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            this.pbLogin.Tag = "";
            this.pbLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuContenedor
            // 
            this.menuContenedor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuContenedor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestion,
            this.menuLogout});
            this.menuContenedor.Location = new System.Drawing.Point(0, 0);
            this.menuContenedor.Name = "menuContenedor";
            this.menuContenedor.Size = new System.Drawing.Size(1067, 31);
            this.menuContenedor.TabIndex = 4;
            this.menuContenedor.Text = "menuStrip1";
            // 
            // menuGestion
            // 
            this.menuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarPerfilToolStripMenuItem,
            this.verMembresíaToolStripMenuItem});
            this.menuGestion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGestion.Name = "menuGestion";
            this.menuGestion.Size = new System.Drawing.Size(165, 27);
            this.menuGestion.Text = "Gestion de usuario";
            // 
            // modificarPerfilToolStripMenuItem
            // 
            this.modificarPerfilToolStripMenuItem.Name = "modificarPerfilToolStripMenuItem";
            this.modificarPerfilToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.modificarPerfilToolStripMenuItem.Text = "Modificar perfil";
            this.modificarPerfilToolStripMenuItem.Click += new System.EventHandler(this.modificarPerfilToolStripMenuItem_Click);
            // 
            // verMembresíaToolStripMenuItem
            // 
            this.verMembresíaToolStripMenuItem.Name = "verMembresíaToolStripMenuItem";
            this.verMembresíaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.verMembresíaToolStripMenuItem.Text = "Ver membresía";
            // 
            // menuLogout
            // 
            this.menuLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(76, 27);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Location = new System.Drawing.Point(768, 100);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(138, 20);
            this.lblInicioSesion.TabIndex = 5;
            this.lblInicioSesion.Text = "Iniciar Sesion";
            this.lblInicioSesion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEventos.Font = new System.Drawing.Font("Perpetua Titling MT", 12F);
            this.btnEventos.Location = new System.Drawing.Point(491, 204);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(148, 85);
            this.btnEventos.TabIndex = 14;
            this.btnEventos.Text = "IR A EVENTOS";
            this.btnEventos.UseVisualStyleBackColor = false;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(795, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 15;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.menuContenedor);
            this.MainMenuStrip = this.menuContenedor;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Principal Usuarios";
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
        private System.Windows.Forms.Label lblInicioSesion;
        public System.Windows.Forms.PictureBox pbLogin;
        public System.Windows.Forms.ToolStripMenuItem menuGestion;
        private System.Windows.Forms.ToolStripMenuItem modificarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMembresíaToolStripMenuItem;
        public System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

