﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Banners : Form

          {

        

        public Banners()
        {
            InitializeComponent();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int img = random.Next(1, 5);
            ApiBanners apiBanners = new ApiBanners();
            Banner B = new Banner();
            B = JsonSerializer.Deserialize<Banner>(apiBanners.SerializarBanners());
            string ruta = B.ruta;
            Program.mostrarImagen(@ruta + @"\" + img + ".jpg");
                   

            
        }

        private void Banners_Load(object sender, EventArgs e)
        {

        }
    }
}
