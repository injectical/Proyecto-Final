﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Banners_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string ruta;
            byte cantidad;
            Propaganda propaganda = new Propaganda();
            propaganda.obtenerRuta();
            ruta = propaganda.Ruta;
            //propaganda.Cantidad_de_banners = Convert.ToByte(frmGestionDePropaganda.txtcantidad.Text);
            Random random = new Random();
            int img = random.Next(1, 5);
           //Program.mostrarImagen(@"C: \Users\fabio\OneDrive\Escritorio\Propaganda\img\" + img + ".jpg");
        }

        private void pcb1_Click(object sender, EventArgs e)
        {

        }
    }
}
