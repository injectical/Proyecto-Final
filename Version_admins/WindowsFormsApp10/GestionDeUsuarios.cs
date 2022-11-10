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
           
            btnModificar.Visible = false;
            btnValidar.Visible = false;
            btncrear.Visible = false;
            btnEliminar.Visible = false;
            btnDarDeAltaUsEsp.Visible = false;
            
                    
            switch (Program.chequerTablaUSerProv())
            {
                    
                case 2:
                    MessageBox.Show("error al chequear la tabla de usuarios Provisorios");
                    break;
                case 3:
                    btnValidar.Visible = true;
                    btnDarDeAltaUsEsp.Visible = true;
                    break;
                case 4:
                    btnDarDeAltaUsEsp.Visible = true;
                    break;
                case 5:
                    btnValidar.Visible = true;
                    break;
            }
           

        }

        private void rbtVistaGeneral_CheckedChanged(object sender, EventArgs e)

        {
            Usuario usuario = new Usuario();
            usuario.conexion = Program.conexion;
            usuario.rol = 3;
            try
            {
                dataGridView1.DataSource = usuario.Filtrar();
            }
            catch
            {
                MessageBox.Show("Error al obtener usuarios");
            }
            usuario = null;
        }

        private void rbtVistaUsuariosadm_CheckedChanged(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.conexion = Program.conexion;
            usuario.rol = 2;
            try
            {
                dataGridView1.DataSource = usuario.Filtrar();
            }
            catch
            {
                MessageBox.Show("Error al obtener usuarios");
            }
            usuario = null;
        }

        private void rbtUsuariosPagos_CheckedChanged(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.conexion = Program.conexion;
            usuario.rol = 4;
           
            try
            {
                dataGridView1.DataSource = usuario.Filtrar();
            }
            catch
            {
                MessageBox.Show("Error al obtener usuarios");
            }
            usuario = null;
        }

        private void rbtSuperUsuario_CheckedChanged(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.conexion = Program.conexion;
            usuario.rol = 1;
           
            try
            {
                dataGridView1.DataSource = usuario.Filtrar();
            }
            catch
            {
                MessageBox.Show("Error al obtener usuarios");
            }
            usuario = null;
        }

        private void rbtAutorizarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Program.listar("select * from usuario_provisorio");

        }

        private void rbtAutorizarMembresía_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.listar("select * from usuario_espera_pago");
            btnValidar.Visible = true;
        }

        //este metodo esta pendiente para editar 
        private void btncrear_Click(object sender, EventArgs e)

        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el Nombre");
                return;
            }

            if (txtcorreo .Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el Email");
                return;
            }

            if (txtNombreDeUSuarioClave.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el nombre clave del usuario");
                return;
            }
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtcorreo.Text;
            string nombreClave = txtNombreDeUSuarioClave.Text;
            txtBuscar.Clear();
            ADODB.Connection conexion = Program.conexion;

            if (rbAdmDepor.Checked)
            {

            

             Administrador adm = new Administrador(nombre, apellido, nombreClave, email, conexion);


                switch (adm.darDeAlta())
                {

                    case 0:

                        txtApellido.Clear();
                        txtNombre.Clear();
                        txtcorreo.Clear();
                        txtNombreDeUSuarioClave.Clear();
                        btncrear.Visible = false;
                        rbAdmDepor.Checked = false;
                        MessageBox.Show("Usuario creado con exito");
                        break;

                    case 1:
                        MessageBox.Show("error al crear el usuario");
                        break;

                    case 2:
                        MessageBox.Show("Error al insertar usuario administrador en la tabla usuario");
                        break;
                    case 3:

                        MessageBox.Show("error al insertar el usuario administrador en la tabla usuario-adm");

                        break;
                    case 4:
                        MessageBox.Show("error al otorgar privilegios");
                        break;
                }


            }
            else if (rbSuperUs.Checked)
            {
                SuperUsuario superuser = new SuperUsuario(nombre, apellido, nombreClave, email, conexion);
                switch (superuser.DarDeAlta())
                {
                    case 0:
                        txtApellido.Clear();
                        txtNombre.Clear();
                        txtcorreo.Clear();
                        txtNombreDeUSuarioClave.Clear();
                        btncrear.Visible = false;
                        rbSuperUs.Checked = false;
                        MessageBox.Show("Usuario creado con exito");
                        break;
                    case 1:
                        MessageBox.Show("Perdida de conexion");
                        break;
                    case 2:
                        MessageBox.Show("error al crear el usuario");
                        break;
                    case 3:
                        MessageBox.Show("error al insertar en la tabla usuario");
                        break;

                }
            }
            else
            {
                MessageBox.Show("Debe elegir un rol para el administrador");
            }







        }

        private void grbAdministradores_Enter(object sender, EventArgs e)
        {
            
        }

        

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nombreUsuario = txtNombreDeUSuarioClave.Text;
            DialogResult respuesta;
            respuesta = MessageBox.Show("Esta seguro? ", "Eliminar?", MessageBoxButtons.YesNoCancel);
            if(respuesta == DialogResult.Yes)
            {
                usuario.conexion = Program.conexion;
                switch (usuario.Eliminar())
                    
                {
                    case 0:
                        btnEliminar.Visible = false;
                        btnModificar.Visible = false;
                        Program.LimpiarCampos();
                        Program.frmgestiondeusuarios.dataGridView1.DataSource = null;
                        break;
                    case 1:
                        MessageBox.Show("se perdio la conexion");
                        break;
                    case 2:
                        MessageBox.Show("error al eliminar al usuario ");
                        break;
                }

            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int rol=0;
            Usuario usuario = new Usuario();
            DialogResult respuesta;
           
            if (rbSuperUs.Checked)
            {
                rol = 1;
                txtrol.Text = "1";
            }
            else if (rbAdmDepor.Checked)
            {
                rol = 2;
                txtrol.Text = "2";
            }
            else if (rbUsInvi.Checked)
            {
                rol = 3;
                txtrol.Text = "3";
            }
            else if (rbUsPago.Checked)
            {
                rol = 4;
                txtrol.Text = "4";
            }
            else
            {
                int.TryParse(txtrol.Text,out rol);
            }

           

            usuario.nombre = txtNombre.Text;
            usuario.apellido = txtApellido.Text;
            usuario.email = txtcorreo.Text;
            usuario.conexion = Program.conexion;
            usuario.nombreUsuario = txtNombreDeUSuarioClave.Text;
            usuario.rol = rol;

            respuesta = MessageBox.Show("Nombre: "+usuario.nombre+"\nApellido: "+usuario.apellido+"\ncorreo: "+usuario.email+"\nRol: "+usuario.rol,"Desea actualizar los sigientes datos"
                , MessageBoxButtons.YesNoCancel);
            if (respuesta == DialogResult.Yes)
            {
                switch (usuario.Modificar())
                {
                    case 0:
                        Program.LimpiarCampos();
                        Program.frmgestiondeusuarios.dataGridView1.DataSource = null;
                        btnModificar.Visible = false;
                        break;
                    case 1:
                        MessageBox.Show("Se perdio la conexion");
                        break;
                    case 2:
                        MessageBox.Show("Problemas para modificar los datos, asegurece de haber ingresado los datos correctamente");
                        break;
                }

            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
            int posicion;
            
            Usuario usuario = new Usuario();

            usuario.nombreUsuario = txtBuscar.Text;
            usuario.conexion = Program.conexion;
            
            if (usuario.conexion.State==0)
            {
                MessageBox.Show("error de conexion");
                return;
            }
            else
            {
                if(txtBuscar.Text.Length == 0)
                {
                    MessageBox.Show("debe ingresar un nombre clave");
                    return;
                }
              
            }
            try
            {
                dataGridView1.DataSource = usuario.Buscar();
            }
            catch 
            {

                MessageBox.Show("error de conexion");
            }
           

           

           if (dataGridView1.RowCount>1)
            {
               
                btncrear.Visible = false;

            }
            else
            { 
                                             
                     DialogResult respuesta = MessageBox.Show("Desea crearlo?", "El usuario no existe", MessageBoxButtons.YesNoCancel);
                     if (respuesta == DialogResult.Yes)
                     {
                         btncrear.Visible = true;
                         btnEliminar.Visible = false;
                            btnModificar.Visible = false;
                                string nombreClave= txtBuscar.Text;
                                       Program.LimpiarCampos();
                         txtNombreDeUSuarioClave.Enabled = true;

                                txtNombreDeUSuarioClave.Text = nombreClave;
                         



                     }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Program.LimpiarCampos();
           dataGridView1.DataSource = null;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btncrear.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;


            posicion = dataGridView1.CurrentRow.Index;

                txtid.Text = dataGridView1[0, posicion].Value.ToString();
                txtNombre.Text = dataGridView1[1, posicion].Value.ToString();
                txtApellido.Text = dataGridView1[2, posicion].Value.ToString();
                txtcorreo.Text = dataGridView1[3, posicion].Value.ToString();
                txtrol.Text = dataGridView1[4, posicion].Value.ToString();
                txtNombreDeUSuarioClave.Text = dataGridView1[5, posicion].Value.ToString();

            if (txtNombre != null) {
                
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                btncrear.Visible = false;
                txtNombreDeUSuarioClave.Enabled = false;
                
                
            }

            

        }

        //VALIDA SUSCRIPCIÓN
        private void btnValidar_Click(object sender, EventArgs e)
        {
            Program.DarDeAltaUsuarioPago();
           


            
        }

        private void btnDarDeAltaUsEsp_Click(object sender, EventArgs e)
        {

            Program.darDeAltaUsuarioProvisorio();
            
            
            
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbUsInvi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSuperUs_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
