using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Notificación
    {
        protected int _id;
        protected string _detalle;
        protected ADODB.Connection _conexion;

        public Notificación(int id, string detalle, ADODB.Connection conn)
        {
            _id = id;
            _detalle = detalle;
            _conexion = conn;
        }

        public Notificación()
        {
            _id = 0;
            _detalle = "";
            _conexion = new ADODB.Connection();
        }

        public int id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string detalle
        {
            get
            {
                return _detalle;
            }

            set
            {
                _detalle = value;
            }
        }
    }
}
