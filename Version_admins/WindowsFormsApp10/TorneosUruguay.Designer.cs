namespace WindowsFormsApp10
{
    partial class Uruguay
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
            this.gbBásquetbol = new System.Windows.Forms.GroupBox();
            this.gbRugby = new System.Windows.Forms.GroupBox();
            this.gbFutbol = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbBásquetbol
            // 
            this.gbBásquetbol.Location = new System.Drawing.Point(290, 27);
            this.gbBásquetbol.Name = "gbBásquetbol";
            this.gbBásquetbol.Size = new System.Drawing.Size(200, 253);
            this.gbBásquetbol.TabIndex = 1;
            this.gbBásquetbol.TabStop = false;
            this.gbBásquetbol.Text = "Básquetbol";
            // 
            // gbRugby
            // 
            this.gbRugby.Location = new System.Drawing.Point(558, 27);
            this.gbRugby.Name = "gbRugby";
            this.gbRugby.Size = new System.Drawing.Size(200, 253);
            this.gbRugby.TabIndex = 2;
            this.gbRugby.TabStop = false;
            this.gbRugby.Text = "Rugby";
            // 
            // gbFutbol
            // 
            this.gbFutbol.Location = new System.Drawing.Point(49, 27);
            this.gbFutbol.Name = "gbFutbol";
            this.gbFutbol.Size = new System.Drawing.Size(182, 253);
            this.gbFutbol.TabIndex = 0;
            this.gbFutbol.TabStop = false;
            this.gbFutbol.Text = "Fútbol";
            // 
            // Uruguay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.gbBásquetbol);
            this.Controls.Add(this.gbRugby);
            this.Controls.Add(this.gbFutbol);
            this.Name = "Uruguay";
            this.Text = "Torneos de Uruguay";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBásquetbol;
        private System.Windows.Forms.GroupBox gbRugby;
        private System.Windows.Forms.GroupBox gbFutbol;
    }
}