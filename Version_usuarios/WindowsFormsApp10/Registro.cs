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

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.conexion.Open("miodbc","root"," ");
            object contFilas;
            Program.conexion.Execute("use proyecto", out contFilas);
            string nombreUsuario = txtUsuario.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string constraseña = txtContraseña.Text;
             //CON EL GRANT DESPUES EL USUARIO VA A PODER REGISTRARSE E INICIAR SESION
            string sql1 = "create user" + "'" + nombreUsuario + "'" + "@localhost identified by" + "'" + constraseña + "'";
            string sql2 = "grant select,insert, execute on *.* to" + "'" + nombreUsuario + "'" + "@localhost";
            string sql3 = "insert into usuario (nombre,apellido,email,contraseña,Nombre_Usuario) values (" + "'" + nombre + "'" + "," + "'" + apellido + "'" + "," + "'" + email + "'" + "," + "'" + constraseña + "'" + "," + "'" + nombreUsuario + "'" + ")";

            try
            {
                Program.conexion.Execute(sql1, out contFilas);
                Program.conexion.Execute(sql3, out contFilas);
                Program.conexion.Execute(sql2, out contFilas);



            }
            catch
            {
                MessageBox.Show("Los datos no fueron ingresados correctamente");
                Program.conexion.Close();

                return;
            }

            Program.conexion.Close();

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
