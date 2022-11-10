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
            this.rbtSuperUsuario = new System.Windows.Forms.RadioButton();
            this.rbtUsuariosPagos = new System.Windows.Forms.RadioButton();
            this.rbtVistaUsuariosadm = new System.Windows.Forms.RadioButton();
            this.rbtUsuariosInvitados = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnDarDeAltaUsEsp = new System.Windows.Forms.Button();
            this.grbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.grbAdministradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSelecciondevista.SuspendLayout();
            this.grbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(180, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(126, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(179, 111);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(126, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcorreo.Location = new System.Drawing.Point(179, 155);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(126, 20);
            this.txtcorreo.TabIndex = 2;
            // 
            // txtNombreDeUSuarioClave
            // 
            this.txtNombreDeUSuarioClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombreDeUSuarioClave.Location = new System.Drawing.Point(179, 192);
            this.txtNombreDeUSuarioClave.Name = "txtNombreDeUSuarioClave";
            this.txtNombreDeUSuarioClave.Size = new System.Drawing.Size(126, 20);
            this.txtNombreDeUSuarioClave.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 75);
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
            this.label2.Location = new System.Drawing.Point(120, 111);
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
            this.lblNombreClave.Location = new System.Drawing.Point(21, 197);
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
            this.label4.Location = new System.Drawing.Point(128, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // grbAdministradores
            // 
            this.grbAdministradores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grbAdministradores.Controls.Add(this.rbUsInvi);
            this.grbAdministradores.Controls.Add(this.rbUsPago);
            this.grbAdministradores.Controls.Add(this.rbAdmDepor);
            this.grbAdministradores.Controls.Add(this.rbSuperUs);
            this.grbAdministradores.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdministradores.Location = new System.Drawing.Point(81, 281);
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
            this.rbUsInvi.Visible = false;
            this.rbUsInvi.CheckedChanged += new System.EventHandler(this.rbUsInvi_CheckedChanged);
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
            this.rbUsPago.Visible = false;
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
            this.rbSuperUs.CheckedChanged += new System.EventHandler(this.rbSuperUs_CheckedChanged);
            // 
            // btncrear
            // 
            this.btncrear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btncrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncrear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.Location = new System.Drawing.Point(167, 373);
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
            this.btnEliminar.Location = new System.Drawing.Point(268, 370);
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
            this.btnModificar.Location = new System.Drawing.Point(369, 370);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(383, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 273);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbSelecciondevista
            // 
            this.grbSelecciondevista.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grbSelecciondevista.Controls.Add(this.rbtSuperUsuario);
            this.grbSelecciondevista.Controls.Add(this.rbtUsuariosPagos);
            this.grbSelecciondevista.Controls.Add(this.rbtVistaUsuariosadm);
            this.grbSelecciondevista.Controls.Add(this.rbtUsuariosInvitados);
            this.grbSelecciondevista.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSelecciondevista.Location = new System.Drawing.Point(479, 347);
            this.grbSelecciondevista.Name = "grbSelecciondevista";
            this.grbSelecciondevista.Size = new System.Drawing.Size(289, 102);
            this.grbSelecciondevista.TabIndex = 14;
            this.grbSelecciondevista.TabStop = false;
            this.grbSelecciondevista.Text = "Seleccion de vista";
            // 
            // rbtSuperUsuario
            // 
            this.rbtSuperUsuario.AutoSize = true;
            this.rbtSuperUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtSuperUsuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSuperUsuario.Location = new System.Drawing.Point(141, 67);
            this.rbtSuperUsuario.Name = "rbtSuperUsuario";
            this.rbtSuperUsuario.Size = new System.Drawing.Size(89, 17);
            this.rbtSuperUsuario.TabIndex = 3;
            this.rbtSuperUsuario.TabStop = true;
            this.rbtSuperUsuario.Text = "Super Usuario";
            this.rbtSuperUsuario.UseVisualStyleBackColor = true;
            this.rbtSuperUsuario.CheckedChanged += new System.EventHandler(this.rbtSuperUsuario_CheckedChanged);
            // 
            // rbtUsuariosPagos
            // 
            this.rbtUsuariosPagos.AutoSize = true;
            this.rbtUsuariosPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtUsuariosPagos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUsuariosPagos.Location = new System.Drawing.Point(17, 66);
            this.rbtUsuariosPagos.Name = "rbtUsuariosPagos";
            this.rbtUsuariosPagos.Size = new System.Drawing.Size(112, 17);
            this.rbtUsuariosPagos.TabIndex = 2;
            this.rbtUsuariosPagos.TabStop = true;
            this.rbtUsuariosPagos.Text = "Usuarios suscriptos";
            this.rbtUsuariosPagos.UseVisualStyleBackColor = true;
            this.rbtUsuariosPagos.Visible = false;
            this.rbtUsuariosPagos.CheckedChanged += new System.EventHandler(this.rbtUsuariosPagos_CheckedChanged);
            // 
            // rbtVistaUsuariosadm
            // 
            this.rbtVistaUsuariosadm.AutoSize = true;
            this.rbtVistaUsuariosadm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtVistaUsuariosadm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVistaUsuariosadm.Location = new System.Drawing.Point(141, 28);
            this.rbtVistaUsuariosadm.Name = "rbtVistaUsuariosadm";
            this.rbtVistaUsuariosadm.Size = new System.Drawing.Size(139, 17);
            this.rbtVistaUsuariosadm.TabIndex = 1;
            this.rbtVistaUsuariosadm.TabStop = true;
            this.rbtVistaUsuariosadm.Text = "Administrador deportivo\r\n";
            this.rbtVistaUsuariosadm.UseVisualStyleBackColor = true;
            this.rbtVistaUsuariosadm.CheckedChanged += new System.EventHandler(this.rbtVistaUsuariosadm_CheckedChanged);
            // 
            // rbtUsuariosInvitados
            // 
            this.rbtUsuariosInvitados.AutoSize = true;
            this.rbtUsuariosInvitados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtUsuariosInvitados.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtUsuariosInvitados.Location = new System.Drawing.Point(17, 28);
            this.rbtUsuariosInvitados.Name = "rbtUsuariosInvitados";
            this.rbtUsuariosInvitados.Size = new System.Drawing.Size(108, 17);
            this.rbtUsuariosInvitados.TabIndex = 0;
            this.rbtUsuariosInvitados.TabStop = true;
            this.rbtUsuariosInvitados.Text = "Usuarios invitados";
            this.rbtUsuariosInvitados.UseVisualStyleBackColor = true;
            this.rbtUsuariosInvitados.Visible = false;
            this.rbtUsuariosInvitados.CheckedChanged += new System.EventHandler(this.rbtVistaGeneral_CheckedChanged);
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
            this.lblRol.Location = new System.Drawing.Point(148, 46);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(24, 15);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Rol";
            // 
            // txtrol
            // 
            this.txtrol.Enabled = false;
            this.txtrol.Location = new System.Drawing.Point(180, 44);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(26, 20);
            this.txtrol.TabIndex = 18;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(180, 18);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(27, 20);
            this.txtid.TabIndex = 19;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(154, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 15);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "ID";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(66, 371);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 22);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(252, 253);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(125, 22);
            this.btnValidar.TabIndex = 22;
            this.btnValidar.Text = "Validar suscripción";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnDarDeAltaUsEsp
            // 
            this.btnDarDeAltaUsEsp.Location = new System.Drawing.Point(44, 252);
            this.btnDarDeAltaUsEsp.Name = "btnDarDeAltaUsEsp";
            this.btnDarDeAltaUsEsp.Size = new System.Drawing.Size(200, 23);
            this.btnDarDeAltaUsEsp.TabIndex = 24;
            this.btnDarDeAltaUsEsp.Text = "Dar de alta a usuarios en espera";
            this.btnDarDeAltaUsEsp.UseVisualStyleBackColor = true;
            this.btnDarDeAltaUsEsp.Click += new System.EventHandler(this.btnDarDeAltaUsEsp_Click);
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.Controls.Add(this.lblid);
            this.grbDatosUsuario.Controls.Add(this.txtid);
            this.grbDatosUsuario.Controls.Add(this.txtrol);
            this.grbDatosUsuario.Controls.Add(this.lblRol);
            this.grbDatosUsuario.Controls.Add(this.label4);
            this.grbDatosUsuario.Controls.Add(this.lblNombreClave);
            this.grbDatosUsuario.Controls.Add(this.label2);
            this.grbDatosUsuario.Controls.Add(this.label1);
            this.grbDatosUsuario.Controls.Add(this.txtNombreDeUSuarioClave);
            this.grbDatosUsuario.Controls.Add(this.txtcorreo);
            this.grbDatosUsuario.Controls.Add(this.txtApellido);
            this.grbDatosUsuario.Controls.Add(this.txtNombre);
            this.grbDatosUsuario.Location = new System.Drawing.Point(9, 9);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Size = new System.Drawing.Size(342, 227);
            this.grbDatosUsuario.TabIndex = 25;
            this.grbDatosUsuario.TabStop = false;
            this.grbDatosUsuario.Text = "Datos de Usuario";
            // 
            // GestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(965, 454);
            this.Controls.Add(this.grbDatosUsuario);
            this.Controls.Add(this.btnDarDeAltaUsEsp);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.grbSelecciondevista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.grbAdministradores);
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
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreClave;
        private System.Windows.Forms.Label label4;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.GroupBox grbSelecciondevista;
        private System.Windows.Forms.RadioButton rbtVistaUsuariosadm;
        private System.Windows.Forms.RadioButton rbtUsuariosInvitados;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtUsuariosPagos;
        private System.Windows.Forms.RadioButton rbtSuperUsuario;
        public System.Windows.Forms.RadioButton rbSuperUs;
        public System.Windows.Forms.GroupBox grbAdministradores;
        public System.Windows.Forms.RadioButton rbUsPago;
        public System.Windows.Forms.RadioButton rbAdmDepor;
        public System.Windows.Forms.RadioButton rbUsInvi;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtcorreo;
        public System.Windows.Forms.TextBox txtNombreDeUSuarioClave;
        public System.Windows.Forms.TextBox txtrol;
        public System.Windows.Forms.Button btnValidar;
        public System.Windows.Forms.Button btnDarDeAltaUsEsp;
        public System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox grbDatosUsuario;
        public System.Windows.Forms.Button btncrear;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnLimpiar;
    }
}