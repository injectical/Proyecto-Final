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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        //LOS ESTILOS VISUALES DE LAS VENTANAS SE IRAN PULIENDO, SE MUESTRA UN DISEÑO TENTATIVO
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Program.frmLogin = new Login();
            Program.frmLogin.MdiParent = this;
            Program.frmLogin.Show();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            menuEventos.Enabled = false;
            menuGestionUsuarios.Enabled = false;
           // Program.frmPrincipal.pcbImagen.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void lnkEventos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void menuEventos_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmgestionEventos = new GestionDeEventos();
            Program.frmgestionEventos.MdiParent = this;
            Program.frmgestionEventos.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmEventos = new Eventos();
            Program.frmEventos.Show();
        }
    }
}
