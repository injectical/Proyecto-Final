
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
        protected string _nombre;
        protected string _pais;
        protected string _fecha;
        protected string _hora;
        protected byte _inicio;
        protected byte _final;
        protected string _resultado;
        protected ADODB.Connection _conexion;


        //se crea constructor y ya se la adjudica valores false a inicio y final
        public Evento( string nombre, string pais, string fecha, string hora, string resultado, ADODB.Connection conexion)
        {
            
            _nombre = nombre;
            _pais = pais;
            _fecha = fecha;
            _hora = hora;
            _inicio = 0;
            _final = 0;
            _resultado = resultado;
            _conexion = conexion;

        }
        public Evento()
        {
            _inicio = 0;
            _final = 0;



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

        public string fecha
        {
            get
            {
                return _fecha;
            }

            set
            {
                _fecha = value;
            }

        }

        public string hora
        {
            get
            {
                return _hora;
            }

            set
            {
                _hora = value;
            }

        }

        public byte inicio
        {
            get
            {
                return _inicio;
            }

            set
            {
                _inicio = value;
            }
        }

        public byte final
        {
            get
            {
                return _final;
            }

            set
            {
                _final = value;
            }

        }
        public string resultado
        {
            get
            {
                return _resultado;
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
                return _conexion;
            }

            set
            {
                _conexion = value;
            }
        }



       public DataTable ListarEventos(bool tipo)
        {
            string sql;
           object contFilas;
            if (tipo)
            {
                 sql = "select id_evento as id,nombre,pais," +
                    " date_format(fecha_inicio, '%d-%m-%Y') " +
                    "as fecha,hora_de_inicio as hora,resultado,inicio,final from evento;";
            }
            else
            {
                sql = "select id_evento as id,nombre,pais," +
                    " date_format(fecha_inicio, '%d-%m-%Y') " +
                    "as fecha,hora_de_inicio as hora,resultado,inicio,final from evento where nombre='"+_nombre+"' and fecha_inicio='"+_fecha+"';";

            }
            ADODB.Recordset rs= new ADODB.Recordset() ;
            try
            {
                rs =_conexion.Execute(sql, out contFilas);
            }
            catch
            {
                throw;
            }
             DataTable dt = new DataTable();
                     
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.Fill(dt,rs );

            return dt;
            
        }

        public byte Guardar(bool alta)
        {

            byte resultado = 0;
            string sql;
            object contFilas;
      
            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {

                if (alta)
                {
                    sql = "insert into evento (pais,nombre,fecha_inicio,hora_de_inicio,inicio,final) values ('" + _pais + "','" + _nombre + "','" + _fecha + "','" + _hora + "'," + _inicio + "," + _final + ")";

                }
                else
                {
                    sql = "update evento set inicio=" + _inicio + ",final=" + _final + ",resultado='" + _resultado + "',fecha_inicio='"+_fecha+"',hora_de_inicio='"+_hora+"' where id_evento= " + _id + ";";

                }
                try
                {
                    _conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    return (2);//error al insertar o actualizar evento
                }
            }
            return resultado;// todo ok

        }

       
        public byte Eliminar()
        {

            byte resultado = 0;
            string sql1,sql2;
            object contFilas;
           
            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                
                sql2 = "delete from evento where id_evento=" + _id + ";";
                
                try
                {
                    _conexion.Execute(sql2, out contFilas);
                }
                catch
                {
                    return (2);//error al eliminar evento
                }
            }

            return resultado;//todo ok
        }

        public DataTable ListarEventoResumen()
        {
            
            string sql = "select id_evento as id,nombre," +
                   " date_format(fecha_inicio, '%d-%m-%Y') " +
                   "as fecha from evento where nombre='"+_nombre+"' and fecha_inicio='"+_fecha+"';";
            object contFilas;

            ADODB.Recordset rs = new ADODB.Recordset();
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
            string sql = "select * from detalles;";
            ADODB.Recordset rs = new ADODB.Recordset();

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

        public DataTable BuscarDetallesDeevento()
        {
            string sql = "select tiene.id_detalles as ID ,evento.nombre as Evento,detalles.nombre_det as 'nombre del detalle',tiene.descripcion as descripcion" +
                " from evento, tiene, detalles where detalles.id_detalles = tiene.id_detalles " +
                "and evento.id_evento = tiene.id_evento and evento.nombre = '" + _nombre + "' and evento.fecha_inicio = '" + _fecha + "'; ";
            object contFilas;
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

            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.Fill(dt, rs);

            return dt;

        }


    }
}
