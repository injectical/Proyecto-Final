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
           
           
            string nombre, apellido, correo, nombreClave,sql;
            int Rol=0;
            object contFilas;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            correo = txtcorreo.Text;
            nombreClave = txtNombreDeUSuarioClave.Text;

            if (rbSuperUs.Checked)
            {
                Rol = 1;
            }
            else if (rbAdmDepor.Checked)
            {

                Rol = 2;
            }
            else if (rbUsPago.Checked)
            {

                Rol = 4;
            }
            else if (rbUsInvi.Checked)
            {

                Rol = 3;
            }

            sql = "insert into usuario (NOMBRE,APELLIDO,EMAIL,rol,nombre_clave) values ('"+nombre+ "','" + apellido + "','" + correo + "'," + Rol + ",'" + nombreClave + "');";

            Console.WriteLine(sql);

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

        private void grbAdministradores_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
            object contFilas;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtcorreo.Text;
            string nombreClave = txtNombreDeUSuarioClave.Text;
            string id = txtid.Text;
            int Rol = 0;
            if (rbSuperUs.Checked)
            {
                Rol = 1;
            }
            else if (rbAdmDepor.Checked)
            {

                Rol = 2;
            }
            else if (rbUsPago.Checked)
            {

                Rol = 4;
            }
            else if (rbUsInvi.Checked)
            {

                Rol = 3;
            }
            string sql = "update usuario set NOMBRE= '" + nombre + "',APELLIDO= '" + apellido + "',EMAIL='" + correo + "',rol='" + Rol + "', nombre_clave='" + nombreClave + "' where id_USUARIO=" + id+" ;";


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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //se carga en un datagridview la respuesta a la consulta mediante el metodo listarUsuarios()
            string nombre = txtBuscar.Text;
            Program.frmgestiondeusuarios.dataGridView1.DataSource = Program.listarUsuarios("select * from usuario where nombre_clave= '" +nombre + "'; ");

        }
    }
}
