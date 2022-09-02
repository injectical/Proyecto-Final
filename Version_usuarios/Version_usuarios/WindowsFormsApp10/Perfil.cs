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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        


        private void Perfil_Load(object sender, EventArgs e)
        {
            Program.cargarFormularioUsuario(Program.nombreUsuario);
      
        }

        private void btnSuscripción_Click(object sender, EventArgs e)
        {
            Usuario_Pago nuevoUsuarioPago = new Usuario_Pago();

            nuevoUsuarioPago.nombreUsuario = txtUsuario.Text;
            nuevoUsuarioPago.guardarSolicitudProvisoria();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}