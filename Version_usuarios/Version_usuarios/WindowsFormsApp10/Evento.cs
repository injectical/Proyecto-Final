using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
        protected DateTime _fechaInicio;    
        protected bool _estaIniciado;
        protected bool _estaTerminado;
        protected string _resultado;
        protected ADODB.Connection _conexion;


        public Evento(int id, string pais, string nombre, DateTime fechaInicio, bool estaIniciado, bool estaTerminado, string resultado, ADODB.Connection conn)
        {
            _id = id;
            _pais = pais;
            _nombre = nombre;
            _fechaInicio = fechaInicio;
            _estaIniciado = estaIniciado;
            _estaTerminado = estaTerminado;
            _resultado = resultado;
            _conexion = conn;
        }

        public Evento()
        {
            _id = 0;
            _pais = "";
            _nombre = "";
            _fechaInicio = new DateTime();
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

        public DateTime fechaInicio
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

        public bool estaIniciado
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
        public bool estaTerminado
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

        public string resultado
        {
            get
            {
                return(_resultado);
            }

            set
            {
                _resultado = value;
            }
        }
        public ADODB.Connection conexion
        {
            get
            {
                return (_conexion);
            }

            set
            {
                _conexion = value;
            }

        }

        public  DataTable Listar(string deporte)
        {

            object contFilas;
            string sql = "select evento.id_evento, evento.pais, evento.nombre from evento, corresponde, disciplina where corresponde.id_evento = evento.id_evento and disciplina.nombre='" + deporte + "' and corresponde.id_disciplina = disciplina.id_disciplina";
            ADODB.Recordset rs;
            rs = Program.conexion.Execute(sql, out contFilas);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
            adapter.Fill(dt, rs);
            return dt;

        }


       


    }

}
 