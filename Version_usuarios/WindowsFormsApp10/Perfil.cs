using System;
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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        


        private void Perfil_Load(object sender, EventArgs e)
        {
            if (Program.rol == 4)
            {
                btnSuscripción.Visible = false;
            }
            string usuarioJson;
            ApiAtenticacion api = new ApiAtenticacion();
            Usuario u = new Usuario();
            u.nombreUsuario = Program.nombreUsuario;
           try
            {
                usuarioJson = api.MostarDatos(u.nombreUsuario,Program.conexion);
            }
            catch 
            {

                MessageBox.Show("Error al cargar los datos");
                return;
            }
            
             u= JsonSerializer.Deserialize<Usuario>(usuarioJson);
            txtApellido.Text = u.apellido;
            txtEmail.Text = u.email;
            txtUsuario.Text = Program.nombreUsuario;
            txtNombre.Text = u.nombre;

            txtUsuario.Enabled = false;
            txtContraseña.Visible = false;
      
        }

        private void btnSuscripción_Click(object sender, EventArgs e)
        {
            Usuario_Pago nuevoUsuarioPago = new Usuario_Pago();
            nuevoUsuarioPago.conexion = Program.conexion;
            nuevoUsuarioPago.nombreUsuario = txtUsuario.Text;
            MessageBox.Show(nuevoUsuarioPago.nombreUsuario);
           switch (nuevoUsuarioPago.guardarSolicitudProvisoria())
            {
                case 0:
                    MessageBox.Show("solicitud enviada con exito");
                    btnSuscripción.Enabled = false;
                    break;

                case 1:

                    MessageBox.Show("conexion cerrada");
                    break;

                case 2:

                    MessageBox.Show("error al enviar la solicitud");

                    break;

            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = respuesta = MessageBox.Show("Seguro desea modificar?  ", "Modificar", MessageBoxButtons.YesNoCancel);
            if (respuesta == DialogResult.Yes)
            {
                Usuario U = new Usuario();
                U.conexion = Program.conexion;
                U.nombre = txtNombre.Text;
                U.nombreUsuario = txtUsuario.Text;
                U.apellido = txtApellido.Text;
                U.email = txtEmail.Text;


                switch (U.Modificar())
                {
                    case 0:
                        MessageBox.Show("datos modificados con exito");
                        break;
                    case 1:
                        MessageBox.Show("Perdida de conexion");
                        break;
                    case 2:
                        MessageBox.Show("No se pudo modificar");
                        break;

                }




            }
                
            
           
            

            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {

        }
    }
}