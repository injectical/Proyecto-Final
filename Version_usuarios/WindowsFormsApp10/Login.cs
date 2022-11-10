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

        //VER COMO HACER UN LOGOUT, ESTO SOLO CIERRA LA VENTANA
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombre.Text;
            string pass = txtContraseña.Text;


            ApiAtenticacion atuenticacion = new ApiAtenticacion();
           
           

            switch (atuenticacion.Autenticar(nombreUsuario,pass))
            {
                case 0:

                    MessageBox.Show("usuario o contraseña incorrectos");
                    break;
                case 1:
                    Program.frmPrincipal.pbLogin.Visible = false;
                    Program.conexion.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
                    Program.doyPermisos(txtNombre.Text);
                    this.Close();
                    Program.frmPrincipal.btnEventos.Visible = true;
                   
                    if (Program.rol == 3)
                    {
                        Program.frmBanners = new Banners();
                        Program.frmBanners.Show();
                        Program.frmBanners.MdiParent = Program.frmPrincipal;
                    }

                    if (Program.rol == 4)
                    {
                        
                        Notificacion N = new Notificacion();
                        N.Con = Program.conexion;
                        N._idUs = Program.id;
                        ADODB.Recordset rs=new ADODB.Recordset();
                       try
                        {
                            rs = N.TraerNotificaciones();
                        }
                        catch 
                        {

                            MessageBox.Show("Error al obtener notificaciones");
                        }

                        if (rs.RecordCount > 0)
                        {
                            Program.frmNotificacion = new Notificaciones();
                            Program.frmNotificacion.MdiParent = Program.frmPrincipal;
                            Program.frmNotificacion.Show();
                            while (!rs.EOF)
                            {
                                string nombre = Convert.ToString(rs.Fields[0].Value);
                                string fecha = Convert.ToString(rs.Fields[1].Value);
                                string Dato = "Nombre: "+nombre + "   Fecha: " + fecha;
                                Program.frmNotificacion.lstNotificaciones.Items.Add(Dato);
                                rs.MoveNext();
                            }
                        }
                    }
                    break;

            }

            /* try
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
             Program.frmPrincipal.btnEventos.Visible = true;

         }*/



        }









        //TE MANDA AL FORMULARIO DE REGISTRO CERRANDO EL ACTUAL
        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Close();
            Program.frmRegistro = new Registro();
            Program.frmRegistro.Show();
            if (Program.frmPrincipal.menuGestion.Text.Equals("User Management"))
            {
                Program.frmRegistro.lblNombreUsuario.Text = ResIngles.Registro_NombreDEUsuario;
                Program.frmRegistro.lblNombre.Text = ResIngles.Registro_Nombre;
                Program.frmRegistro.lblApellido.Text = ResIngles.Registro_Apellido;
                Program.frmRegistro.lblContraseña.Text = ResIngles.Registro_Contrasenia;
                Program.frmRegistro.btnEnviar.Text = ResIngles.Registro_btnEnviar;
                Program.frmRegistro.btnBorrar.Text = ResIngles.Registro_btnBorrar;
            }
                
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
