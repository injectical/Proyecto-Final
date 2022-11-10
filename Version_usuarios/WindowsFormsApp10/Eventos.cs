using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace WindowsFormsApp10
{
    public partial class btnFinalizados : Form
    {
        


        public btnFinalizados()
        {
           
            InitializeComponent();
        }
        
        //DATOS FIJOS PARA VISUALIZAR SOLO, HAY QUE VER COMO HACER LOS SELECT Y VOLCARLOS EN EL DATAGRID
     /*   private List<Evento> GetFutbol()
        {
            var listaFutbol = new List<Evento>();
            listaFutbol.Add(new Evento()
            {
                Id = 0001,
                Pais = "Uruguay",
                Nombre = "Campeonato Uruguayo: torneo intermedio",
                FechaInicio = "06 / 05 / 2022 14:00",
                Resultado = "Defensor 4 - 2 Danubio",
                Tipo = "futbol"
            });

            listaFutbol.Add(new Evento()
            {
                Id = 0005,
                Pais = "Argentina",
                Nombre = "Torneo Argentino",
                FechaInicio = "15 / 05 / 2022 16:00",
                Resultado = "Boca 1 - 1 River",
                Tipo = "futbol"
            });


            listaFutbol.Add(new Evento()
            {
                Id = 0002,
                Pais = "Uruguay",
                Nombre = "Campeonato Uruguayo: torneo intermedio",
                FechaInicio = "07 / 05 / 2022 14:00",
                Resultado = "Nacional 4 - 2 Plaza Colonia",
                Tipo = "futbol"
            });

            return listaFutbol;
        }
            private List<Evento> GetBasquet()
            {
                var listaBasquet = new List<Evento>();
                listaBasquet.Add(new Evento()
                {
                    Id = 0008,
                    Pais = "Uruguay",
                    Nombre = "LUB",
                    FechaInicio = "23 / 06 / 2022 22:00",
                    Resultado = "Union Atletica 89 - 78 Penarol",
                    Tipo = "Basquet"
                });

            listaBasquet.Add(new Evento()
            {
                Id = 0010,
                Pais = "Uruguay",
                Nombre = "LUB",
                FechaInicio = "25 / 06 / 2022 21:00",
                Resultado = "Aguada 89 - 78 Bigua",
                Tipo = "Basquet"
            });

            return listaBasquet;
            }

     
       */

        private void Eventos_Load(object sender, EventArgs e)
        {
            if (Program.rol == 4)
            {
                grbSuscripcion.Visible = true;
            }
            else{
                grbSuscripcion.Visible = false;
            }

        }

     

        private void lnkBasquet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /* Evento evento = new Evento();

            dataGridDeportes.DataSource = evento.Listar("basquet");*/

        }

        private void dataGridDeportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Evento evento = new Evento();
            int posicion;
            string id;
            int IDEvento;
            posicion = dataGridDeportes.CurrentRow.Index;

            id = dataGridDeportes[0, posicion].Value.ToString();
            txtIDEvntSuscrip.Text = id;
            txtsuscripcion.Text= dataGridDeportes[1, posicion].Value.ToString();

            int.TryParse(id, out IDEvento);
            evento.id = IDEvento;
            evento.conexion = Program.conexion;

            try
            {
                dataGridDetalles.DataSource = evento.ListarDetalles();
            }
            catch 
            {

                MessageBox.Show("error al listar detalle");
            }

            evento = null;
        }

        private void lnkFutbol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Evento evento = new Evento();
            evento.conexion = Program.conexion;
            dataGridDeportes.DataSource = evento.Listar("futbol");*/

        }

        private void btnBuscar_Click(object sender, EventArgs e)//finalizados

        {
            ApiResultados apiR = new ApiResultados();
            string evento;
            int posicion;
            try
            {
                evento = apiR.SerializarEventosFinalizados();
               

            }
            catch
            {

                MessageBox.Show("error de conexion");
                
                return;
            }
            if (evento.Equals("1"))
            {
                MessageBox.Show("No hay ningun evento FInalizado");
            }
            else
            {
                dataGridDeportes.DataSource = apiR.Deserializar(evento);
                posicion = dataGridDeportes.CurrentRow.Index;
                dataGridDeportes.Columns[0].Visible = false;
                apiR = null;
                if (Program.rol == 3)
                {
                    Program.frmBanners = new Banners();
                    Program.frmBanners.Show();
                    Program.frmBanners.MdiParent = Program.frmPrincipal;
                }
            }
            /*int posicion;
            bool tipo = false;
            
            Evento evento = new Evento();
            evento.conexion = Program.conexion;
            
            try
            {
                
                dataGridDeportes.DataSource = evento.Buscar(tipo);
               
            }
            catch 
            {

                MessageBox.Show("error al mostrar eventos");
            }
            posicion = dataGridDeportes.CurrentRow.Index;

            dataGridDeportes.Columns[0].Visible = false;*/



        }

        private void btnPorComenzar_Click(object sender, EventArgs e)
        {
            
            ApiResultados apiR = new ApiResultados();
            string evento;
            int posicion;
            try
            {
                evento = apiR.SerializarEventosSinIniciar();
               
            }
            catch
            {

                MessageBox.Show("error de conexion");
                
                return;
            }
            if (evento.Equals("1"))
            {
                MessageBox.Show("No hay ningun evento Por comenzar ");
            }
            else
            {
                dataGridDeportes.DataSource = apiR.Deserializar(evento);
                posicion = dataGridDeportes.CurrentRow.Index;
                dataGridDeportes.Columns[0].Visible = false;
                apiR = null;
                if (Program.rol == 3)
                {
                    Program.frmBanners = new Banners();
                    Program.frmBanners.Show();
                    Program.frmBanners.MdiParent = Program.frmPrincipal;
                }
            }
            /*bool tipo = true;
            Evento evento = new Evento();
            evento.conexion = Program.conexion;
            try
            {
                dataGridDeportes.DataSource = evento.Buscar(tipo);
            }
            catch
            {

                MessageBox.Show("error al mostrar eventos");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuscripcion_Click(object sender, EventArgs e)
        {
            if (txtsuscripcion.Text.Equals(""))
            { return; }
            else { 
            Usuario_Pago uP = new Usuario_Pago();
            uP.conexion = Program.conexion;
            uP.id = Program.id;
            int IDevento;
            int.TryParse(txtIDEvntSuscrip.Text, out IDevento);

            switch (uP.InsertarNotificacion(IDevento))
            {
                case 0:
                    MessageBox.Show("suscripcion exitosa");
                    break;
                case 1:
                    MessageBox.Show("Perdida de conexion");
                    break;
                case 2:
                    MessageBox.Show("Error al insertar en la tablaa de notificaciones");
                    break;
                    

            }
            }
        }

        private void btnEnProceso_Click(object sender, EventArgs e)
        {
            ApiResultados apiR = new ApiResultados();
            string evento;
            int posicion;
            try
            {
                evento = apiR.SerializarEventosEnProceso();
                
                
            }
            catch
            {

                MessageBox.Show("error de conexion");

                return;
            }
            if (evento.Equals("1"))
            {
                MessageBox.Show("No hay ningun evento en proceso");
            }
            else { 
            dataGridDeportes.DataSource = apiR.Deserializar(evento);
            posicion = dataGridDeportes.CurrentRow.Index;
            dataGridDeportes.Columns[0].Visible = false;
            apiR = null;
            if (Program.rol == 3)
            {
                Program.frmBanners = new Banners();
                Program.frmBanners.Show();
                Program.frmBanners.MdiParent = Program.frmPrincipal;
            }
            }

        }
    }
    
}

      
    


