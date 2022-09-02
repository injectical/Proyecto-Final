using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Equipo
    {
        protected int _id;
        protected string _nombre;
        protected string _pais;
        protected ADODB.Connection _conexion;

        public Equipo(int id, string nombre, string pais, ADODB.Connection conn)
        {
            _id = id;
            _nombre = nombre;
            _pais = pais;
            _conexion = conn;
        }
        public Equipo()
        {
            _id = 0;
            _nombre = "";
            _pais = "";
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

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string pais
        {
            get
            {
                return _pais;
            }

            set
            {
                _pais = value;
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
