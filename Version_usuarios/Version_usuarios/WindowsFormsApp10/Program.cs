using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using System.Data;
using System.Data.OleDb;


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
            Application.Run(frmPrincipal = new Principal());
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
                sql = "select nombre_clave from usuario where nombre_clave ='" +usuario+ "';";
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
                    frmPrincipal.pbLogin.Visible = false;
                    frmPrincipal.lblInicioSesion.Visible = false;
                    nombreUsuario = usuario;
                    frmPrincipal.lblSaludo.Text = "Bienvenido " + usuario;




                    rs = null;
                    contFilas = null;


                }

            }
        }

        //PARA TAER DATOS Y PODER VERLOS
        
      
        

        public static void cargarFormularioUsuario(string usuario)
        {
            string sqlSentencia;
            string sqlNombre;
            string sqlApellido;
            string sqlEmail;
            string sqlUsuario;
            ADODB.Recordset rs;
            object contfilas;
            //SEGUN EL NOMBRE (NOMBRE DE USUARIO) TE TRAE LOS OTROS DATOS
            sqlSentencia = "select nombre,apellido,email,nombre_clave from usuario where nombre_clave  = '" + usuario + "';";
            rs = conexion.Execute(sqlSentencia, out contfilas);
            sqlNombre = Convert.ToString(rs.Fields[0].Value);
            frmPerfil.txtNombre.Text = sqlNombre;
            rs = conexion.Execute(sqlSentencia, out contfilas);
            sqlApellido = Convert.ToString(rs.Fields[1].Value);
            frmPerfil.txtApellido.Text = sqlApellido;
            rs = conexion.Execute(sqlSentencia, out contfilas);
            sqlEmail = Convert.ToString(rs.Fields[2].Value);
            frmPerfil.txtEmail.Text = sqlEmail;
            rs = conexion.Execute(sqlSentencia, out contfilas);
            sqlUsuario = Convert.ToString(rs.Fields[3].Value);
            frmPerfil.txtUsuario.Text = sqlUsuario;
        }



        public static void limpiarUsuario()
        {
            frmRegistro.txtApellido.Clear();
            frmRegistro.txtNombre.Clear();
            frmRegistro.txtContraseña.Clear();
            frmRegistro.txtUsuario.Clear();
            frmRegistro.txtEmail.Clear();

           
        }
    }

}
