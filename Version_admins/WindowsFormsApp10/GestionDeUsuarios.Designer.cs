namespace WindowsFormsApp10
{
    partial class GestionDeUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtNombreDeUSuarioClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreClave = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbAdministradores = new System.Windows.Forms.GroupBox();
            this.rbUsInvi = new System.Windows.Forms.RadioButton();
            this.rbUsPago = new System.Windows.Forms.RadioButton();
            this.rbAdmDepor = new System.Windows.Forms.RadioButton();
            this.rbSuperUs = new System.Windows.Forms.RadioButton();
            this.btncrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbSelecciondevista = new System.Windows.Forms.GroupBox();
            this.rbSuperUsuario = new System.Windows.Forms.RadioButton();
            this.rbUsuariosPagos = new System.Windows.Forms.RadioButton();
            this.rbtVistaUsuariosadm = new System.Windows.Forms.RadioButton();
            this.rdbUsuariosInvitados = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.grbAdministradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSelecciondevista.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(188, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(188, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcorreo.Location = new System.Drawing.Point(188, 152);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(126, 20);
            this.txtcorreo.TabIndex = 2;
            // 
            // txtNombreDeUSuarioClave
            // 
            this.txtNombreDeUSuarioClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombreDeUSuarioClave.Location = new System.Drawing.Point(188, 204);
            this.txtNombreDeUSuarioClave.Name = "txtNombreDeUSuarioClave";
            this.txtNombreDeUSuarioClave.Size = new System.Drawing.Size(126, 20);
            this.txtNombreDeUSuarioClave.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // lblNombreClave
            // 
            this.lblNombreClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombreClave.AutoSize = true;
            this.lblNombreClave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClave.Location = new System.Drawing.Point(39, 206);
            this.lblNombreClave.Name = "lblNombreClave";
            this.lblNombreClave.Size = new System.Drawing.Size(143, 15);
            this.lblNombreClave.TabIndex = 6;
            this.lblNombreClave.Text = "Nombre clave de usuario";
            this.lblNombreClave.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo";
            // 
            // grbAdministradores
            // 
            this.grbAdministradores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grbAdministradores.Controls.Add(this.rbUsInvi);
            this.grbAdministradores.Controls.Add(this.rbUsPago);
            this.grbAdministradores.Controls.Add(this.rbAdmDepor);
            this.grbAdministradores.Controls.Add(this.rbSuperUs);
            this.grbAdministradores.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdministradores.Location = new System.Drawing.Point(110, 251);
            this.grbAdministradores.Name = "grbAdministradores";
            this.grbAdministradores.Size = new System.Drawing.Size(271, 73);
            this.grbAdministradores.TabIndex = 8;
            this.grbAdministradores.TabStop = false;
            this.grbAdministradores.Text = "Tipo de Usuario";
            this.grbAdministradores.Enter += new System.EventHandler(this.grbAdministradores_Enter);
            // 
            // rbUsInvi
            // 
            this.rbUsInvi.AutoSize = true;
            this.rbUsInvi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUsInvi.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsInvi.Location = new System.Drawing.Point(165, 19);
            this.rbUsInvi.Name = "rbUsInvi";
            this.rbUsInvi.Size = new System.Drawing.Size(100, 17);
            this.rbUsInvi.TabIndex = 3;
            this.rbUsInvi.TabStop = true;
            this.rbUsInvi.Text = "Usuario Invitado";
            this.rbUsInvi.UseVisualStyleBackColor = true;
            // 
            // rbUsPago
            // 
            this.rbUsPago.AutoSize = true;
            this.rbUsPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUsPago.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsPago.Location = new System.Drawing.Point(165, 42);
            this.rbUsPago.Name = "rbUsPago";
            this.rbUsPago.Size = new System.Drawing.Size(84, 17);
            this.rbUsPago.TabIndex = 2;
            this.rbUsPago.TabStop = true;
            this.rbUsPago.Text = "Usuario Pago";
            this.rbUsPago.UseVisualStyleBackColor = true;
            // 
            // rbAdmDepor
            // 
            this.rbAdmDepor.AutoSize = true;
            this.rbAdmDepor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAdmDepor.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmDepor.Location = new System.Drawing.Point(13, 42);
            this.rbAdmDepor.Name = "rbAdmDepor";
            this.rbAdmDepor.Size = new System.Drawing.Size(139, 17);
            this.rbAdmDepor.TabIndex = 1;
            this.rbAdmDepor.TabStop = true;
            this.rbAdmDepor.Text = "Administrador deportivo";
            this.rbAdmDepor.UseVisualStyleBackColor = true;
            // 
            // rbSuperUs
            // 
            this.rbSuperUs.AutoSize = true;
            this.rbSuperUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSuperUs.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuperUs.Location = new System.Drawing.Point(13, 19);
            this.rbSuperUs.Name = "rbSuperUs";
            this.rbSuperUs.Size = new System.Drawing.Size(89, 17);
            this.rbSuperUs.TabIndex = 0;
            this.rbSuperUs.TabStop = true;
            this.rbSuperUs.Text = "Super Usuario";
            this.rbSuperUs.UseVisualStyleBackColor = true;
            // 
            // btncrear
            // 
            this.btncrear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btncrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.Location = new System.Drawing.Point(96, 344);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(77, 22);
            this.btncrear.TabIndex = 10;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(205, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(306, 344);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(383, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(476, 214);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // grbSelecciondevista
            // 
            this.grbSelecciondevista.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grbSelecciondevista.Controls.Add(this.rbSuperUsuario);
            this.grbSelecciondevista.Controls.Add(this.rbUsuariosPagos);
            this.grbSelecciondevista.Controls.Add(this.rbtVistaUsuariosadm);
            this.grbSelecciondevista.Controls.Add(this.rdbUsuariosInvitados);
            this.grbSelecciondevista.Location = new System.Drawing.Point(502, 280);
            this.grbSelecciondevista.Name = "grbSelecciondevista";
            this.grbSelecciondevista.Size = new System.Drawing.Size(246, 102);
            this.grbSelecciondevista.TabIndex = 14;
            this.grbSelecciondevista.TabStop = false;
            this.grbSelecciondevista.Text = "Seleccion de vista";
            // 
            // rbSuperUsuario
            // 
            this.rbSuperUsuario.AutoSize = true;
            this.rbSuperUsuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuperUsuario.Location = new System.Drawing.Point(141, 67);
            this.rbSuperUsuario.Name = "rbSuperUsuario";
            this.rbSuperUsuario.Size = new System.Drawing.Size(89, 17);
            this.rbSuperUsuario.TabIndex = 3;
            this.rbSuperUsuario.TabStop = true;
            this.rbSuperUsuario.Text = "Super Usuario";
            this.rbSuperUsuario.UseVisualStyleBackColor = true;
            this.rbSuperUsuario.CheckedChanged += new System.EventHandler(this.rbSuperUsuario_CheckedChanged);
            // 
            // rbUsuariosPagos
            // 
            this.rbUsuariosPagos.AutoSize = true;
            this.rbUsuariosPagos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUsuariosPagos.Location = new System.Drawing.Point(17, 66);
            this.rbUsuariosPagos.Name = "rbUsuariosPagos";
            this.rbUsuariosPagos.Size = new System.Drawing.Size(112, 17);
            this.rbUsuariosPagos.TabIndex = 2;
            this.rbUsuariosPagos.TabStop = true;
            this.rbUsuariosPagos.Text = "Usuarios suscriptos";
            this.rbUsuariosPagos.UseVisualStyleBackColor = true;
            this.rbUsuariosPagos.CheckedChanged += new System.EventHandler(this.rbUsuariosPagos_CheckedChanged);
            // 
            // rbtVistaUsuariosadm
            // 
            this.rbtVistaUsuariosadm.AutoSize = true;
            this.rbtVistaUsuariosadm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVistaUsuariosadm.Location = new System.Drawing.Point(141, 28);
            this.rbtVistaUsuariosadm.Name = "rbtVistaUsuariosadm";
            this.rbtVistaUsuariosadm.Size = new System.Drawing.Size(102, 17);
            this.rbtVistaUsuariosadm.TabIndex = 1;
            this.rbtVistaUsuariosadm.TabStop = true;
            this.rbtVistaUsuariosadm.Text = "Administradores";
            this.rbtVistaUsuariosadm.UseVisualStyleBackColor = true;
            this.rbtVistaUsuariosadm.CheckedChanged += new System.EventHandler(this.rbtVistaUsuariosadm_CheckedChanged);
            // 
            // rdbUsuariosInvitados
            // 
            this.rdbUsuariosInvitados.AutoSize = true;
            this.rdbUsuariosInvitados.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUsuariosInvitados.Location = new System.Drawing.Point(17, 28);
            this.rdbUsuariosInvitados.Name = "rdbUsuariosInvitados";
            this.rdbUsuariosInvitados.Size = new System.Drawing.Size(87, 17);
            this.rdbUsuariosInvitados.TabIndex = 0;
            this.rdbUsuariosInvitados.TabStop = true;
            this.rdbUsuariosInvitados.Text = "Vista General";
            this.rdbUsuariosInvitados.UseVisualStyleBackColor = true;
            this.rdbUsuariosInvitados.CheckedChanged += new System.EventHandler(this.rdbVistaGeneral_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(463, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(358, 20);
            this.txtBuscar.TabIndex = 15;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(369, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 16;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(158, 30);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 15);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Rol";
            // 
            // txtrol
            // 
            this.txtrol.Enabled = false;
            this.txtrol.Location = new System.Drawing.Point(189, 28);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(26, 20);
            this.txtrol.TabIndex = 18;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(188, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(27, 20);
            this.txtid.TabIndex = 19;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(164, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 15);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "ID";
            // 
            // GestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(871, 394);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtrol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.grbSelecciondevista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.grbAdministradores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreDeUSuarioClave);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GestionDeUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.GestionDeUsuarios_Load);
            this.grbAdministradores.ResumeLayout(false);
            this.grbAdministradores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbSelecciondevista.ResumeLayout(false);
            this.grbSelecciondevista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtNombreDeUSuarioClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.GroupBox grbSelecciondevista;
        private System.Windows.Forms.RadioButton rbtVistaUsuariosadm;
        private System.Windows.Forms.RadioButton rdbUsuariosInvitados;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbUsuariosPagos;
        private System.Windows.Forms.RadioButton rbSuperUsuario;
        public System.Windows.Forms.RadioButton rbSuperUs;
        public System.Windows.Forms.GroupBox grbAdministradores;
        public System.Windows.Forms.RadioButton rbUsPago;
        public System.Windows.Forms.RadioButton rbAdmDepor;
        public System.Windows.Forms.RadioButton rbUsInvi;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox txtid;
    }
}