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
    public partial class GestionDetalles : Form
    {
        public GestionDetalles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.nombre = txtNombreEvento.Text;
            evento.conexion = Program.conexion;
            DateTime fecha = dtpFechaEvento.Value;
            string formato = "yyyy-MM-d";
            string fecha2 = fecha.ToString(formato);
            evento.fecha = fecha2;

            try
            {
                dgvEventos.DataSource = evento.ListarEventoResumen();
            }
            catch 
            {

                MessageBox.Show("Error al obtener Lista de evento");
            }

            try
            {
                dataGridView1.DataSource= evento.BuscarDetallesDeevento();
            }
            catch 
            {

                MessageBox.Show("error al cargar detalles de evento");
            }
        }

        private void GestionDetalles_Load(object sender, EventArgs e)
        {
            
            Evento evento = new Evento();
            evento.conexion = Program.conexion;
            try
            {
                dgvDetalles.DataSource = evento.ListarDetalles();
            }
            catch 
            {
                MessageBox.Show("Error al obtener lista de detalles");
               
            }
            
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;

                       
            posicion = dgvEventos.CurrentRow.Index;
            txtidEvento.Text= dgvEventos[0, posicion].Value.ToString();
            txtNombreE.Text = dgvEventos[1, posicion].Value.ToString();
            
            
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;
            posicion = dgvDetalles.CurrentRow.Index;

            txtidDetalle.Text = dgvDetalles[0, posicion].Value.ToString();
            txtNombreDetalle.Text= dgvDetalles[1, posicion].Value.ToString();

            
        }

        private void btnIngresarDetalle_Click(object sender, EventArgs e)
        {
            if (txtNombreDetalle.Text.Equals(""))
            {
                MessageBox.Show("falta seleccionar el detalle");
                return;
            }
            if (txtNombreE.Text.Equals(""))
            {
                MessageBox.Show("Falta seleccionar el evento");
                return;
            }
            if (txtNombreDescripcion.Text.Equals(""))

            {
                MessageBox.Show("Falta ingresar la descripcion del detalle");
                return;
            }
            string nombre = txtNombreE.Text;
            int idD;
            int idE;
            int.TryParse(txtidDetalle.Text, out idD);
            int.TryParse(txtidEvento.Text, out idE);
            string descripcion = txtNombreDescripcion.Text;
            ADODB.Connection conexion = Program.conexion;
            DetalleDeEvento detalleDeEvento = new DetalleDeEvento(descripcion, idE, idD, conexion);
            Evento evento = new Evento();
            evento.conexion = Program.conexion;
            evento.nombre = txtNombreE.Text;

            DateTime fecha = dtpFechaEvento.Value;
            string formato = "yyyy-MM-d";
            string fecha2 = fecha.ToString(formato);
            evento.fecha=fecha2;

            
           

           switch (detalleDeEvento.AsociarDeatlle())
            {
                case 0:
                    try
                    {
                        dataGridView1.DataSource = evento.BuscarDetallesDeevento();
                    }
                    catch 
                    {

                        MessageBox.Show("error al devolver vista de detalles del evento");
                    }
                    break;
                    
                case 1:
                    MessageBox.Show("Sin conexion");
                    break;
                case 2:
                    MessageBox.Show("error al guardar ");
                    break;

           }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = null;
            dgvEventos.DataSource = null;
            txtidDetalle.Clear();
            txtidEvento.Clear();
            txtNombreDescripcion.Clear();
            txtNombreDetalle.Clear();
            txtNombreE.Clear();

        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea dar de baja?", "", MessageBoxButtons.YesNoCancel);
            if (respuesta == DialogResult.Yes)
            {
                DetalleDeEvento detalleDeEvento = new DetalleDeEvento();
                detalleDeEvento.Conexion = Program.conexion;
                int idDetalle;
                int.TryParse(txtidDetalle.Text, out idDetalle);
                detalleDeEvento.IdDetalle = idDetalle;

                Evento evento = new Evento();
                evento.conexion = Program.conexion;
                evento.nombre = txtNombreEvento.Text;
                DateTime fecha = dtpFechaEvento.Value;
                string formato = "yyyy-MM-d";
                string fecha2 = fecha.ToString(formato);
                evento.fecha = fecha2;


                switch (detalleDeEvento.desasociarDetalle())
                {
                    case 0:
                        MessageBox.Show("detalle dado de baja con exito");
                        try
                        {
                            dataGridView1.DataSource = evento.BuscarDetallesDeevento();
                        }
                        catch
                        {

                            MessageBox.Show("error al mostrar detalles del evento");
                        }
                        txtidDetalle.Clear();
                        txtidEvento.Clear();
                        txtNombreDescripcion.Clear();
                        txtNombreDetalle.Clear();
                        txtNombreEvento.Clear();

                        break;
                    case 1:
                        MessageBox.Show("falta de conexion");
                        break;
                    case 2:
                        MessageBox.Show("error al eliminar ");
                        break;
                }
                evento = null;
                detalleDeEvento = null;
            }
        }

        private void dgvDetallesDeEvento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;


            posicion = dgvEventos.CurrentRow.Index;
           // txtidDetalle.Text = dgvDetallesDeEvento[0, posicion].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion;


            posicion = dataGridView1.CurrentRow.Index;
            txtidDetalle.Text = dataGridView1[0, posicion].Value.ToString();

        }
    }
}
