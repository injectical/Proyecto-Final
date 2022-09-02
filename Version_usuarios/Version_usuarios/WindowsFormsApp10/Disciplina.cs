using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Disciplina
    {
        protected int _id;
        protected string _nombre;
        protected ADODB.Connection _conexion;


        public Disciplina(int id, string nombre, ADODB.Connection conn)
        {
            _id = id;
            _nombre = nombre;
            _conexion = conn;
        }

        public Disciplina()
        {
            _id = 0;
            _nombre = "";
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
