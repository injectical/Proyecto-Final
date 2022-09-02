using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Versus : Evento
    {
        protected int _idEquipo1;
        protected int _idEquipo2;
        protected int _resultadoEquipo1;
        protected int _resultadoEquipo2;

        public Versus(int id, string pais, string nombre, DateTime fechaInicio, bool estaIniciado, bool estaTerminado, string resultado, ADODB.Connection conn, int idEquipo1, int idEquipo2, int resultadoEquipo1, int resultadoEquipo2) : base(id, pais, nombre, fechaInicio, estaIniciado, estaTerminado, resultado, conn)
        {

            _idEquipo1 = idEquipo1;
            _idEquipo2 = idEquipo2;
            _resultadoEquipo1 = resultadoEquipo1;
            _resultadoEquipo2 = resultadoEquipo2;
        }

       

        public int idEquipo1
        {
            get
            {
                return _idEquipo1;
            }

            set
            {
                _idEquipo1 = value;
            }
        }

             public int idEquipo2
        {
            get
            {
                return _idEquipo2;
            }

            set
            {
                _idEquipo2 = value;
            }
        }

             public int resultadoEquipo1
        {
            get
            {
                return _resultadoEquipo1;
            }

            set
            {
                _resultadoEquipo1 = value;
            }

        }

        public int resultadoEquipo2
        {
            get
            {
                return _resultadoEquipo2;
            }

            set
            {
                _resultadoEquipo2 = value;
            }

        }


    }
}
