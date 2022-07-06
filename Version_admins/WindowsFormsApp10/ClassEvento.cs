
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp10
{
    class ClassEvento
    {
        private string nombre { get; set; }
        private string pais { get; set; }
        private string fecha { get; set; }//anio mes y dia
        private string hora { get; set; }
        private bool inicio { get; set; }
        private bool final { get; set; }
        private string resultado { get; set; }


        //se crea constructor y ya se la adjudica valores false a inicio y final
        public ClassEvento(string nombre, string pais, string fecha, string hora,string resultado)
        {

            this.nombre = nombre;
            this.pais = pais;
            this.fecha = fecha;
            this.hora = hora;
            this.inicio = false;
            this.final = false;
            this.resultado = resultado;

        }



    }




}
