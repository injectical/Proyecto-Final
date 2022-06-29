namespace WindowsFormsApp10
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbBásquetbol
            // 
            this.gbBásquetbol.Location = new System.Drawing.Point(290, 54);
            this.gbBásquetbol.Name = "gbBásquetbol";
            this.gbBásquetbol.Size = new System.Drawing.Size(200, 253);
            this.gbBásquetbol.TabIndex = 4;
            this.gbBásquetbol.TabStop = false;
            this.gbBásquetbol.Text = "Básquetbol";
            // 
            // gbRugby
            // 
            this.gbRugby.Location = new System.Drawing.Point(558, 54);
            this.gbRugby.Name = "gbRugby";
            this.gbRugby.Size = new System.Drawing.Size(200, 253);
            this.gbRugby.TabIndex = 5;
            this.gbRugby.TabStop = false;
            this.gbRugby.Text = "Rugby";
            // 
            // gbFutbol
            // 
            this.gbFutbol.Location = new System.Drawing.Point(49, 54);
            this.gbFutbol.Name = "gbFutbol";
            this.gbFutbol.Size = new System.Drawing.Size(182, 253);
            this.gbFutbol.TabIndex = 3;
            this.gbFutbol.TabStop = false;
            this.gbFutbol.Text = "Fútbol";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(290, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Handball";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(558, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 253);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automovilismo";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(49, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 253);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tenis";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbBásquetbol);
            this.Controls.Add(this.gbRugby);
            this.Controls.Add(this.gbFutbol);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBásquetbol;
        private System.Windows.Forms.GroupBox gbRugby;
        private System.Windows.Forms.GroupBox gbFutbol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}