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
            byte Campos=4;
                Usuario_Provisorio usuario = new Usuario_Provisorio();

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("falta ingresar  nombre");
                Campos -= 1;
            }
           
            if (txtEmail.Text.Equals(" "))
            {
                MessageBox.Show("falta ingresar email");
                Campos -= 1;
            }
           
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("falta ingresar usuario");
                Campos -= 1;
            }
           

            if (txtContraseña.Text.Equals(""))
            {

                MessageBox.Show("falta ingresar Contraseña");
                Campos -= 1;
            }
                         
                              
                if(Campos==4)
                {
                    usuario.nombre = txtNombre.Text;
                    usuario.email = txtEmail.Text;
                    usuario.nombreUsuario = txtUsuario.Text;
                    usuario.Pass = txtContraseña.Text;
                    usuario.apellido = txtApellido.Text;

                switch (usuario.ConsultarProvisorio())
                {
                    case 0:
                
                    switch (usuario.provisorioGuardar())
                    {
                        case 0:
                        MessageBox.Show("sus datos fueron ingresados correctamente");

                        break;
                        case 1:

                        MessageBox.Show("Conexion cerrada");

                        break;

                        case 2:

                        MessageBox.Show("No se ha podido registrar");

                        break;

                        case 3:

                        MessageBox.Show("Ha ocurrido un error al verificar");

                        break;

                        case 4:

                        MessageBox.Show("El nombre de usuario ya existe");

                        break;
                

                    }
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("error al consultar tabla de usuario provisorio");
                        break;
                    case 3:
                        MessageBox.Show("El usuario ya existe ");
                        
                        break;

                }
                limpiarFormulario();
            }
            
            
        }

        private void limpiarFormulario()
        {
            txtApellido.Clear();
            txtContraseña.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
