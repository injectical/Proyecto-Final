using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Deportista_Grupal : Deportista
    {
        protected string _rolEnEquipo;

        public Deportista_Grupal(int id, DateTime fechaNac, string nombre, string apellido, string pais, ADODB.Connection conn, string rolEquipo) : base(id, fechaNac, nombre, apellido, pais, conn)
        {
            _rolEnEquipo = rolEquipo;
        }

        public string rolEnEquipo
        {
            get
            {
                return _rolEnEquipo;
            }

            set
            {
                _rolEnEquipo = value;
            }
        }
    }
}
