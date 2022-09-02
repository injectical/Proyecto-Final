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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.chkConfirmacionDeFinal = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chkConfirmacionDeInicio = new System.Windows.Forms.CheckBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1783, 12);
            this.panel1.TabIndex = 20;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(97, 325);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(72, 17);
            this.lblresultado.TabIndex = 48;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(230, 316);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(132, 22);
            this.txtResultado.TabIndex = 47;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(230, 59);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 34;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(247, 453);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(230, 189);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(132, 22);
            this.txtFecha.TabIndex = 35;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(410, 453);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(230, 253);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(132, 22);
            this.txtHora.TabIndex = 36;
            this.txtHora.TextChanged += new System.EventHandler(this.txtHora_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(93, 453);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(230, 122);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(132, 22);
            this.txtPais.TabIndex = 37;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
            // 
            // chkConfirmacionDeFinal
            // 
            this.chkConfirmacionDeFinal.AutoSize = true;
            this.chkConfirmacionDeFinal.Location = new System.Drawing.Point(230, 384);
            this.chkConfirmacionDeFinal.Margin = new System.Windows.Forms.Padding(4);
            this.chkConfirmacionDeFinal.Name = "chkConfirmacionDeFinal";
            this.chkConfirmacionDeFinal.Size = new System.Drawing.Size(60, 21);
            this.chkConfirmacionDeFinal.TabIndex = 43;
            this.chkConfirmacionDeFinal.Text = "Final";
            this.chkConfirmacionDeFinal.UseVisualStyleBackColor = true;
            this.chkConfirmacionDeFinal.CheckedChanged += new System.EventHandler(this.chkConfirmacionDeFinal_CheckedChanged_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(97, 63);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // chkConfirmacionDeInicio
            // 
            this.chkConfirmacionDeInicio.AutoSize = true;
            this.chkConfirmacionDeInicio.Location = new System.Drawing.Point(302, 384);
            this.chkConfirmacionDeInicio.Margin = new System.Windows.Forms.Padding(4);
            this.chkConfirmacionDeInicio.Name = "chkConfirmacionDeInicio";
            this.chkConfirmacionDeInicio.Size = new System.Drawing.Size(62, 21);
            this.chkConfirmacionDeInicio.TabIndex = 42;
            this.chkConfirmacionDeInicio.Text = "Inicio";
            this.chkConfirmacionDeInicio.UseVisualStyleBackColor = true;
            this.chkConfirmacionDeInicio.CheckedChanged += new System.EventHandler(this.chkConfirmacionDeInicio_CheckedChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(97, 262);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(95, 17);
            this.lblHora.TabIndex = 39;
            this.lblHora.Text = "Hora de inicio";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(97, 130);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(35, 17);
            this.lblPais.TabIndex = 41;
            this.lblPais.Text = "Pais";
            this.lblPais.Click += new System.EventHandler(this.lblPais_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(97, 198);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 17);
            this.lblFecha.TabIndex = 40;
            this.lblFecha.Text = "Fecha De inicio";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvEventos.Location = new System.Drawing.Point(695, 12);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.RowTemplate.Height = 24;
            this.dgvEventos.Size = new System.Drawing.Size(1088, 575);
            this.dgvEventos.TabIndex = 49;
            this.dgvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(532, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(42, 22);
            this.txtID.TabIndex = 50;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // GestionDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1783, 587);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.chkConfirmacionDeFinal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.chkConfirmacionDeInicio);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionDeEventos";
            this.Text = "Gestion De Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionDeEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.CheckBox chkConfirmacionDeFinal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox chkConfirmacionDeInicio;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.DataGridView dgvEventos;
        public System.Windows.Forms.TextBox txtID;
    }
}