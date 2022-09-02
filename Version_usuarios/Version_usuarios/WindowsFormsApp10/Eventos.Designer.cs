namespace WindowsFormsApp10
{
    partial class Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkFutbol
            // 
            this.lnkFutbol.Image = ((System.Drawing.Image)(resources.GetObject("lnkFutbol.Image")));
            this.lnkFutbol.LinkArea = new System.Windows.Forms.LinkArea(0, 70);
            this.lnkFutbol.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkFutbol.Location = new System.Drawing.Point(19, 56);
            this.lnkFutbol.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkFutbol.Name = "lnkFutbol";
            this.lnkFutbol.Size = new System.Drawing.Size(84, 115);
            this.lnkFutbol.TabIndex = 0;
            this.lnkFutbol.TabStop = true;
            this.lnkFutbol.Text = "FUTBOL";
            this.lnkFutbol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkFutbol.UseCompatibleTextRendering = true;
            this.lnkFutbol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFutbol_LinkClicked);
            // 
            // lnkBasquet
            // 
            this.lnkBasquet.Image = ((System.Drawing.Image)(resources.GetObject("lnkBasquet.Image")));
            this.lnkBasquet.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkBasquet.Location = new System.Drawing.Point(129, 56);
            this.lnkBasquet.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkBasquet.Name = "lnkBasquet";
            this.lnkBasquet.Size = new System.Drawing.Size(104, 115);
            this.lnkBasquet.TabIndex = 1;
            this.lnkBasquet.TabStop = true;
            this.lnkBasquet.Text = "BASQUET";
            this.lnkBasquet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkBasquet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBasquet_LinkClicked);
            // 
            // lnkTenis
            // 
            this.lnkTenis.Image = ((System.Drawing.Image)(resources.GetObject("lnkTenis.Image")));
            this.lnkTenis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTenis.Location = new System.Drawing.Point(243, 57);
            this.lnkTenis.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkTenis.Name = "lnkTenis";
            this.lnkTenis.Size = new System.Drawing.Size(101, 115);
            this.lnkTenis.TabIndex = 6;
            this.lnkTenis.TabStop = true;
            this.lnkTenis.Text = "TENIS";
            this.lnkTenis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lnkFutsal
            // 
            this.lnkFutsal.Image = ((System.Drawing.Image)(resources.GetObject("lnkFutsal.Image")));
            this.lnkFutsal.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkFutsal.Location = new System.Drawing.Point(332, 55);
            this.lnkFutsal.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkFutsal.Name = "lnkFutsal";
            this.lnkFutsal.Size = new System.Drawing.Size(144, 115);
            this.lnkFutsal.TabIndex = 7;
            this.lnkFutsal.TabStop = true;
            this.lnkFutsal.Text = "FUTSAL";
            this.lnkFutsal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridDeportes
            // 
            this.dataGridDeportes.AccessibleDescription = "";
            this.dataGridDeportes.AccessibleName = "";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDeportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDeportes.Location = new System.Drawing.Point(12, 188);
            this.dataGridDeportes.Name = "dataGridDeportes";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridDeportes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridDeportes.RowTemplate.Height = 24;
            this.dataGridDeportes.Size = new System.Drawing.Size(1133, 479);
            this.dataGridDeportes.TabIndex = 12;
            this.dataGridDeportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeportes_CellContentClick);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.Location = new System.Drawing.Point(385, 22);
            this.lblIndicaciones.MinimumSize = new System.Drawing.Size(50, 35);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(659, 35);
            this.lblIndicaciones.TabIndex = 13;
            this.lblIndicaciones.Text = "Haga click en el deporte del cual desea visualizar resultados";
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPais.Location = new System.Drawing.Point(1223, 283);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 22);
            this.txtPais.TabIndex = 14;
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCompetencia.Location = new System.Drawing.Point(1222, 461);
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(100, 22);
            this.txtCompetencia.TabIndex = 15;
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTipo.Location = new System.Drawing.Point(1224, 372);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 16;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(1220, 254);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(142, 20);
            this.lblPais.TabIndex = 17;
            this.lblPais.Text = "Pais competencia";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(1219, 425);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(168, 20);
            this.lblCompetencia.TabIndex = 18;
            this.lblCompetencia.Text = "Nombre competencia";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(1221, 337);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(102, 20);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "Tipo deporte";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(1219, 197);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(124, 31);
            this.lblBusqueda.TabIndex = 20;
            this.lblBusqueda.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1224, 511);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 39);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lnkAutomovilismo
            // 
            this.lnkAutomovilismo.Image = ((System.Drawing.Image)(resources.GetObject("lnkAutomovilismo.Image")));
            this.lnkAutomovilismo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAutomovilismo.Location = new System.Drawing.Point(445, 57);
            this.lnkAutomovilismo.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkAutomovilismo.Name = "lnkAutomovilismo";
            this.lnkAutomovilismo.Size = new System.Drawing.Size(144, 115);
            this.lnkAutomovilismo.TabIndex = 22;
            this.lnkAutomovilismo.TabStop = true;
            this.lnkAutomovilismo.Text = "AUTOMOVILISMO";
            this.lnkAutomovilismo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lnkBoxeo
            // 
            this.lnkBoxeo.Image = ((System.Drawing.Image)(resources.GetObject("lnkBoxeo.Image")));
            this.lnkBoxeo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkBoxeo.Location = new System.Drawing.Point(563, 56);
            this.lnkBoxeo.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkBoxeo.Name = "lnkBoxeo";
            this.lnkBoxeo.Size = new System.Drawing.Size(144, 115);
            this.lnkBoxeo.TabIndex = 23;
            this.lnkBoxeo.TabStop = true;
            this.lnkBoxeo.Text = "BOXEO";
            this.lnkBoxeo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lnkRugby
            // 
            this.lnkRugby.Image = ((System.Drawing.Image)(resources.GetObject("lnkRugby.Image")));
            this.lnkRugby.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRugby.Location = new System.Drawing.Point(678, 57);
            this.lnkRugby.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkRugby.Name = "lnkRugby";
            this.lnkRugby.Size = new System.Drawing.Size(124, 117);
            this.lnkRugby.TabIndex = 24;
            this.lnkRugby.TabStop = true;
            this.lnkRugby.Text = "RUGBY";
            this.lnkRugby.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lnkAtletismo
            // 
            this.lnkAtletismo.Image = ((System.Drawing.Image)(resources.GetObject("lnkAtletismo.Image")));
            this.lnkAtletismo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkAtletismo.Location = new System.Drawing.Point(791, 57);
            this.lnkAtletismo.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkAtletismo.Name = "lnkAtletismo";
            this.lnkAtletismo.Size = new System.Drawing.Size(122, 117);
            this.lnkAtletismo.TabIndex = 25;
            this.lnkAtletismo.TabStop = true;
            this.lnkAtletismo.Text = "ATLETISMO";
            this.lnkAtletismo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lnkHandball
            // 
            this.lnkHandball.Image = ((System.Drawing.Image)(resources.GetObject("lnkHandball.Image")));
            this.lnkHandball.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkHandball.Location = new System.Drawing.Point(911, 56);
            this.lnkHandball.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkHandball.Name = "lnkHandball";
            this.lnkHandball.Size = new System.Drawing.Size(122, 117);
            this.lnkHandball.TabIndex = 26;
            this.lnkHandball.TabStop = true;
            this.lnkHandball.Text = "HANDBALL";
            this.lnkHandball.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lnkMMA
            // 
            this.lnkMMA.Image = ((System.Drawing.Image)(resources.GetObject("lnkMMA.Image")));
            this.lnkMMA.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMMA.Location = new System.Drawing.Point(1027, 53);
            this.lnkMMA.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkMMA.Name = "lnkMMA";
            this.lnkMMA.Size = new System.Drawing.Size(122, 117);
            this.lnkMMA.TabIndex = 27;
            this.lnkMMA.TabStop = true;
            this.lnkMMA.Text = "MMA";
            this.lnkMMA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1432, 699);
            this.Controls.Add(this.lnkMMA);
            this.Controls.Add(this.lnkHandball);
            this.Controls.Add(this.lnkAtletismo);
            this.Controls.Add(this.lnkRugby);
            this.Controls.Add(this.lnkBoxeo);
            this.Controls.Add(this.lnkAutomovilismo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCompetencia);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.dataGridDeportes);
            this.Controls.Add(this.lnkFutsal);
            this.Controls.Add(this.lnkTenis);
            this.Controls.Add(this.lnkBasquet);
            this.Controls.Add(this.lnkFutbol);
            this.Name = "Eventos";
            this.Text = "Principal Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportes)).EndInit();
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
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCompetencia;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.LinkLabel lnkAutomovilismo;
        private System.Windows.Forms.LinkLabel lnkBoxeo;
        private System.Windows.Forms.LinkLabel lnkRugby;
        private System.Windows.Forms.LinkLabel lnkAtletismo;
        private System.Windows.Forms.LinkLabel lnkHandball;
        private System.Windows.Forms.LinkLabel lnkMMA;
    }
}