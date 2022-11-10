namespace WindowsFormsApp10
{
    partial class GestionDeEventos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnVerEventos = new System.Windows.Forms.Button();
            this.dtgEventos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDhora = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaCrear = new System.Windows.Forms.DateTimePicker();
            this.gbDatosEvento = new System.Windows.Forms.GroupBox();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMasivo = new System.Windows.Forms.RadioButton();
            this.rbVS = new System.Windows.Forms.RadioButton();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.chkConfirmacionDeFinal = new System.Windows.Forms.CheckBox();
            this.chkConfirmacionDeInicio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).BeginInit();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDhora)).BeginInit();
            this.gbDatosEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 10);
            this.panel1.TabIndex = 20;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(87, 249);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 48;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(151, 242);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(107, 20);
            this.txtResultado.TabIndex = 47;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 34;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(90, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(183, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 337);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(151, 88);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 37;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(98, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(70, 211);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(72, 13);
            this.lblHora.TabIndex = 39;
            this.lblHora.Text = "Hora de inicio";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(115, 95);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 41;
            this.lblPais.Text = "Pais";
            this.lblPais.Click += new System.EventHandler(this.lblPais_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(151, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(32, 20);
            this.txtID.TabIndex = 50;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnVerEventos
            // 
            this.btnVerEventos.Location = new System.Drawing.Point(454, 424);
            this.btnVerEventos.Name = "btnVerEventos";
            this.btnVerEventos.Size = new System.Drawing.Size(266, 23);
            this.btnVerEventos.TabIndex = 52;
            this.btnVerEventos.Text = "VER TODOS";
            this.btnVerEventos.UseVisualStyleBackColor = true;
            this.btnVerEventos.Click += new System.EventHandler(this.btnVerEventos_Click);
            // 
            // dtgEventos
            // 
            this.dtgEventos.AllowUserToOrderColumns = true;
            this.dtgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEventos.Location = new System.Drawing.Point(316, 110);
            this.dtgEventos.Name = "dtgEventos";
            this.dtgEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEventos.Size = new System.Drawing.Size(571, 271);
            this.dtgEventos.TabIndex = 53;
            this.dtgEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEventos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Location = new System.Drawing.Point(6, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarNombre.Location = new System.Drawing.Point(109, 31);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(179, 20);
            this.txtBuscarNombre.TabIndex = 56;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.dtFecha1);
            this.gbBuscar.Controls.Add(this.label3);
            this.gbBuscar.Controls.Add(this.label2);
            this.gbBuscar.Controls.Add(this.txtBuscarNombre);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Location = new System.Drawing.Point(310, 14);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(553, 80);
            this.gbBuscar.TabIndex = 58;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Busqueda";
            // 
            // dtFecha1
            // 
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha1.Location = new System.Drawing.Point(325, 32);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(100, 20);
            this.dtFecha1.TabIndex = 61;
            this.dtFecha1.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nombre";
            // 
            // nUDhora
            // 
            this.nUDhora.Location = new System.Drawing.Point(151, 178);
            this.nUDhora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nUDhora.Name = "nUDhora";
            this.nUDhora.Size = new System.Drawing.Size(32, 20);
            this.nUDhora.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "h";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Fecha";
            // 
            // dtpFechaCrear
            // 
            this.dtpFechaCrear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCrear.Location = new System.Drawing.Point(149, 115);
            this.dtpFechaCrear.Name = "dtpFechaCrear";
            this.dtpFechaCrear.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaCrear.TabIndex = 62;
            // 
            // gbDatosEvento
            // 
            this.gbDatosEvento.Controls.Add(this.nudMinutos);
            this.gbDatosEvento.Controls.Add(this.groupBox1);
            this.gbDatosEvento.Controls.Add(this.txtFecha);
            this.gbDatosEvento.Controls.Add(this.txtHora);
            this.gbDatosEvento.Controls.Add(this.dtpFechaCrear);
            this.gbDatosEvento.Controls.Add(this.label6);
            this.gbDatosEvento.Controls.Add(this.label5);
            this.gbDatosEvento.Controls.Add(this.label4);
            this.gbDatosEvento.Controls.Add(this.nUDhora);
            this.gbDatosEvento.Controls.Add(this.label1);
            this.gbDatosEvento.Controls.Add(this.txtID);
            this.gbDatosEvento.Controls.Add(this.lblresultado);
            this.gbDatosEvento.Controls.Add(this.txtResultado);
            this.gbDatosEvento.Controls.Add(this.txtNombre);
            this.gbDatosEvento.Controls.Add(this.btnModificar);
            this.gbDatosEvento.Controls.Add(this.btnEliminar);
            this.gbDatosEvento.Controls.Add(this.btnAgregar);
            this.gbDatosEvento.Controls.Add(this.txtPais);
            this.gbDatosEvento.Controls.Add(this.chkConfirmacionDeFinal);
            this.gbDatosEvento.Controls.Add(this.lblNombre);
            this.gbDatosEvento.Controls.Add(this.chkConfirmacionDeInicio);
            this.gbDatosEvento.Controls.Add(this.lblHora);
            this.gbDatosEvento.Controls.Add(this.lblPais);
            this.gbDatosEvento.Location = new System.Drawing.Point(21, 63);
            this.gbDatosEvento.Name = "gbDatosEvento";
            this.gbDatosEvento.Size = new System.Drawing.Size(289, 384);
            this.gbDatosEvento.TabIndex = 64;
            this.gbDatosEvento.TabStop = false;
            this.gbDatosEvento.Text = "Datos del Evento";
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(205, 178);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(32, 20);
            this.nudMinutos.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMasivo);
            this.groupBox1.Controls.Add(this.rbVS);
            this.groupBox1.Location = new System.Drawing.Point(73, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 40);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            this.groupBox1.Visible = false;
            // 
            // rbMasivo
            // 
            this.rbMasivo.AutoSize = true;
            this.rbMasivo.Location = new System.Drawing.Point(105, 19);
            this.rbMasivo.Name = "rbMasivo";
            this.rbMasivo.Size = new System.Drawing.Size(59, 17);
            this.rbMasivo.TabIndex = 67;
            this.rbMasivo.TabStop = true;
            this.rbMasivo.Text = "Masivo";
            this.rbMasivo.UseVisualStyleBackColor = true;
            // 
            // rbVS
            // 
            this.rbVS.AutoSize = true;
            this.rbVS.Location = new System.Drawing.Point(6, 17);
            this.rbVS.Name = "rbVS";
            this.rbVS.Size = new System.Drawing.Size(42, 17);
            this.rbVS.TabIndex = 66;
            this.rbVS.TabStop = true;
            this.rbVS.Text = "VS.";
            this.rbVS.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(150, 143);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 65;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(151, 204);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(86, 20);
            this.txtHora.TabIndex = 64;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged_1);
            // 
            // chkConfirmacionDeFinal
            // 
            this.chkConfirmacionDeFinal.AutoSize = true;
            this.chkConfirmacionDeFinal.Location = new System.Drawing.Point(151, 268);
            this.chkConfirmacionDeFinal.Name = "chkConfirmacionDeFinal";
            this.chkConfirmacionDeFinal.Size = new System.Drawing.Size(48, 17);
            this.chkConfirmacionDeFinal.TabIndex = 43;
            this.chkConfirmacionDeFinal.Text = "Final";
            this.chkConfirmacionDeFinal.UseVisualStyleBackColor = true;
            this.chkConfirmacionDeFinal.CheckedChanged += new System.EventHandler(this.chkConfirmacionDeFinal_CheckedChanged_1);
            // 
            // chkConfirmacionDeInicio
            // 
            this.chkConfirmacionDeInicio.AutoSize = true;
            this.chkConfirmacionDeInicio.Location = new System.Drawing.Point(205, 268);
            this.chkConfirmacionDeInicio.Name = "chkConfirmacionDeInicio";
            this.chkConfirmacionDeInicio.Size = new System.Drawing.Size(51, 17);
            this.chkConfirmacionDeInicio.TabIndex = 42;
            this.chkConfirmacionDeInicio.Text = "Inicio";
            this.chkConfirmacionDeInicio.UseVisualStyleBackColor = true;
            this.chkConfirmacionDeInicio.CheckedChanged += new System.EventHandler(this.chkConfirmacionDeInicio_CheckedChanged);
            // 
            // GestionDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 477);
            this.Controls.Add(this.gbDatosEvento);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.dtgEventos);
            this.Controls.Add(this.btnVerEventos);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionDeEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Eventos";
            this.Load += new System.EventHandler(this.GestionDeEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventos)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDhora)).EndInit();
            this.gbDatosEvento.ResumeLayout(false);
            this.gbDatosEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPais;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.DataGridView dtgEventos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnVerEventos;
        public System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown nUDhora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtpFechaCrear;
        public System.Windows.Forms.TextBox txtResultado;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtPais;
        public System.Windows.Forms.TextBox txtBuscarNombre;
        public System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.GroupBox gbDatosEvento;
        private System.Windows.Forms.CheckBox chkConfirmacionDeFinal;
        private System.Windows.Forms.CheckBox chkConfirmacionDeInicio;
        public System.Windows.Forms.TextBox txtFecha;
        public System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.RadioButton rbMasivo;
        public System.Windows.Forms.RadioButton rbVS;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.NumericUpDown nudMinutos;
    }
}