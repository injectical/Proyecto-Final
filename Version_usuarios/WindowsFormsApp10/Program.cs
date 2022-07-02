using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;

namespace WindowsFormsApp10
{
  class Program
    {

        public static Principal frmPrincipal;
        public static Login frmLogin;
        public static Perfil frmPerfil;
        public static Eventos frmEventos;
        public static Registro frmRegistro;
        public static Notificaciones frmNotificaciones;
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
                //CAMBIAR DE ACUERDO AL CRITERIO QUE SE MANEJA EN LA TABLA DEL USUARIO
                sql = "select nombre from usuario where email  ='" + usuario + "';";

                try
                {
                    rs = conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    MessageBox.Show("error al obtener el nombre del usuario");
                    return;

                }

                if (rs.RecordCount > 0)
                {

                    //AVERIGUA SI LA SESIÓN ESTA ABIERTA
                  
                        frmPrincipal.btnEventos.Enabled = true;
                        frmPrincipal.menuGestion.Enabled = true;
                        frmPrincipal.menuLogout.Enabled = true;
                        frmPrincipal.lblSaludo.Text = "Bienvenido" + Program.nombreUsuario;



                    rs = null;
                    contFilas = null;

                }

            }
        }


       


       /* public static void cargarFormularioUsuario(string usuario)
        {
            string sqlNombre;
            string sqlApellido;
            string sqlEmail;
            string sqlMiembro;
            ADODB.Recordset rs;
            object contfilas;
            //SEGUN EL NOMBRE (NOMBRE DE USUARIO) TE TRAE LOS OTROS DATOS
            sqlNombre = "select Nombre from Usuarios where Nombre = '" + usuario + "';";
            rs = conexion.Execute(sqlNombre, out contfilas);
            sqlNombre = Convert.ToString(rs.Fields[0].Value);
            frmPerfil.txtNombre.Text = sqlNombre;
            sqlApellido = "select Apellido from Usuarios where Nombre = '" + usuario + "';";
            frmPerfil.txtApellido.Text = sqlApellido;
            sqlEmail = "select Email from Usuarios where Nombre = '" + usuario + "';";
            frmPerfil.txtEmail.Text = sqlEmail;
            sqlMiembro = "select Miembro from Usuarios where Nombre = '" + usuario + "';";
            frmPerfil.txtMiembro.Text = sqlMiembro;
        }
        */
        }

}
