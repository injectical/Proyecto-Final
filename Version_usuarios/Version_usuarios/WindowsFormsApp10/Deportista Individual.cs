using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Deportista_Individual : Deportista
    {
        public Deportista_Individual(int id, DateTime fechaNac, string nombre, string apellido, string pais, ADODB.Connection conn) : base(id, fechaNac, nombre, apellido, pais, conn)
        {

        }
    }
}
