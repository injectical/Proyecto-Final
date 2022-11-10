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
            Program.frmLogin.MdiParent = this;
            if (Program.frmPrincipal.menuGestion.Text.Equals("User Management"))
            {
                Program.frmLogin.lblContraseña.Text = ResIngles.Login_contrasenia;
                Program.frmLogin.lblUsuario.Text = ResIngles.Login_nombreUsuario;
                Program.frmLogin.btnIngresar.Text = ResIngles.Login_btnAceptar;
                Program.frmLogin.btnCancelar.Text = ResIngles.login_btncancelar;
                Program.frmLogin.lnkRegistro.Text = ResIngles.login_irAregistro;
            }
           
        }

        public void Principal_Load(object sender, EventArgs e)
        {
            btnEventos.Enabled = false;
            menuGestion.Enabled = false;
            menuLogout.Enabled = false;
            btnEventos.Visible = false;
           

            // MessageBox.Show("Inicie sesión para usar la aplicación");

        }



        private void menuLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


                if (Program.frmEventos !=null)
            {
                Program.frmEventos.Close();
            }
            if (Program.frmNotificacion !=null)
            {
                Program.frmNotificacion.Close();
            }
            if (Program.frmPerfil != null)
            {
                Program.frmPerfil.Close();
            }

            //Program.frmPerfil.Close();

            if (Program.rol == 3)
            {
                Program.frmBanners = new Banners();
                Program.frmBanners.Show();
                Program.frmBanners.MdiParent = Program.frmPrincipal;
            }
            Program.frmPerfil = new Perfil();
            Program.frmPerfil.Show();
            Program.frmPerfil.MdiParent = this;
            if (Program.frmPrincipal.menuGestion.Text.Equals("User Management"))
            {
                Program.frmPerfil.lblApellido.Text = ResIngles.Perfil_nombre;
                Program.frmPerfil.lblNombre.Text = ResIngles.Perfil_nombre;
                Program.frmPerfil.lblUsuario.Text = ResIngles.Perfil_nombreUsuario;
                Program.frmPerfil.btnAplicar.Text = ResIngles.Perfi_btnAceptar;
                Program.frmPerfil.btnDescartar.Text = ResIngles.Perfil_btnDescartar;
            }

        }

      

        private void btnEventos_Click(object sender, EventArgs e)
        {
            
                if (Program.frmEventos != null)
            {
                Program.frmEventos.Close();
            }
            if (Program.frmNotificacion != null)
            {
                Program.frmNotificacion.Close();
            }
            if (Program.frmPerfil != null)
            {
                Program.frmPerfil.Close();
            }

            Program.frmEventos = new btnFinalizados();
            Program.frmEventos.Show();
            Program.frmEventos.MdiParent = this;
            if (Program.frmPrincipal.menuGestion.Text.Equals("User Management"))
            {
                Program.frmEventos.btnBuscar.Text = ResIngles.Evento_btnFinalizados;
                Program.frmEventos.btnEnProceso.Text = ResIngles.Evento_btnEnProceso;
                Program.frmEventos.btnPorComenzar.Text = ResIngles.Evento_btnPorcomenzar;
                Program.frmEventos.btnSuscripcion.Text = ResIngles.Login_btnAceptar;
                Program.frmEventos.grbDetalles.Text = ResIngles.Evento_grbDetalles;
                Program.frmEventos.grbSuscripcion.Text = ResIngles.Evento_grbSuscripcion;
                Program.frmEventos.groupBox2.Text = ResIngles.Evento_grbEvento;
            }
            if (Program.rol == 3)
            {
                Program.frmBanners = new Banners();
                Program.frmBanners.Show();
                Program.frmBanners.MdiParent = this;
            }
        }

        private void menuNotificaciones_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblInicioSesion_Click(object sender, EventArgs e)
        {

        }

        private void verPagisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuGestion_Click(object sender, EventArgs e)
        {
            if (Program.rol == 3)
            {
                Program.frmBanners = new Banners();
                Program.frmBanners.Show();
                Program.frmBanners.MdiParent = this;
            }
        }

        private void espaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.GetTextEs();
        }

        private void MenuIn_Click(object sender, EventArgs e)
        {
            Program.GetTextIngles();
        }
    }
}
