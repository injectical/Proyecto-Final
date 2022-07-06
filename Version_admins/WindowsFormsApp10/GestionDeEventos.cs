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

        private void btnAgrgar_Click(object sender, EventArgs e)

        {
            object contFilas;
            Program.conexion.Execute("use sport360", out contFilas);
            string nombre = txtnombre.Text;
            string pais = txtPais.Text;
            string fecha = txtFecha.Text;
            string horaDeInicio = txthoraInicio.Text;
            string resultado = txtresultado.Text;
           
            string sql = "insert into evento (nombre,pais,fecha,hora,resultado) values ( '" +nombre+ "','" + pais + "','" + fecha + "','" + horaDeInicio + "','" + resultado + "');";
                                          
          


            try
            {
                Program.conexion.Execute(sql, out contFilas);
            }
            catch
            {
                MessageBox.Show("Los datos no fueron ingresados correctamente ");
                return;
            }

            txtresultado.Clear();
            txtPais.Clear();
            txtnombre.Clear();
            txtFecha.Clear();
            txthoraInicio.Clear();

        }



    }
}
