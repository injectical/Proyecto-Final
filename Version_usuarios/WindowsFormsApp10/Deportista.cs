using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Deportista
    {

        protected int _idDeportista;
        protected string _fechaNacimiento;
        protected string _nombre;
        protected string _apellido;
        protected string _pais;
        protected Disciplina _disciplina;
        protected ADODB.Connection _conexion;

        public Deportista(int id, string fechaNac, string nombre, string apellido, string pais, ADODB.Connection cn)
        {
            _idDeportista = id;
            _fechaNacimiento = fechaNac;
            _nombre = nombre;
            _apellido = apellido;
            _pais = pais;
            _conexion = cn;
        }

        public Deportista() {
            _idDeportista = 0;
            _fechaNacimiento = "";
            _nombre = "";
            _apellido = "";
            _pais = "";
            _disciplina = new Disciplina();
            _conexion = new ADODB.Connection();


        }



        public int idDeportista
        {
            get
            {
                return _idDeportista;
            }
            set
            {
                _idDeportista = value;
            }
        }


        public string fechaNacimiento
        {
            get
            {
                return _fechaNacimiento;

            }

            set
            {
                _fechaNacimiento = value;
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

        public string apellido
        {
            get
            {
                return _apellido;

            }

            set
            {
                _apellido = value;
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


    }





}
}
