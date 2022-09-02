using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Masivo : Evento
    {
        public Masivo(int id, string pais, string nombre, DateTime fechaInicio, bool estaIniciado, bool estaTerminado, string resultado, ADODB.Connection conn) : base(id, pais, nombre, fechaInicio, estaIniciado, estaTerminado, resultado, conn)
        {
        }
    }
}
