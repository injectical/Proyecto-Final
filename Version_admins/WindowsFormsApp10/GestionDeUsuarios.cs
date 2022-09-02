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
    public partial class GestionDeUsuarios : Form
    {
        int posicion;
        public GestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
            btnValidar.Visible = false;
        }

        private void rbtVistaGeneral_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=3;");
        }

        private void rbtVistaUsuariosadm_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=2;");
        }

        private void rbtUsuariosPagos_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=4;");
        }

        private void rbtSuperUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=1;");
        }

        private void rbtAutorizarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario_provisorio");

        }

        private void rbtAutorizarMembresía_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario_espera_pago");
            btnValidar.Visible = true;
        }
        private void btncrear_Click(object sender, EventArgs e)

        {


            string privilegios ="";
            string nombre, apellido, correo, nombreClave,sql;
            int Rol=0;
            bool validar = true;
            bool validarRol = false;
            object contFilas;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            correo = txtcorreo.Text;
            nombreClave = txtNombreDeUSuarioClave.Text;
            //segun el rol que se seleccione se le otorgara su correspondiente previlegio
            //en el caso del super usuario va a tener todos los permisos sobre la bdd sport360
            if (rbSuperUs.Checked)
            {
                validarRol = true;
                privilegios = "grant all privileges on *.* to '" + nombreClave + "'@'localhost';";
                Rol = 1;
            }
             else if (rbAdmDepor.Checked)
            {
                validarRol = true;
                privilegios = "grant all privileges on sport360.* to '" + nombreClave + "'@'localhost';";
                Rol = 2;
            }
            else if (rbUsPago.Checked)
            {
                validarRol = true;
                privilegios = "grant select on sport360.* to '" + nombreClave + "'@'localhost';";
                Rol = 4;
            }
            else if (rbUsInvi.Checked)
            {
                validarRol = true;
                privilegios = "grant select on sport360.* to '" + nombreClave + "'@'localhost';";
                Rol = 3;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el nombre del usuario");
                validar = false;

            }
            else if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el apellido del usuario");
                validar = false;
            }
            else if (txtcorreo.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el email del usuario");
                validar = false;

            }
            else if (txtNombreDeUSuarioClave.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el nombre clave del usuario");
                validar = false;

            }

            if (validarRol == false)
            {
                MessageBox.Show("Falta seleccionar un rol para el usuario");
            }

            if (validar && validarRol) {
                
                Usuario nuevo = new Usuario();
                bool res;
                int a;
                string str = txtid.Text;
                res = int.TryParse(str, out a);
                nuevo.id = a;
                nuevo.nombre = txtNombre.Text;
                nuevo.apellido = txtApellido.Text;
                nuevo.email = txtcorreo.Text;
                nuevo.rol = Rol;
                nuevo.nombreUsuario = txtNombreDeUSuarioClave.Text;
                nuevo.contraseña = txtContraseña.Text;

                nuevo.Guardar(true);



                Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol= " + Rol + "; ");
                Program.LimpiarCampos();

            }

           

        }

        private void grbAdministradores_Enter(object sender, EventArgs e)
        {
            
        }

        

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            object contFilas;
            string nombre_clave = txtNombreDeUSuarioClave.Text;
            string sql = "delete from usuario where nombre_clave = '" + nombre_clave + "';";


            Program.conexion.Execute(sql, out contFilas);
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario;");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool validar=true;
            bool validarRol=false;
            string privilegios;
            object contFilas;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtcorreo.Text;
            string nombreClave = txtNombreDeUSuarioClave.Text;
            string id = txtid.Text;
            int Rol = 0;
            if (rbSuperUs.Checked)
            {
                validarRol = true;
                Rol = 1;
               
            }
            else if (rbAdmDepor.Checked)
            {
                
                validarRol = true;
                Rol = 2;
            }
            else if (rbUsPago.Checked)
            {
                validarRol = true;
                
                Rol = 4;
            }
            else if (rbUsInvi.Checked)
            {
                
                validarRol = true;
                Rol = 3;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el nombre del usuario");
                validar = false;

            }
            else if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el apellido del usuario");
                validar = false;
            }
            else if (txtcorreo.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el email del usuario");
                validar = false;

            }
            else if (txtNombreDeUSuarioClave.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el nombre clave del usuario");
                validar = false;

            }

            if(validarRol==false){
                MessageBox.Show("Falta seleccionar un rol para el usuario");
            }

            if (validar && validarRol)
            {
               
                
               
                string sql = "update usuario set NOMBRE= '" + nombre + "',APELLIDO= '" + apellido + "',EMAIL='" + correo + "',rol='" + Rol + "', nombre_clave='" + nombreClave + "' where id_USUARIO=" + id + " ;";
                    

                try
                {

                    Program.conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    MessageBox.Show("Los datos no fueron ingresados correctamente ");
                    return;
                }

                Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol= " + Rol + "; ");

            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //se carga en un datagridview la respuesta a la consulta mediante el metodo listarUsuarios()
            string nombre = txtBuscar.Text;
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where nombre_clave= '" +nombre + "'; ");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Program.LimpiarCampos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;

            if (rbtAutorizarMembresía.Checked)
            {
                txtNombreDeUSuarioClave.Text = dataGridView1[0, posicion].Value.ToString();
            }
            else
            {
                posicion = dataGridView1.CurrentRow.Index;

                txtid.Text = dataGridView1[0, posicion].Value.ToString();
                txtNombre.Text = dataGridView1[1, posicion].Value.ToString();
                txtApellido.Text = dataGridView1[2, posicion].Value.ToString();
                txtcorreo.Text = dataGridView1[3, posicion].Value.ToString();
                txtrol.Text = dataGridView1[4, posicion].Value.ToString();
                txtNombreDeUSuarioClave.Text = dataGridView1[5, posicion].Value.ToString();
                txtContraseña.Text = dataGridView1[6, posicion].Value.ToString();

            }

        }
        //VALIDA SUSCRIPCIÓN
        private void btnValidar_Click(object sender, EventArgs e)
        {
            Usuario_Pago pago = new Usuario_Pago();

            pago.nombreUsuario = txtNombreDeUSuarioClave.Text;
            pago.fechaDePago = dtpFecha.DataBindings.ToString();
            
            pago.GuardarMembresia();
            txtNombreDeUSuarioClave.Clear();
        }
    }
}
