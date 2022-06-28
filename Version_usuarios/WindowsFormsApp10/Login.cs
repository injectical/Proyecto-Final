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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                //ABRIMOS LA CONEXIÓN CON LA BD CON USUARIO Y CONTRASEÑA
                Program.conexion.Open("miodbc", txtNombre.Text, txtContraseña.Text);
            }
            catch
            {
                MessageBox.Show("usuario o contraseña incorrectos");
                return;
            }
            Program.conexion.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            Program.doyPermisos(txtNombre.Text);
            Program.nombreUsuario = txtNombre.Text;//CARGA EN UNA VARIABLE PUBLICA EL NOMBRE DE USUARIO
            this.Close();
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Program.frmRegistro = new Registro();
            Program.frmRegistro.Show();
        }
    }
}
