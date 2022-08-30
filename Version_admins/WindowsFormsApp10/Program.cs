using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
        public static GestionDeUsuarios frmgestiondeusuarios;


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
            byte rol = 0;
            object contFilas;
            frmPrincipal.menuEventos.Enabled = false;
            frmPrincipal.menuGestionUsuarios.Enabled = false;
         
          
            string sql; 
            ADODB.Recordset rs; //objeto clase recordset
                                

            if (conexion.State == 0)
            {
                frmPrincipal.pbLogin.Enabled = true;
            }
            else
            {
               // conexion.Execute("use sport360; ", out contFilas);
                sql = "select USUARIO.rol from USUARIO where nombre_clave= '"+usuario+"';";

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
                    //convierte lo que reciba a el tipo de dato byte, y lo asignamos a la variable rol
                    rol = Convert.ToByte(rs.Fields[0].Value);
                  

                    //AVERIGUA SI LA SESIÓN ESTA ABIERTA Y CUÁL ES EL ROL DEL USUARIO
                    if (rol == 2) { 
                    
                       
                            frmPrincipal.menuEventos.Enabled = true;
                            frmPrincipal.menuLogin.Enabled = true;
                      
                            //frmPrincipal.pcbImagen.Visible = true;



                    }

                    if (rol == 1) {
                        frmPrincipal.menuEventos.Enabled = true;
                        frmPrincipal.menuLogin.Enabled = true;
                        frmPrincipal.menuGestionUsuarios.Enabled = true;
                    }

                    rs = null;
                    contFilas = null;

                }
            
            }
        }
        //recibe una una consulta sql y la respuesta la adata a una tabla del tipo DateTable
        //para mostrar por pantalla hay que cargar el return de este metodo a una data gridview
        // de la sigiente manera dataGridView1.DataSource=dt;
        public static DataTable listarUsuarios(string sql) {

          object contFilas;

            ADODB.Recordset rs;
            rs = Program.conexion.Execute(sql, out contFilas);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
            adapter.Fill(dt, rs);
            return dt;
           
        }
        //metodo para controlar que se llenen todos los campos obligatorios
        public static bool ControlCampos(string var) {
            bool validar;

            if (var.Equals(""))
            {
                validar = true;
            }
            else {
                validar = false;
            }

            return validar;
        }

        public static void LimpiarCampos() {
            frmgestiondeusuarios.txtid.Clear();
            frmgestiondeusuarios.txtNombre.Clear();
            frmgestiondeusuarios.txtid.Clear();
            frmgestiondeusuarios.txtApellido.Clear();
            frmgestiondeusuarios.txtcorreo.Clear();
            frmgestiondeusuarios.txtNombreDeUSuarioClave.Clear();


        }
    }
}