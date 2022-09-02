using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Idioma
    {
        protected int _id;
        protected string _idioma;
        protected ADODB.Connection _conexion;

        public Idioma(int id, string idioma, ADODB.Connection conn)
        {
            _id = id;
            _idioma = idioma;
            _conexion = conn;
        }

        public Idioma()
        {
            _id = 0;
            _idioma = "";
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

        public string idioma
        {
            get
            {
                return _idioma;
            }

            set
            {
                _idioma = value;
            }
        }

        public ADODB.Connection conexion
        {
            get
            {
                return _conexion;
            }

            set
            {
                _conexion = value;
            }
        }
    }
}
