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
        public GestionDeUsuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void rdbVistaGeneral_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=3;");
        }

        private void rbtVistaUsuariosadm_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=2;");
        }

        private void rbUsuariosPagos_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=4;");
        }

        private void rbSuperUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where rol=1;");
        }

        private void btncrear_Click(object sender, EventArgs e)

        {

            string privilegios="";
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
            if (rbSuperUs.Checked)
            {
                validarRol = true;
                privilegios = "grant all on sport360.* to '" + nombreClave + "'";
                Rol = 1;
            }
            else if (rbAdmDepor.Checked)
            {
                validarRol = true;
                privilegios = "grant all on sport360.* to '" + nombreClave + "'";
                Rol = 2;
            }
            else if (rbUsPago.Checked)
            {
                validarRol = true;
                privilegios = "grant select on sport360.* to '" + nombreClave + "'";
                Rol = 4;
            }
            else if (rbUsInvi.Checked)
            {
                validarRol = true;
                privilegios = "grant select on sport360.* to '" + nombreClave + "'";
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

            if (validar && validar) {


                sql = "insert into usuario (NOMBRE,APELLIDO,EMAIL,rol,nombre_clave) values ('" + nombre + "','" + apellido + "','" + correo + "'," + Rol + ",'" + nombreClave + "');";

               //se reliza insert en la tabla usuario

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
                //se crea usuario en mysql con el nombre_clave

                string CrearUsuario = "grant usage on soprt360.* TO '" + nombreClave + "'@'localhost' identified by '1234' ;";

                try
                {

                    Program.conexion.Execute(CrearUsuario, out contFilas);
                }
                catch
                {
                    MessageBox.Show("error al crear el usuario ");
                    return;
                }
                //se ejecuta la asignacion de privilegios para el usuario 
                try
                {

                    Program.conexion.Execute(privilegios, out contFilas);
                }
                catch
                {
                    MessageBox.Show("error al ingresar los privilegios");
                    return;
                }

            }

           

        }

        private void grbAdministradores_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando se hace doble clic sobre uno de los atributos de una tupla
            //se cargan los datos de la tupla a su correspondiente text box
            txtApellido.Text = dataGridView1.CurrentRow.Cells["APELLIDO"].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtcorreo.Text = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtrol.Text = dataGridView1.CurrentRow.Cells["rol"].Value.ToString();
            txtNombreDeUSuarioClave.Text = dataGridView1.CurrentRow.Cells["nombre_clave"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
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
    }
}
