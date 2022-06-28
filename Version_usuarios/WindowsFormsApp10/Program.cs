using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    static class Program
    {

        public static Principal frmPrincipal;
        public static Login frmLogin;
        public static Perfil frmPerfil;
        public static Eventos frmEventos;
        public static Registro frmRegistro;
        public static string nombreUsuario;

        //public static Clientes frmClientes;

        public static ADODB.Connection conexion = new ADODB.Connection();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }

        public static void doyPermisos(string usuario)
        {
            byte rol = 0;
            object contFilas;
            frmPrincipal.btnEventos.Enabled = false;
            frmPrincipal.menuGestion.Enabled = false;
            frmPrincipal.pbLogin.Enabled = false;


            string sql; //
            ADODB.Recordset rs; //objeto clase recordset


            if (conexion.State == 0)
            {
                frmPrincipal.pbLogin.Enabled = true;
            }
            else
            {

                sql = "select rol from usuarios where usuario ='" + usuario + "';";

                try
                {
                    rs = conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    MessageBox.Show("error al obtener rol de usuario");
                    return;

                }

                if (rs.RecordCount > 0)
                {
                    rol = Convert.ToByte(rs.Fields[0].Value);//convierte lo que reciba a el tipo de dato byte, y lo asignamos a la variable rol

                    //AVERIGUA SI LA SESIÓN ESTA ABIERTA Y CUÁL ES EL ROL DEL USUARIO
                    if (rol == 2) {

                        frmPrincipal.btnEventos.Enabled = true;
                        frmPrincipal.menuGestion.Enabled = true;
                        frmPrincipal.menuLogout.Enabled = true;

                    }

                    rs = null;
                    contFilas = null;

                }

            }
        }

        public static void cargarFormularioUsuario(string usuario)
        {
            string sqlNombre;
            string sqlApellido;
            string sqlEmail;
            string sqlMiembro;
            //SEGUN EL NOMBRE (NOMBRE DE USUARIO) TE TRAE LOS OTROS DATOS
            sqlNombre = "select Nombre from Usuarios where Nombre = '" + usuario + "';";
            frmPerfil.txtNombre.Text = sqlNombre;
            sqlApellido = "select Apellido from Usuarios where Nombre = '" + usuario + "';";
            frmPerfil.txtApellido.Text = sqlApellido;
            sqlEmail = "select Email from Usuarios where Nombre = '" + usuario + "';";
            frmPerfil.txtEmail.Text = sqlEmail;
            sqlMiembro = "select Miembro from Usuarios where Nombre = '" + usuario + "';";
            frmPerfil.txtMiembro.Text = sqlMiembro;
        }
        
        }

}
