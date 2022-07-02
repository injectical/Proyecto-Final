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
        public static GestionDeEventos frmgestionEventos;

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
            Application.Run(frmPrincipal=new Principal());
        }

        public static void doyPermisos(string usuario)
        {
            object contFilas;
            frmPrincipal.menuEventos.Enabled = false;
            frmPrincipal.menuGestionUsuarios.Enabled = false;
         
          
            string sql; //
            ADODB.Recordset rs; //objeto clase recordset
                            
            if (conexion.State == 0)
            {
                frmPrincipal.pbLogin.Enabled = true;
            }
            else
            {

                sql = "select rol from parametros where usuario ='" + usuario + "';";

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

                    //AVERIGUA SI LA SESIÓN ESTA ABIERTA Y CUÁL ES EL ROL DEL USUARIO
                    
                       
                            frmPrincipal.menuEventos.Enabled = true;
                            frmPrincipal.menuLogin.Enabled = true;

                          

                    }

                    rs = null;
                    contFilas = null;

                }
            
            }
        }
    }
