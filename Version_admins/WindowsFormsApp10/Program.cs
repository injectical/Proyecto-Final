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
        public static GestionDetalles frmgestionDedetalles;


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
                
                sql = "select rol from usuario where nombre_clave='"+usuario+"'; ";

                try
                {
                    conexion.Execute("use injectical; ", out contFilas);
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
                        frmPrincipal.menuStripGestionDetalles.Enabled = true;

                        //frmPrincipal.pcbImagen.Visible = true;



                    }

                    if (rol == 1) {
                        frmPrincipal.menuEventos.Enabled = true;
                        frmPrincipal.menuLogin.Enabled = true;
                        frmPrincipal.menuGestionUsuarios.Enabled = true;
                        frmPrincipal.menuStripGestionDetalles.Enabled = true;
                    }

                    rs = null;
                    contFilas = null;

                }

            }
        }

        public static void DarDeAltaUsuarioPago()
        {
            Usuario_Pago usuarioPago;
            object contFilas;
            string sql = "select nombre_clave from usuario_espera_pago;"; 
           
            string nombreClave, fechaPago;

            ADODB.Recordset rs = new ADODB.Recordset();

            try
            {
                rs = conexion.Execute(sql, out contFilas);
            }
            catch 
            {
                MessageBox.Show("error al obtener datos de  tabala Usuario_espera_pago");
                
            }

            while (!rs.EOF)
            {
                nombreClave = Convert.ToString(rs.Fields[0].Value);
               
                usuarioPago = new Usuario_Pago();
                usuarioPago.conexion = conexion;
                usuarioPago.nombreUsuario = nombreClave;

                switch (usuarioPago.GuardarMembresia())
                {

                   
                    case 1:
                        MessageBox.Show("Conexion cerrada");
                        break;
                    case 2:
                        MessageBox.Show("error al obtener datos de usuario en espera");
                        break;
                    case 3:
                        MessageBox.Show("error al insertar usuario Pago");
                        break;
                }
                usuarioPago = null;
                rs.MoveNext();

            }
            frmgestiondeusuarios.btnValidar.Visible = false;
            MessageBox.Show("Usuarios ingresados con exito");

        }


        //este metodo se utiliza para dar de alta a los usuarios que estan en espera
            public static void darDeAltaUsuarioProvisorio()
            {
                Usuario_Provisorio userProv;
                object contFilas;
                string sql;
                string nombre_clave;
                string contrasena;
                string nombre;
                string apellido;
                 string email;
            
                ADODB.Recordset rs = new ADODB.Recordset(); ;
            

                 sql = "select nombre_clave,contrasena,nombre,apellido,email  from usuario_provisorio";
            try
            {
                rs = conexion.Execute(sql, out contFilas);

            }
            catch 
            {

                MessageBox.Show("error al obtener datos de usuario");
            }

                while (!rs.EOF)
                {
               
                    nombre_clave = Convert.ToString(rs.Fields[0].Value);
                    contrasena = Convert.ToString(rs.Fields[1].Value);
                    nombre = Convert.ToString(rs.Fields[2].Value);
                    apellido = Convert.ToString(rs.Fields[3].Value);
                    email = Convert.ToString(rs.Fields[4].Value);
                    userProv = new Usuario_Provisorio(contrasena,nombre,apellido,nombre_clave,email,conexion);
                    switch (userProv.altaDeUsuarioEnEspera())
                    {
                        case 2:
                            MessageBox.Show("Error al crear Usuario");
                            break;
                        case 3:
                            MessageBox.Show("Error al asignar permisos");
                            break;
                        case 4:
                             MessageBox.Show("error al insertar el nuevo user a la tabla usuario");
                             break;
                        case 5:
                            MessageBox.Show("Error al obtener id de usuario desde la table usuario");
                            break;
                        case 6:
                            MessageBox.Show("error al insertar en la tabla usuario_invitado");
                            break;


                    }
                userProv = null;
                    rs.MoveNext();
                               
                }
                  conexion.Execute("delete from usuario_provisorio", out contFilas);
                  frmgestiondeusuarios.btnDarDeAltaUsEsp.Visible = false;
                  MessageBox.Show("Usuarios ingresados con exito");
               

            }

        //recibe una una consulta sql y la respuesta la adapta a una tabla del tipo DateTable
        //para mostrar por pantalla hay que cargar el return de este metodo a una data gridview
        // de la sigiente manera dataGridView1.DataSource=dt;
       public static DataTable listar(string sql) {

          object contFilas;

            ADODB.Recordset rs = new ADODB.Recordset();

            conexion.Execute("use injectical;",out contFilas);
            try
            {
                rs = conexion.Execute(sql, out contFilas);
            }

            catch
            {

                MessageBox.Show("error en la consulta");
            }

            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
           
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
            frmgestiondeusuarios.txtBuscar.Clear();
            frmgestiondeusuarios.dataGridView1.ClearSelection();
            frmgestiondeusuarios.txtrol.Clear();
            



        }
        
        //para inspeccionar la tabla de usuario provisorio si hay algun usuario en espera
        //se habilitara el boton para dae de alta a los usuarios 
        public static byte chequerTablaUSerProv()
        {
           
            object contfilas;
            byte resultado=0;
            string sql1= "select * from usuario_provisorio;", sql2 = "select * from usuario_espera_pago;";
                                     
            ADODB.Recordset rs1 = new ADODB.Recordset();
            ADODB.Recordset rs2 = new ADODB.Recordset();
            try
            {
                rs1 = conexion.Execute(sql1, out contfilas);
                rs2 = conexion.Execute(sql2, out contfilas);
            }
            catch {
                return (2);//error al consultar
            }

            if (rs1.RecordCount == 0 && rs2.RecordCount == 0)
            {
                resultado = 1;//ambas consultas estan vacias
            }
            else if (rs1.RecordCount > 0 && rs2.RecordCount > 0)
            {
                resultado = 3;//ambas tablas tienen datos
            }
            else if (rs1.RecordCount > 0 && rs2.RecordCount == 0)
            {
                 resultado = 4;//solo datos en tabla usuario_provisorio
            }
            else if (rs1.RecordCount == 0 && rs2.RecordCount > 0)
            {
                resultado = 5;//solo datos en tabla usuario_espera_pago
            }

            return resultado;
        }

        
    }
}