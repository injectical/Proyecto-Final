using System;
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
            menuStripGestionDetalles.Enabled = false;
           // Program.frmPrincipal.pcbImagen.Visible = false;





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (Program.conexion.State == 1)
            {
                Program.conexion.Close();
            }
            
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
            if (Program.frmgestionEventos != null)
            {
                Program.frmgestionEventos.Close();
            }
            if (Program.frmgestionDedetalles!=null)
            {
                Program.frmgestionDedetalles.Close();
            }
            if (Program.frmgestiondeusuarios != null)
            {
                Program.frmgestiondeusuarios.Close();
            }
            
            Program.frmgestionEventos = new GestionDeEventos();
            Program.frmgestionEventos.MdiParent = this;
            Program.frmgestionEventos.Show();
            
           

            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuGestionUsuarios_Click(object sender, EventArgs e)
        {
            if (Program.frmgestiondeusuarios != null)
            {
                Program.frmgestiondeusuarios.Close();
            }
            if (Program.frmEventos != null)
            {
                Program.frmEventos.Close();
            }
            if (Program.frmgestionDedetalles !=null) 
            {
                Program.frmgestionDedetalles.Close();
            }

            if (Program.frmgestionEventos != null)
            {
                Program.frmgestionEventos.Close();
            }
            Program.frmgestiondeusuarios = new GestionDeUsuarios();
            Program.frmgestiondeusuarios.MdiParent = this;
            Program.frmgestiondeusuarios.Show();
            
        }

        private void gestionDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void gestionDeDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.frmgestiondeusuarios != null)
            {
                Program.frmgestiondeusuarios.Close();
            }
            if (Program.frmEventos != null)
            {
                Program.frmEventos.Close();
            }
            if (Program.frmgestionDedetalles != null)
            {
                Program.frmgestionDedetalles.Close();
            }

            if (Program.frmgestionEventos != null)
            {
                Program.frmgestionEventos.Close();
            }

            Program.frmgestionDedetalles = new GestionDetalles();
            Program.frmgestionDedetalles.MdiParent = this;
            Program.frmgestionDedetalles.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
