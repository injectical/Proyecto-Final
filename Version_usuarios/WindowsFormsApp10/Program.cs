using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using System.Data;
using System.Data.OleDb;
using System.Drawing;

namespace WindowsFormsApp10
{
    class Program
    {

        public static Principal frmPrincipal;
        public static Banners frmBanners;
        public static Login frmLogin;
        public static Perfil frmPerfil;
        public static btnFinalizados frmEventos;
        public static Registro frmRegistro;
        public static Notificaciones frmNotificacion;
      
        public static string nombreUsuario;
        public static Usuario usuario;
        public static int rol;
        public static int id;

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
                sql = "select rol,id_usuario from usuario where nombre_clave ='" +usuario+ "';";
                try
                {
                    rs = conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    MessageBox.Show("error al obtener el rol del usuario");
                    return;

                }

                if (rs.RecordCount > 0)
                {
                    int.TryParse(rs.Fields[0].Value, out rol);

                    int.TryParse(rs.Fields[1].Value.ToString(), out id);



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
        
       
        

       /* public static void cargarFormularioUsuario(string usuario)
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
        }/*/



        public static void limpiarUsuario()
        {
            frmRegistro.txtApellido.Clear();
            frmRegistro.txtNombre.Clear();
            frmRegistro.txtContraseña.Clear();
            frmRegistro.txtUsuario.Clear();
            frmRegistro.txtEmail.Clear();

           
        }

        public static void mostrarImagen(string ruta)
        {



            frmBanners.pic1.Image = Image.FromFile(ruta);

        }
        /* public static DataTable eventosPorPais()
         {
             Evento nuevo = new Evento();
             nuevo.pais = frmEventos.txtPais.Text;
             return nuevo.Buscar();

         }*/

        public static void  GetTextEs()
        {
            frmPrincipal.menuGestion.Text = ResEs1.Gestion_de_usuario;
            frmPrincipal.modificarPerfilToolStripMenuItem.Text = ResEs1.Modificar_perfil;
            frmPrincipal.btnEventos.Text = ResEs1.btn_eventos;
            frmPrincipal.MenuIdioma.Text = ResEs1.idioma;
            /*frmPerfil.lblUsuario.Text = ResEs1.Perfil_NombreUsuario;
            frmPerfil.lblNombre.Text = ResEs1.Perfil_Nombre;
            frmPerfil.lblApellido.Text = ResEs1.Perfil_Apellido;
            frmPerfil.label1.Text = ResEs1.Perfil_Contraseña;
            frmRegistro.lblNombreUsuario.Text = ResEs1.Registro_Nombre_Usuario;
            frmRegistro.lblNombre.Text = ResEs1.Registro_nombre;
            frmRegistro.lblApellido.Text = ResEs1.Registro_apellido;
            frmRegistro.lblContraseña.Text = ResEs1.Registro_contrasenia;
            frmRegistro.btnEnviar.Text = ResEs1.Registro_btnenviar;
            frmRegistro.btnBorrar.Text = ResEs1.Registro_btnBorrar;
            frmEventos.btnBuscar.Text = ResEs1.Finalizados;
            frmEventos.btnEnProceso.Text = ResEs1.Evento_en_btnproceso;
            frmEventos.btnPorComenzar.Text = ResEs1.Evento_btn_Por_comenzar;
            frmEventos.btnSuscripcion.Text = ResEs1.Evento_btnAceptar;
            frmEventos.grbDetalles.Text = ResEs1.grbDetalles;
            frmEventos.grbSuscripcion.Text = ResEs1.grbSuscripcion;
            frmEventos.groupBox2.Text = ResEs1.grbEventos;//grup box de eventos
            frmLogin.lblUsuario.Text = ResEs1.Login_lblNombreUser;
            frmLogin.lblContraseña.Text = ResEs1.Login_lblContraseña;
            frmLogin.btnIngresar.Text = ResEs1.login_btnIngresar;
            frmLogin.btnCancelar.Text = ResEs1.Login_cancelar;
            frmLogin.lnkRegistro.Text = ResEs1.Login_registroDeUsuario;*/

        }

        public static void GetTextIngles()
        {
            frmPrincipal.menuGestion.Text = ResIngles.Principal_menuGestioDeUsuario;
            frmPrincipal.modificarPerfilToolStripMenuItem.Text = ResIngles.Principal_menuModificarPerfil;
            frmPrincipal.btnEventos.Text = ResIngles.Principal_btnIrAEventos;
            frmPrincipal.MenuIdioma.Text = ResIngles.Principal_MenuIdioma;
            
            /*frmLogin.lblContraseña.Text = ResIngles.Login_contrasenia;
            frmLogin.lblUsuario.Text = ResIngles.Login_nombreUsuario;
            frmLogin.btnIngresar.Text = ResIngles.Login_btnAceptar;
            frmLogin.btnCancelar.Text = ResIngles.login_btncancelar;
            frmLogin.lnkRegistro.Text = ResIngles.login_irAregistro;*/
           


        }

    }

}
