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
            Program.frmPrincipal.pbLogin.Visible = false;
            Program.conexion.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            Program.doyPermisos(txtNombre.Text);
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
