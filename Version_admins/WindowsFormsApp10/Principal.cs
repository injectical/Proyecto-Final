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
            //Program.frmLogin.MdiParent = this;
            Program.frmLogin.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            menuEventos.Enabled = true;
            menuGestionUsuarios.Enabled = true;
            menuLogin.Enabled = true;
            lnkEventos.Enabled = true;


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
            Program.frmEventos = new Eventos();
            Program.frmEventos.Show();
        }
    }
}
