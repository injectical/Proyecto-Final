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
            nuevaLista();
        }

        private void nuevaLista()
        {
            Evento lista = new Evento();

            dgvEventos.DataSource = lista.Listar();
        }

        private void crearEvento(bool alta)
            //SE HACE DE ESTA FORMA PORQUE NO ES NECESARIO PASAR UN ID PARA EL ALTA
        {
            Evento nuevoEvento = new Evento();
            nuevoEvento.nombre = txtNombre.Text;
            nuevoEvento.pais = txtPais.Text;
            nuevoEvento.fecha = txtFecha.Text;
            nuevoEvento.hora = txtHora.Text;
            nuevoEvento.inicio = "false";
            nuevoEvento.final = "false";
            nuevoEvento.resultado = txtResultado.Text;
            if (!alta)
            {
                nuevoEvento.id = Convert.ToInt32(txtID.Text);

            }
            else
            {
                
            }
            nuevoEvento.Guardar(alta);
            limpiarTextBox();
            nuevaLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            crearEvento(true);
        }

        private void limpiarTextBox()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtPais.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtResultado.Clear();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            crearEvento(false);
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgvEventos.CurrentRow.Index;

            txtID.Text = dgvEventos[0, posicion].Value.ToString();
            txtPais.Text = dgvEventos[1, posicion].Value.ToString();
            txtNombre.Text = dgvEventos[2, posicion].Value.ToString();
            txtFecha.Text = dgvEventos[3, posicion].Value.ToString();
            txtHora.Text = dgvEventos[4, posicion].Value.ToString();
            txtResultado.Text = dgvEventos[7, posicion].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Evento eliminarEvento = new Evento();
            eliminarEvento.id = Convert.ToInt32(txtID.Text);
            eliminarEvento.Eliminar();
            limpiarTextBox();
            nuevaLista();
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
    }
}
