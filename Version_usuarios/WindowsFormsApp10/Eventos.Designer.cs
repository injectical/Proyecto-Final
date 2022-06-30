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
            this.lnkFutbol = new System.Windows.Forms.LinkLabel();
            this.lnkBasquet = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDeportes)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkFutbol
            // 
            this.lnkFutbol.Image = ((System.Drawing.Image)(resources.GetObject("lnkFutbol.Image")));
            this.lnkFutbol.LinkArea = new System.Windows.Forms.LinkArea(0, 70);
            this.lnkFutbol.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkFutbol.Location = new System.Drawing.Point(59, 56);
            this.lnkFutbol.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkFutbol.Name = "lnkFutbol";
            this.lnkFutbol.Size = new System.Drawing.Size(95, 120);
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
            this.lnkBasquet.Location = new System.Drawing.Point(251, 56);
            this.lnkBasquet.MinimumSize = new System.Drawing.Size(70, 70);
            this.lnkBasquet.Name = "lnkBasquet";
            this.lnkBasquet.Size = new System.Drawing.Size(104, 115);
            this.lnkBasquet.TabIndex = 1;
            this.lnkBasquet.TabStop = true;
            this.lnkBasquet.Text = "BASQUET";
            this.lnkBasquet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkBasquet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBasquet_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(476, 56);
            this.linkLabel2.MinimumSize = new System.Drawing.Size(70, 70);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 115);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "TENIS";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel4.Image")));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.Location = new System.Drawing.Point(667, 56);
            this.linkLabel4.MinimumSize = new System.Drawing.Size(70, 70);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(138, 115);
            this.linkLabel4.TabIndex = 7;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "FUTSAL";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.dataGridDeportes.RowTemplate.Height = 24;
            this.dataGridDeportes.Size = new System.Drawing.Size(850, 479);
            this.dataGridDeportes.TabIndex = 12;
            this.dataGridDeportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDeportes_CellContentClick);
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicaciones.Location = new System.Drawing.Point(109, 25);
            this.lblIndicaciones.MinimumSize = new System.Drawing.Size(50, 35);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(659, 35);
            this.lblIndicaciones.TabIndex = 13;
            this.lblIndicaciones.Text = "Haga click en el deporte del cual desea visualizar resultados";
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPais.Location = new System.Drawing.Point(890, 208);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 22);
            this.txtPais.TabIndex = 14;
            // 
            // txtCompetencia
            // 
            this.txtCompetencia.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCompetencia.Location = new System.Drawing.Point(889, 386);
            this.txtCompetencia.Name = "txtCompetencia";
            this.txtCompetencia.Size = new System.Drawing.Size(100, 22);
            this.txtCompetencia.TabIndex = 15;
            this.txtCompetencia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTipo.Location = new System.Drawing.Point(891, 297);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 16;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(887, 179);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(142, 20);
            this.lblPais.TabIndex = 17;
            this.lblPais.Text = "Pais competencia";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(886, 350);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(168, 20);
            this.lblCompetencia.TabIndex = 18;
            this.lblCompetencia.Text = "Nombre competencia";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(888, 262);
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
            this.lblBusqueda.Location = new System.Drawing.Point(886, 122);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(124, 31);
            this.lblBusqueda.TabIndex = 20;
            this.lblBusqueda.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(891, 436);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 39);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1072, 699);
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
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel2);
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
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel4;
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
    }
}