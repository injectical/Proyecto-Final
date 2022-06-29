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
        public static Eventos frmEventos;
        public static Uruguay frmUruguay;

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
            frmPrincipal.menuEventos.Enabled = false;
            frmPrincipal.menuGestionUsuarios.Enabled = false;
            frmPrincipal.pbLogin.Enabled = false;
            frmPrincipal.lnkEventos.Enabled = false;
          
            string sql; //
            ADODB.Recordset rs; //objeto clase recordset
                                //frmPrincipal.menuAplicaciones.Enabled = false;
                                //frmPrincipal.menuClientes.Enabled = false;

            if (conexion.State == 0)
            {
                frmPrincipal.pbLogin.Enabled = true;
            }
            else
            {

                sql = "select rol from administradores where usuario ='" + usuario + "';";

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
                    if (rol == 1) { 
                    
                       
                            frmPrincipal.menuEventos.Enabled = true;
                            frmPrincipal.menuGestionUsuarios.Enabled = true;
                            frmPrincipal.lnkEventos.Enabled = true;
                          

                    }

                    rs = null;
                    contFilas = null;

                }
            
            }
        }
    }
}