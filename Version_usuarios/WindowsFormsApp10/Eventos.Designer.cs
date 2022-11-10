namespace WindowsFormsApp10
{
    partial class btnFinalizados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnFinalizados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lnkFutbol = new System.Windows.Forms.LinkLabel();
            this.lnkBasquet = new System.Windows.Forms.LinkLabel();
            this.lnkTenis = new System.Windows.Forms.LinkLabel();
            this.lnkFutsal = new System.Windows.Forms.LinkLabel();
            this.dataGridDeportes = new System.Windows.Forms.DataGridView();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCompetencia = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lnkAutomovilismo = new System.Windows.Forms.LinkLabel();
            this.lnkBoxeo = new System.Windows.Forms.LinkLabel();
            this.lnkRugby = new System.Windows.Forms.LinkLabel();
            this.lnkAtletismo = new System.Windows.Forms.LinkLabel();
            this.lnkHandball = new System.Windows.Forms.LinkLabel();
            this.lnkMMA = new System.Windows.Forms.LinkLabel();
            this.btnPorComenzar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnProceso = new System.Windows.Forms.Button();
            this.dataGridDetalles = new System.Windows.Forms.DataGridView();
            this.grbDetalles = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuscripcion = new System.Windows.Forms.Button();
            this.txtsuscripcion = new System.Windows.Forms.TextBox();
            this.grbSuscripcion = new System.Windows.Forms.GroupBox();
            this.txtIDEvntSuscrip = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalles)).BeginInit();
            this.grbDetalles.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbSuscripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkFutbol
            // 
            this.lnkFutbol.Image = ((System.Drawing.Image)(resources.GetObject("lnkFutbol.Image")));
            this.lnkFutbol.LinkArea = new System.Windows.Forms.LinkArea(0, 70);
            this.lnkFutbol.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkFutbol.Location = new System.Drawing.Point(14, 46);
            this.lnkFutbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkFutbol.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkFutbol.Name = "lnkFutbol";
            this.lnkFutbol.Size = new System.Drawing.Size(63, 93);
            this.lnkFutbol.TabIndex = 0;
            this.lnkFutbol.TabStop = true;
            this.lnkFutbol.Text = "FUTBOL";
            this.lnkFutbol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkFutbol.UseCompatibleTextRendering = true;
            this.lnkFutbol.Visible = false;
            this.lnkFutbol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFutbol_LinkClicked);
            // 
            // lnkBasquet
            // 
            this.lnkBasquet.Image = ((System.Drawing.Image)(resources.GetObject("lnkBasquet.Image")));
            this.lnkBasquet.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkBasquet.Location = new System.Drawing.Point(97, 46);
            this.lnkBasquet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkBasquet.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkBasquet.Name = "lnkBasquet";
            this.lnkBasquet.Size = new System.Drawing.Size(78, 93);
            this.lnkBasquet.TabIndex = 1;
            this.lnkBasquet.TabStop = true;
            this.lnkBasquet.Text = "BASQUET";
            this.lnkBasquet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkBasquet.Visible = false;
            this.lnkBasquet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBasquet_LinkClicked);
            // 
            // lnkTenis
            // 
            this.lnkTenis.Image = ((System.Drawing.Image)(resources.GetObject("lnkTenis.Image")));
            this.lnkTenis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTenis.Location = new System.Drawing.Point(182, 46);
            this.lnkTenis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkTenis.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkTenis.Name = "lnkTenis";
            this.lnkTenis.Size = new System.Drawing.Size(76, 93);
            this.lnkTenis.TabIndex = 6;
            this.lnkTenis.TabStop = true;
            this.lnkTenis.Text = "TENIS";
            this.lnkTenis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkTenis.Visible = false;
            // 
            // lnkFutsal
            // 
            this.lnkFutsal.Image = ((System.Drawing.Image)(resources.GetObject("lnkFutsal.Image")));
            this.lnkFutsal.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkFutsal.Location = new System.Drawing.Point(249, 45);
            this.lnkFutsal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkFutsal.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkFutsal.Name = "lnkFutsal";
            this.lnkFutsal.Size = new System.Drawing.Size(108, 93);
            this.lnkFutsal.TabIndex = 7;
            this.lnkFutsal.TabStop = true;
            this.lnkFutsal.Text = "FUTSAL";
            this.lnkFutsal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkFutsal.Visible = false;
            // 
            // dataGridDeportes
            // 
            this.dataGridDeportes.AccessibleDescription = "";
            this.dataGridDeportes.AccessibleName = "";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDeportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDeportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDeportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDeportes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridDeportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridDeportes.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridDeportes.Location = new System.Drawing.Point(16, 28);
            this.dataGridDeportes.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridDeportes.Name = "dataGridDeportes";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDeportes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDeportes.RowTemplate.Height = 24;
            this.dataGridDeportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDeportes.Size = new System.Drawing.Size(560, 175);
            this.dataGridDeportes.TabIndex = 12;
            this.dataGridDeportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeportes_CellContentClick);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.Location = new System.Drawing.Point(289, 18);
            this.lblIndicaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicaciones.MinimumSize = new System.Drawing.Size(38, 28);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(514, 28);
            this.lblIndicaciones.TabIndex = 13;
            this.lblIndicaciones.Text = "Haga click en el deporte del cual desea visualizar resultados";
            this.lblIndicaciones.Visible = false;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPais.Location = new System.Drawing.Point(679, 530);
            this.txtPais.Margin = new System.Windows.Forms.Padding(2);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(76, 20);
            this.txtPais.TabIndex = 14;
            this.txtPais.Visible = false;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCompetencia.Location = new System.Drawing.Point(679, 554);
            this.txtCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(76, 20);
            this.txtCompetencia.TabIndex = 15;
            this.txtCompetencia.Visible = false;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTipo.Location = new System.Drawing.Point(772, 537);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(76, 20);
            this.txtTipo.TabIndex = 16;
            this.txtTipo.Visible = false;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(729, 542);
            this.lblPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(119, 17);
            this.lblPais.TabIndex = 17;
            this.lblPais.Text = "Pais competencia";
            this.lblPais.Visible = false;
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(687, 535);
            this.lblCompetencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(142, 17);
            this.lblCompetencia.TabIndex = 18;
            this.lblCompetencia.Text = "Nombre competencia";
            this.lblCompetencia.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(759, 559);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(89, 17);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "Tipo deporte";
            this.lblTipo.Visible = false;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(679, 531);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(98, 26);
            this.lblBusqueda.TabIndex = 20;
            this.lblBusqueda.Text = "Búsqueda";
            this.lblBusqueda.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(21, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 32);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Finalizados";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lnkAutomovilismo
            // 
            this.lnkAutomovilismo.Image = ((System.Drawing.Image)(resources.GetObject("lnkAutomovilismo.Image")));
            this.lnkAutomovilismo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAutomovilismo.Location = new System.Drawing.Point(334, 46);
            this.lnkAutomovilismo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkAutomovilismo.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkAutomovilismo.Name = "lnkAutomovilismo";
            this.lnkAutomovilismo.Size = new System.Drawing.Size(108, 93);
            this.lnkAutomovilismo.TabIndex = 22;
            this.lnkAutomovilismo.TabStop = true;
            this.lnkAutomovilismo.Text = "AUTOMOVILISMO";
            this.lnkAutomovilismo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkAutomovilismo.Visible = false;
            // 
            // lnkBoxeo
            // 
            this.lnkBoxeo.Image = ((System.Drawing.Image)(resources.GetObject("lnkBoxeo.Image")));
            this.lnkBoxeo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkBoxeo.Location = new System.Drawing.Point(422, 46);
            this.lnkBoxeo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkBoxeo.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkBoxeo.Name = "lnkBoxeo";
            this.lnkBoxeo.Size = new System.Drawing.Size(108, 93);
            this.lnkBoxeo.TabIndex = 23;
            this.lnkBoxeo.TabStop = true;
            this.lnkBoxeo.Text = "BOXEO";
            this.lnkBoxeo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkBoxeo.Visible = false;
            // 
            // lnkRugby
            // 
            this.lnkRugby.Image = ((System.Drawing.Image)(resources.GetObject("lnkRugby.Image")));
            this.lnkRugby.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRugby.Location = new System.Drawing.Point(508, 46);
            this.lnkRugby.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkRugby.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkRugby.Name = "lnkRugby";
            this.lnkRugby.Size = new System.Drawing.Size(93, 95);
            this.lnkRugby.TabIndex = 24;
            this.lnkRugby.TabStop = true;
            this.lnkRugby.Text = "RUGBY";
            this.lnkRugby.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkRugby.Visible = false;
            // 
            // lnkAtletismo
            // 
            this.lnkAtletismo.Image = ((System.Drawing.Image)(resources.GetObject("lnkAtletismo.Image")));
            this.lnkAtletismo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAtletismo.Location = new System.Drawing.Point(593, 46);
            this.lnkAtletismo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkAtletismo.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkAtletismo.Name = "lnkAtletismo";
            this.lnkAtletismo.Size = new System.Drawing.Size(92, 95);
            this.lnkAtletismo.TabIndex = 25;
            this.lnkAtletismo.TabStop = true;
            this.lnkAtletismo.Text = "ATLETISMO";
            this.lnkAtletismo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkAtletismo.Visible = false;
            // 
            // lnkHandball
            // 
            this.lnkHandball.Image = ((System.Drawing.Image)(resources.GetObject("lnkHandball.Image")));
            this.lnkHandball.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkHandball.Location = new System.Drawing.Point(683, 46);
            this.lnkHandball.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkHandball.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkHandball.Name = "lnkHandball";
            this.lnkHandball.Size = new System.Drawing.Size(92, 95);
            this.lnkHandball.TabIndex = 26;
            this.lnkHandball.TabStop = true;
            this.lnkHandball.Text = "HANDBALL";
            this.lnkHandball.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkHandball.Visible = false;
            // 
            // lnkMMA
            // 
            this.lnkMMA.Image = ((System.Drawing.Image)(resources.GetObject("lnkMMA.Image")));
            this.lnkMMA.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMMA.Location = new System.Drawing.Point(770, 43);
            this.lnkMMA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkMMA.MinimumSize = new System.Drawing.Size(52, 57);
            this.lnkMMA.Name = "lnkMMA";
            this.lnkMMA.Size = new System.Drawing.Size(92, 95);
            this.lnkMMA.TabIndex = 27;
            this.lnkMMA.TabStop = true;
            this.lnkMMA.Text = "MMA";
            this.lnkMMA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkMMA.Visible = false;
            // 
            // btnPorComenzar
            // 
            this.btnPorComenzar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPorComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorComenzar.Location = new System.Drawing.Point(21, 76);
            this.btnPorComenzar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPorComenzar.Name = "btnPorComenzar";
            this.btnPorComenzar.Size = new System.Drawing.Size(137, 32);
            this.btnPorComenzar.TabIndex = 28;
            this.btnPorComenzar.Text = "Por comenzar";
            this.btnPorComenzar.UseVisualStyleBackColor = false;
            this.btnPorComenzar.Click += new System.EventHandler(this.btnPorComenzar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnProceso);
            this.groupBox1.Controls.Add(this.btnPorComenzar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(693, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 166);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btnEnProceso
            // 
            this.btnEnProceso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnProceso.Location = new System.Drawing.Point(21, 129);
            this.btnEnProceso.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnProceso.Name = "btnEnProceso";
            this.btnEnProceso.Size = new System.Drawing.Size(137, 32);
            this.btnEnProceso.TabIndex = 29;
            this.btnEnProceso.Text = "En proceso";
            this.btnEnProceso.UseVisualStyleBackColor = false;
            this.btnEnProceso.Click += new System.EventHandler(this.btnEnProceso_Click);
            // 
            // dataGridDetalles
            // 
            this.dataGridDetalles.AccessibleDescription = "";
            this.dataGridDetalles.AccessibleName = "";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDetalles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridDetalles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalles.Location = new System.Drawing.Point(16, 18);
            this.dataGridDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridDetalles.Name = "dataGridDetalles";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDetalles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridDetalles.RowTemplate.Height = 24;
            this.dataGridDetalles.Size = new System.Drawing.Size(324, 109);
            this.dataGridDetalles.TabIndex = 30;
            this.dataGridDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDetalles_CellContentClick);
            // 
            // grbDetalles
            // 
            this.grbDetalles.Controls.Add(this.dataGridDetalles);
            this.grbDetalles.Location = new System.Drawing.Point(51, 350);
            this.grbDetalles.Name = "grbDetalles";
            this.grbDetalles.Size = new System.Drawing.Size(345, 149);
            this.grbDetalles.TabIndex = 31;
            this.grbDetalles.TabStop = false;
            this.grbDetalles.Text = "Detalles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridDeportes);
            this.groupBox2.Location = new System.Drawing.Point(35, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 217);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "grbEventos";
            // 
            // btnSuscripcion
            // 
            this.btnSuscripcion.Location = new System.Drawing.Point(46, 81);
            this.btnSuscripcion.Name = "btnSuscripcion";
            this.btnSuscripcion.Size = new System.Drawing.Size(118, 30);
            this.btnSuscripcion.TabIndex = 33;
            this.btnSuscripcion.Text = "Aceptar";
            this.btnSuscripcion.UseVisualStyleBackColor = true;
            this.btnSuscripcion.Click += new System.EventHandler(this.btnSuscripcion_Click);
            // 
            // txtsuscripcion
            // 
            this.txtsuscripcion.Location = new System.Drawing.Point(9, 26);
            this.txtsuscripcion.Name = "txtsuscripcion";
            this.txtsuscripcion.Size = new System.Drawing.Size(174, 20);
            this.txtsuscripcion.TabIndex = 34;
            this.txtsuscripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grbSuscripcion
            // 
            this.grbSuscripcion.Controls.Add(this.txtIDEvntSuscrip);
            this.grbSuscripcion.Controls.Add(this.txtsuscripcion);
            this.grbSuscripcion.Controls.Add(this.btnSuscripcion);
            this.grbSuscripcion.Location = new System.Drawing.Point(436, 382);
            this.grbSuscripcion.Name = "grbSuscripcion";
            this.grbSuscripcion.Size = new System.Drawing.Size(195, 117);
            this.grbSuscripcion.TabIndex = 35;
            this.grbSuscripcion.TabStop = false;
            this.grbSuscripcion.Text = "Subscripcion";
            // 
            // txtIDEvntSuscrip
            // 
            this.txtIDEvntSuscrip.Location = new System.Drawing.Point(10, 48);
            this.txtIDEvntSuscrip.Name = "txtIDEvntSuscrip";
            this.txtIDEvntSuscrip.Size = new System.Drawing.Size(35, 20);
            this.txtIDEvntSuscrip.TabIndex = 35;
            this.txtIDEvntSuscrip.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbSuscripcion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbDetalles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnkMMA);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lnkHandball);
            this.Controls.Add(this.lnkAtletismo);
            this.Controls.Add(this.lnkRugby);
            this.Controls.Add(this.lnkBoxeo);
            this.Controls.Add(this.lnkAutomovilismo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCompetencia);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.lnkFutsal);
            this.Controls.Add(this.lnkTenis);
            this.Controls.Add(this.lnkBasquet);
            this.Controls.Add(this.lnkFutbol);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "btnFinalizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Eventos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalles)).EndInit();
            this.grbDetalles.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grbSuscripcion.ResumeLayout(false);
            this.grbSuscripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkFutbol;
        private System.Windows.Forms.LinkLabel lnkBasquet;
        private System.Windows.Forms.LinkLabel lnkTenis;
        private System.Windows.Forms.LinkLabel lnkFutsal;
        private System.Windows.Forms.DataGridView dataGridDeportes;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.TextBox txtCompetencia;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.LinkLabel lnkAutomovilismo;
        private System.Windows.Forms.LinkLabel lnkBoxeo;
        private System.Windows.Forms.LinkLabel lnkRugby;
        private System.Windows.Forms.LinkLabel lnkAtletismo;
        private System.Windows.Forms.LinkLabel lnkHandball;
        private System.Windows.Forms.LinkLabel lnkMMA;
        public System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataGridDetalles;
        public System.Windows.Forms.Button btnSuscripcion;
        public System.Windows.Forms.TextBox txtsuscripcion;
        public System.Windows.Forms.TextBox txtIDEvntSuscrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnPorComenzar;
        public System.Windows.Forms.GroupBox grbDetalles;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox grbSuscripcion;
        public System.Windows.Forms.Button btnEnProceso;
    }
}