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
    public partial class GestionDeEventos : Form
    {
        int posicion; //variable usada para traer datos de la fila a los textbox

        public GestionDeEventos()
        {
            InitializeComponent();
        }

        private void chkConfirmacionDeFinal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void GestionDeEventos_Load(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            txtID.Enabled = false;
            txtResultado.Enabled = false;
           


        }


       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtPais.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el Pais");
                return;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el Nombre");
                return;
            }

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta ingresar el Nombre");
                return;
            }
            bool alta = true;
            Evento evento = new Evento();
            evento.conexion = Program.conexion;
            evento.nombre = txtNombre.Text;
            DateTime fecha = dtpFechaCrear.Value;
            string hora = Convert.ToString(nUDhora.Value);
            string min = Convert.ToString(nudMinutos.Value);
            string formato = "yyyy-MM-d";
            string fecha2 = fecha.ToString(formato);
            evento.fecha = fecha2;
            evento.pais = txtPais.Text;
            evento.hora = hora + ":" + min;
            //MessageBox.Show(evento.fecha);

            

            switch (evento.Guardar(alta)) {
                case 1:
                    MessageBox.Show("conexion cerrada");
                 
                    break;
                case 2:
                    MessageBox.Show("Error al insertar en la tabla evento");
                   
                    break;
                case 0:
                    MessageBox.Show("evento guardado con exito");
                    btnAgregar.Visible = false;
                    txtNombre.Clear();
                    txtPais.Clear();
                    nUDhora.Value = 0;
                    nudMinutos.Value = 0;
                    break;

            }
            evento = null;

        }

        private void limpiarTextBox()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtPais.Clear();
          //  txtFecha.Clear();
            //txtHora.Clear();
            txtResultado.Clear();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            byte inicio = 0, final = 0 ;
            int id;
            bool alta = false;
            byte Hora;
            byte Min;
            string resultado = "";
            DateTime fecha = dtpFechaCrear.Value;
            string formato = "yyyy-MM-d";
            string fecha2 = fecha.ToString(formato);
            txtFecha.Text = fecha2;
            Evento evento = new Evento();
            evento.conexion = Program.conexion;

            string hora = Convert.ToString(nUDhora.Value);

           string min = Convert.ToString(nudMinutos.Value);
           




            if (chkConfirmacionDeFinal.Checked)
            {

                final = 1;
            }
            if (chkConfirmacionDeInicio.Checked)
            {

                inicio = 1;
            }
            if (txtResultado.Text != null)
            {
                resultado = txtResultado.Text;
            }

            evento.inicio = inicio;
            evento.final = final;
            evento.resultado = resultado;
            evento.fecha = fecha2;
            evento.hora = hora + ":" + min;
            int.TryParse(txtID.Text, out id);
            evento.id = id;
            DialogResult respuesta;
            respuesta = MessageBox.Show("Fecha: "+evento.fecha+"\nResultado: "+evento.resultado+"\ninicio: "+evento.inicio+"\nFinal: "+evento.final+"\nHora:"+evento.hora+"\nEsta seguro ?", "Modificar", MessageBoxButtons.YesNoCancel);
            if (respuesta == DialogResult.Yes)
            {

                switch (evento.Guardar(alta))
                {
                    case 0:
                        MessageBox.Show("evento modificado con exito");
                        btnEliminar.Visible = false;
                        btnModificar.Visible = false;
                        txtFecha.Clear();
                        txtHora.Clear();
                        txtID.Clear();
                        txtNombre.Clear();
                        txtPais.Clear();
                        txtResultado.Clear();
                        chkConfirmacionDeFinal.Checked = false;
                        chkConfirmacionDeInicio.Checked = false;
                        evento = null;
                        break;
                    case 1:
                        MessageBox.Show("Error de conexion");
                        break;
                    case 2:
                        MessageBox.Show("error al insertar");
                        break;


                }
                

            }
            
        }

        //private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
          //  posicion = dgvEventos.CurrentRow.Index;

            //txtID.Text = dgvEventos[0, posicion].Value.ToString();
            //txtPais.Text = dgvEventos[1, posicion].Value.ToString();
            //txtNombre.Text = dgvEventos[2, posicion].Value.ToString();
            //txtFecha.Text = dgvEventos[3, posicion].Value.ToString();
            //txtHora.Text = dgvEventos[4, posicion].Value.ToString();
            //txtResultado.Text = dgvEventos[7, posicion].Value.ToString();

        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.conexion = Program.conexion;
            
            int id;
            int.TryParse(txtID.Text, out id);
            evento.id = id;
            evento.nombre = txtNombre.Text;
            DialogResult respuesta;
            respuesta = respuesta = MessageBox.Show("Nombre del Evento:  "+evento.nombre , "Eliminar", MessageBoxButtons.YesNoCancel);
           if(respuesta== DialogResult.Yes)
           { 
           

            switch (evento.Eliminar())

            {
                case 0:
                    MessageBox.Show("evento eliminado con exito ");
                        txtNombre.Clear();
                        txtPais.Clear();
                        txtResultado.Clear();
                        txtID.Clear();
                        txtHora.Clear();
                        txtFecha.Clear();
                        chkConfirmacionDeFinal.Checked = false;
                        chkConfirmacionDeInicio.Checked = false;
                        btnEliminar.Visible = false;
                        btnModificar.Visible = false;
                        evento = null;
                    break;
                case 1:
                    MessageBox.Show("conexion cerrada");
                    break;
                case 2:
                    MessageBox.Show("Error al eliminar el evento");
                    break;
            }


           }

        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkConfirmacionDeFinal_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void chkConfirmacionDeInicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblPais_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            bool tipo = true;
            Evento evento = new Evento();
            evento.conexion = Program.conexion;
            Program.frmgestionEventos.dtgEventos.DataSource= evento.ListarEventos(tipo);
           
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           bool tipo = false;
            Evento evento = new Evento();
            evento.nombre = txtBuscarNombre.Text;
            evento.conexion = Program.conexion;

            DateTime fecha = dtFecha1.Value;
            string formato = "yyyy-MM-d";
            string fecha2 = fecha.ToString(formato);

            evento.fecha = fecha2;
          

            if (evento.conexion.State == 0)
            {
                MessageBox.Show("coneccion cerrada");
                return;
            }
            else
            {
                if (txtBuscarNombre.Text.Length!=0)
                {
                    try
                    {
                        dtgEventos.DataSource = evento.ListarEventos(tipo);
                    }
                    catch 
                    {

                        MessageBox.Show("error de conexion");
                    }

                   

                }
                else
                {
                    MessageBox.Show("debe ingresar el nombre del evento");
                    return;
                }

                if (dtgEventos.RowCount > 1)
                {
                    btnAgregar.Visible = false;
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("Desea crearlo?", "El evento no existe", MessageBoxButtons.YesNoCancel);
                    if (respuesta == DialogResult.Yes)
                    {
                        btnAgregar.Visible = true;
                        txtNombre.Text = txtBuscarNombre.Text;
                        txtBuscarNombre.Clear();

                    }
                }
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtgEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
           
            

            posicion = dtgEventos.CurrentRow.Index;

            txtID.Text = dtgEventos[0, posicion].Value.ToString();
            txtNombre.Text = dtgEventos[1, posicion].Value.ToString();
            txtPais.Text = dtgEventos[2, posicion].Value.ToString();
            txtFecha.Text = dtgEventos[3, posicion].Value.ToString();
            DateTime fecha;
            DateTime.TryParse(txtFecha.Text, out fecha);
            dtpFechaCrear.Value = fecha.Date;
            txtHora.Text = dtgEventos[4, posicion].Value.ToString();
            txtResultado.Text = dtgEventos[5, posicion].Value.ToString();
            byte inicio;
            byte final;
            byte.TryParse(dtgEventos[6, posicion].Value.ToString(),out inicio);
            byte.TryParse(dtgEventos[7, posicion].Value.ToString(), out final);

            string horaCompleta = txtHora.Text;
             char H = horaCompleta[0];
            char h = horaCompleta[1];
            string hora = $"{H}{h}";
            int hs;
            int.TryParse(hora, out hs);
            nUDhora.Value = hs;
            char M = horaCompleta[3];
            char m = horaCompleta[4];
            string minuto = $"{M}{m}";
            int min;
            int.TryParse(minuto, out min);
            nudMinutos.Value = min;
            if (inicio == 1)
            {
                chkConfirmacionDeInicio.Checked=true;
                if (final==1)
                {
                    chkConfirmacionDeFinal.Checked = true;
                }
            }

            if (txtNombre != null)
            {

                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                btnAgregar.Visible = false;
                txtNombre.Enabled = false;
                txtResultado.Enabled = true;


            }


        }

        private void txtHora_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
