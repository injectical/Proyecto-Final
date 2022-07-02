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
    public partial class Eventos : Form
    {
        public static VistaEventos frmVistaEventos;

        public List<Evento> Uruguay { get; set; }
        public List<Evento> Argentina { get; set; }
        public Eventos()
        {
            Uruguay = VistaEventos.GetUruguay();
            Argentina = VistaEventos.GetArgentina();
            InitializeComponent();
        }



        //LOS ESTILOS VISUALES DE LAS VENTANAS SE IRAN PULIENDO, SE MUESTRA UN DISEÑO TENTATIVO

        private void Eventos_Load(object sender, EventArgs e)
        {

        }
        //DE ESTA FORMA, CUANDO SE CLICKEA EN UN LINK SE FILTRAN LOS RESULTADOS

        
        private void lnkUruguay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var elementos = this.Uruguay;
            frmVistaEventos = new VistaEventos();
            frmVistaEventos.Show();
            frmVistaEventos.dgvResultados.DataSource = elementos;

        }

        private void lnkArgentina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var elementos = this.Argentina;
            frmVistaEventos = new VistaEventos();
            frmVistaEventos.Show();
            frmVistaEventos.dgvResultados.DataSource = elementos;
        }

        private void lnkFutbol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
