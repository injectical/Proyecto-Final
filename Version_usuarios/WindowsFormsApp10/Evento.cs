using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Evento
    {
        protected int _id;
        protected string _pais;
        protected string _nombre;
        protected string _fechaInicio;
        protected Boolean _estaIniciado;
        protected Boolean _estaTerminado;
        protected string _resultado;
      
        protected ADODB.Connection _conexion;

        public Evento(int id, string pais, string nombre, 
            string fechaInicio, Boolean estaIniciado,
            Boolean estaTerminado, string resultado, ADODB.Connection cn)
        {
            _id = id;
            _pais = pais;
            _nombre = nombre;
            _fechaInicio = fechaInicio;
            _estaIniciado = estaIniciado;
            _estaTerminado = estaTerminado;
            _resultado = resultado;
            _conexion = cn;
            
        }


        public Evento() {
            _id = 0;
            _pais = "";
            _nombre = "";
            _fechaInicio = "";
            _estaIniciado = false;
            _estaTerminado = false;
            _resultado = "";
            _conexion = new ADODB.Connection();
        }

        public int id
        {
            get
            {
                return (_id);
            }
            set
            {
                _id = value;
            }
        }

        public string pais
        {
            get
            {
                return (_pais);
            }
            set
            {
                _pais = value;
            }
        }
        public string nombre
        {
            get
            {
                return (_nombre);
            }
            set
            {
                _nombre = value;
            }
        }

        public string fechaInicio
        {
            get
            {
                return (_fechaInicio);
            }
            set
            {
                _fechaInicio = value;
            }
        }

        public byte estaIniciado
        {
            get
            {
                return (_estaIniciado);
            }
            set
            {
                _estaIniciado = value;
            }

        }
        public byte estaTerminado
        {
            get
            {
                return (_estaTerminado);

            }

            set
            {
                _estaTerminado = value; ;
            }
        }
    }


}
}
