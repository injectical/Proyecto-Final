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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        

        private void lnkVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Program.frmLogin = new Login();
            Program.frmLogin.Show();
        }

     

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
          
                Usuario_Provisorio usuario = new Usuario_Provisorio();

                usuario.nombre = txtNombre.Text;
                usuario.apellido = txtApellido.Text;
                usuario.email = txtEmail.Text;
                usuario.nombreUsuario = txtUsuario.Text;
                usuario.contraseña = txtContraseña.Text;

                usuario.provisorioGuardar();
                limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            txtApellido.Clear();
            txtContraseña.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
        }

       

        
    }
}
