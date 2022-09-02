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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.rbtAutorizarMembresía = new System.Windows.Forms.RadioButton();
            this.rbtAutorizarUsuario = new System.Windows.Forms.RadioButton();
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.grbAdministradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSelecciondevista.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(251, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(251, 126);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(167, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcorreo.Location = new System.Drawing.Point(251, 187);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(167, 22);
            this.txtcorreo.TabIndex = 2;
            // 
            // txtNombreDeUSuarioClave
            // 
            this.txtNombreDeUSuarioClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombreDeUSuarioClave.Location = new System.Drawing.Point(251, 287);
            this.txtNombreDeUSuarioClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeUSuarioClave.Name = "txtNombreDeUSuarioClave";
            this.txtNombreDeUSuarioClave.Size = new System.Drawing.Size(167, 22);
            this.txtNombreDeUSuarioClave.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // lblNombreClave
            // 
            this.lblNombreClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombreClave.AutoSize = true;
            this.lblNombreClave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClave.Location = new System.Drawing.Point(52, 290);
            this.lblNombreClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreClave.Name = "lblNombreClave";
            this.lblNombreClave.Size = new System.Drawing.Size(186, 21);
            this.lblNombreClave.TabIndex = 6;
            this.lblNombreClave.Text = "Nombre clave de usuario";
            this.lblNombreClave.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
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
            this.grbAdministradores.Location = new System.Drawing.Point(147, 345);
            this.grbAdministradores.Margin = new System.Windows.Forms.Padding(4);
            this.grbAdministradores.Name = "grbAdministradores";
            this.grbAdministradores.Padding = new System.Windows.Forms.Padding(4);
            this.grbAdministradores.Size = new System.Drawing.Size(361, 90);
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
            this.rbUsInvi.Location = new System.Drawing.Point(220, 23);
            this.rbUsInvi.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsInvi.Name = "rbUsInvi";
            this.rbUsInvi.Size = new System.Drawing.Size(128, 21);
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
            this.rbUsPago.Location = new System.Drawing.Point(220, 52);
            this.rbUsPago.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsPago.Name = "rbUsPago";
            this.rbUsPago.Size = new System.Drawing.Size(107, 21);
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
            this.rbAdmDepor.Location = new System.Drawing.Point(17, 52);
            this.rbAdmDepor.Margin = new System.Windows.Forms.Padding(4);
            this.rbAdmDepor.Name = "rbAdmDepor";
            this.rbAdmDepor.Size = new System.Drawing.Size(176, 21);
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
            this.rbSuperUs.Location = new System.Drawing.Point(17, 23);
            this.rbSuperUs.Margin = new System.Windows.Forms.Padding(4);
            this.rbSuperUs.Name = "rbSuperUs";
            this.rbSuperUs.Size = new System.Drawing.Size(113, 21);
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
            this.btncrear.Location = new System.Drawing.Point(223, 456);
            this.btncrear.Margin = new System.Windows.Forms.Padding(4);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(103, 27);
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
            this.btnEliminar.Location = new System.Drawing.Point(357, 454);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
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
            this.btnModificar.Location = new System.Drawing.Point(492, 454);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(511, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(784, 334);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbSelecciondevista
            // 
            this.grbSelecciondevista.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grbSelecciondevista.Controls.Add(this.rbtAutorizarMembresía);
            this.grbSelecciondevista.Controls.Add(this.rbtAutorizarUsuario);
            this.grbSelecciondevista.Controls.Add(this.rbtSuperUsuario);
            this.grbSelecciondevista.Controls.Add(this.rbtUsuariosPagos);
            this.grbSelecciondevista.Controls.Add(this.rbtVistaUsuariosadm);
            this.grbSelecciondevista.Controls.Add(this.rbtUsuariosInvitados);
            this.grbSelecciondevista.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSelecciondevista.Location = new System.Drawing.Point(661, 426);
            this.grbSelecciondevista.Margin = new System.Windows.Forms.Padding(4);
            this.grbSelecciondevista.Name = "grbSelecciondevista";
            this.grbSelecciondevista.Padding = new System.Windows.Forms.Padding(4);
            this.grbSelecciondevista.Size = new System.Drawing.Size(604, 126);
            this.grbSelecciondevista.TabIndex = 14;
            this.grbSelecciondevista.TabStop = false;
            this.grbSelecciondevista.Text = "Seleccion de vista";
            // 
            // rbtAutorizarMembresía
            // 
            this.rbtAutorizarMembresía.AutoSize = true;
            this.rbtAutorizarMembresía.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtAutorizarMembresía.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAutorizarMembresía.Location = new System.Drawing.Point(398, 82);
            this.rbtAutorizarMembresía.Margin = new System.Windows.Forms.Padding(4);
            this.rbtAutorizarMembresía.Name = "rbtAutorizarMembresía";
            this.rbtAutorizarMembresía.Size = new System.Drawing.Size(177, 21);
            this.rbtAutorizarMembresía.TabIndex = 5;
            this.rbtAutorizarMembresía.TabStop = true;
            this.rbtAutorizarMembresía.Text = "Suscripciones a autorizar";
            this.rbtAutorizarMembresía.UseVisualStyleBackColor = true;
            this.rbtAutorizarMembresía.CheckedChanged += new System.EventHandler(this.rbtAutorizarMembresía_CheckedChanged);
            // 
            // rbtAutorizarUsuario
            // 
            this.rbtAutorizarUsuario.AutoSize = true;
            this.rbtAutorizarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtAutorizarUsuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAutorizarUsuario.Location = new System.Drawing.Point(398, 32);
            this.rbtAutorizarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rbtAutorizarUsuario.Name = "rbtAutorizarUsuario";
            this.rbtAutorizarUsuario.Size = new System.Drawing.Size(148, 21);
            this.rbtAutorizarUsuario.TabIndex = 4;
            this.rbtAutorizarUsuario.TabStop = true;
            this.rbtAutorizarUsuario.Text = "Usuarios a autorizar";
            this.rbtAutorizarUsuario.UseVisualStyleBackColor = true;
            this.rbtAutorizarUsuario.CheckedChanged += new System.EventHandler(this.rbtAutorizarUsuario_CheckedChanged);
            // 
            // rbtSuperUsuario
            // 
            this.rbtSuperUsuario.AutoSize = true;
            this.rbtSuperUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtSuperUsuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtSuperUsuario.Location = new System.Drawing.Point(188, 82);
            this.rbtSuperUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rbtSuperUsuario.Name = "rbtSuperUsuario";
            this.rbtSuperUsuario.Size = new System.Drawing.Size(113, 21);
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
            this.rbtUsuariosPagos.Location = new System.Drawing.Point(23, 81);
            this.rbtUsuariosPagos.Margin = new System.Windows.Forms.Padding(4);
            this.rbtUsuariosPagos.Name = "rbtUsuariosPagos";
            this.rbtUsuariosPagos.Size = new System.Drawing.Size(145, 21);
            this.rbtUsuariosPagos.TabIndex = 2;
            this.rbtUsuariosPagos.TabStop = true;
            this.rbtUsuariosPagos.Text = "Usuarios suscriptos";
            this.rbtUsuariosPagos.UseVisualStyleBackColor = true;
            this.rbtUsuariosPagos.CheckedChanged += new System.EventHandler(this.rbtUsuariosPagos_CheckedChanged);
            // 
            // rbtVistaUsuariosadm
            // 
            this.rbtVistaUsuariosadm.AutoSize = true;
            this.rbtVistaUsuariosadm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtVistaUsuariosadm.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVistaUsuariosadm.Location = new System.Drawing.Point(188, 34);
            this.rbtVistaUsuariosadm.Margin = new System.Windows.Forms.Padding(4);
            this.rbtVistaUsuariosadm.Name = "rbtVistaUsuariosadm";
            this.rbtVistaUsuariosadm.Size = new System.Drawing.Size(176, 21);
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
            this.rbtUsuariosInvitados.Location = new System.Drawing.Point(23, 34);
            this.rbtUsuariosInvitados.Margin = new System.Windows.Forms.Padding(4);
            this.rbtUsuariosInvitados.Name = "rbtUsuariosInvitados";
            this.rbtUsuariosInvitados.Size = new System.Drawing.Size(139, 21);
            this.rbtUsuariosInvitados.TabIndex = 0;
            this.rbtUsuariosInvitados.TabStop = true;
            this.rbtUsuariosInvitados.Text = "Usuarios invitados";
            this.rbtUsuariosInvitados.UseVisualStyleBackColor = true;
            this.rbtUsuariosInvitados.CheckedChanged += new System.EventHandler(this.rbtVistaGeneral_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(617, 17);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(476, 22);
            this.txtBuscar.TabIndex = 15;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(492, 17);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 28);
            this.btnbuscar.TabIndex = 16;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(211, 37);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 21);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Rol";
            // 
            // txtrol
            // 
            this.txtrol.Enabled = false;
            this.txtrol.Location = new System.Drawing.Point(252, 34);
            this.txtrol.Margin = new System.Windows.Forms.Padding(4);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(33, 22);
            this.txtrol.TabIndex = 18;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(251, 2);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(35, 22);
            this.txtid.TabIndex = 19;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(219, 11);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 21);
            this.lblid.TabIndex = 20;
            this.lblid.Text = "ID";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(88, 456);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 27);
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
            this.btnValidar.Location = new System.Drawing.Point(251, 317);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(167, 27);
            this.btnValidar.TabIndex = 22;
            this.btnValidar.Text = "Validar suscripción";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 37);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 22);
            this.dtpFecha.TabIndex = 23;
            this.dtpFecha.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtContraseña.Location = new System.Drawing.Point(251, 244);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(167, 22);
            this.txtContraseña.TabIndex = 24;
            // 
            // GestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1310, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnLimpiar);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.RadioButton rbtUsuariosInvitados;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtUsuariosPagos;
        private System.Windows.Forms.RadioButton rbtSuperUsuario;
        public System.Windows.Forms.RadioButton rbSuperUs;
        public System.Windows.Forms.GroupBox grbAdministradores;
        public System.Windows.Forms.RadioButton rbUsPago;
        public System.Windows.Forms.RadioButton rbAdmDepor;
        public System.Windows.Forms.RadioButton rbUsInvi;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtcorreo;
        public System.Windows.Forms.TextBox txtNombreDeUSuarioClave;
        public System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rbtAutorizarMembresía;
        private System.Windows.Forms.RadioButton rbtAutorizarUsuario;
        private System.Windows.Forms.Button btnValidar;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtContraseña;
    }
}