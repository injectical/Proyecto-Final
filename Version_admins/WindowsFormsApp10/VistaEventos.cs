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
    public partial class VistaEventos : Form
    {
      
        public VistaEventos()
        {
         
            InitializeComponent();
        }

        //DATOS PARA PRUEBA DE LA VISTA DE EVENTOS
        public static List<Evento> GetUruguay()
        {
            var listaUruguay = new List<Evento>();
            listaUruguay.Add(new Evento()
            {
                Id = 0001,
                Pais = "Uruguay",
                Nombre = "Campeonato Uruguayo: torneo intermedio",
                FechaInicio = "06 / 05 / 2022 14:00",
                Resultado = "Defensor 4 - 2 Danubio",
                Tipo = "Ftbol"
            });

            listaUruguay.Add(new Evento()
            {
                Id = 0005,
                Pais = "Uruguay",
                Nombre = "Rally las piedras",
                FechaInicio = "15 / 05 / 2022 16:00",
                Resultado = "Pepe Rodriguez 1ro, Juan Lopez 2do",
                Tipo = "Automovilismo"
            });


            listaUruguay.Add(new Evento()
            {
                Id = 0002,
                Pais = "Uruguay",
                Nombre = "LUB",
                FechaInicio = "07 / 05 / 2022 14:00",
                Resultado = "Nacional 66 - 84 Plaza Colonia",
                Tipo = "Futbol"
            });

            return listaUruguay;
        }
        public static List<Evento> GetArgentina()
        {
            var listaArgentina = new List<Evento>();
            listaArgentina.Add(new Evento()
            {
                Id = 0008,
                Pais = "Argentina",
                Nombre = "Copa Argentina",
                FechaInicio = "23 / 06 / 2022 22:00",
                Resultado = "Racing 4 - Laferrere 0",
                Tipo = "Futbol"
            });

            listaArgentina.Add(new Evento()
            {
                Id = 0010,
                Pais = "Argentina",
                Nombre = "Rally argentino: etapa 1",
                FechaInicio = "25 / 06 / 2022 21:00",
                Resultado = "Juan Lopez 1ro, Seba Perez 2do, Maria Gutierrez 3ra",
                Tipo = "Automovilismo"
            });

            return listaArgentina;
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
