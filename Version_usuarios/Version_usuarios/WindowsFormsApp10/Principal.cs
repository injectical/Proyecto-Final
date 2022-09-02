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

        private void pbLogin_Click(object sender, EventArgs e)
        {

            Program.frmLogin = new Login();
            Program.frmLogin.Show();
        }

        public void Principal_Load(object sender, EventArgs e)
        {
            btnEventos.Enabled = false;
            menuGestion.Enabled = false;
            menuLogout.Enabled = false;
           
            MessageBox.Show("Inicie sesión para usar la aplicación");

        }



        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.frmPerfil = new Perfil();
            Program.frmPerfil.Show();
            
        }

      

        private void btnEventos_Click(object sender, EventArgs e)
        {
            
            Program.frmEventos = new Eventos();
            Program.frmEventos.Show();
        }

        private void menuNotificaciones_Click_1(object sender, EventArgs e)
        {
            Program.frmNotificaciones = new Notificaciones();
            Program.frmNotificaciones.Show();
        }
    }
}
