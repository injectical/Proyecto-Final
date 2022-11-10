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
        protected string _fechaInicio;
        protected byte _estaIniciado;
        protected byte _estaTerminado;
        protected string _resultado;
        protected ADODB.Connection _conexion;


        public Evento(int id, string pais, string nombre, string fechaInicio, byte estaIniciado, byte estaTerminado, string resultado, ADODB.Connection conn)
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

        public string resultado
        {
            get
            {
                return (_resultado);
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

        public DataTable Listar(string deporte)
        {

            object contFilas;

            string sql = "select  evento.pais, evento.nombre from evento, corresponde, disciplina where corresponde.id_evento = evento.id_evento and disciplina.nombre='" + deporte + "' and corresponde.id_disciplina = disciplina.id_disciplina";
            ADODB.Recordset rs;
            try
            {
                rs = _conexion.Execute(sql, out contFilas);
            }
            catch
            {

                throw;
            }
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
            adapter.Fill(dt, rs);
            return dt;

        }

        public DataTable Buscar(bool tipo)
        {

            object contFilas;
            string sql;
            ADODB.Recordset rs;

            if (tipo)
            {
                sql = "select id_evento as id,nombre as Nombre,pais as Pais," +
                       " date_format(fecha_inicio, '%d-%m-%Y') " +
                       "as Fecha,hora_de_inicio as Hora,Resultado from evento where final=1";
            }
            else
            {
                sql = "select id_evento as id,nombre as Nombre,pais as Pais," +
                     " date_format(fecha_inicio, '%d-%m-%Y') " +
                     "as Fecha,hora_de_inicio as Hora from evento where inicio=0;";

            }
               
                try
                {
                    rs = _conexion.Execute(sql, out contFilas);
                }
                 catch
                    {

                      throw;
                     }

            DataTable dt = new DataTable();

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.Fill(dt, rs);

            return dt;






        }

        public DataTable ListarDetalles()
        {
            object contFilas;
            string sql;
            ADODB.Recordset rs;



            sql = "select detalles.nombre_det as 'Nombre del detalle',tiene.descripcion" +
                " as Descripcion from evento, tiene, detalles " +
                "where detalles.id_detalles = tiene.id_detalles " +
                "and evento.id_evento = tiene.id_evento and evento.id_evento = "+id+";";



            try
            {
                rs = _conexion.Execute(sql, out contFilas);
            }
            catch
            {

                throw;
            }

            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.Fill(dt, rs);
            return dt;

        }

        public DataTable MostarEnProceso()
        {
            object contFilas;
            ADODB.Recordset rs;
            string sql = "select id_evento as id,nombre as Nombre,pais as Pais," +
                       " date_format(fecha_inicio, '%d-%m-%Y') " +
                       "as Fecha,hora_de_inicio as Hora,resultado as Resultado from evento where inicio=1 and final=0";
            try
            {
                rs = _conexion.Execute(sql, out contFilas);
            }
            catch
            {

                throw;
            }

            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.Fill(dt, rs);
            return dt;


        }
    }
}


 