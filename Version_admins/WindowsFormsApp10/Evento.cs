
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
        protected string _inicio;
        protected string _final;
        protected string _resultado;
        protected ADODB.Connection _conexion;


        //se crea constructor y ya se la adjudica valores false a inicio y final
        public Evento(int id, string nombre, string pais, string fecha, string hora, string inicio, string final, string resultado, ADODB.Connection conexion)
        {
            _id = id;
            _nombre = nombre;
            _pais = pais;
            _fecha = fecha;
            _hora = hora;
            _inicio = inicio;
            _final = final;
            _resultado = resultado;
            _conexion = conexion;

        }
        public Evento()
        {
            _id = 0;
            _nombre = "";
            _pais = "";
            _fecha = "";
            _hora = "";
            _inicio = "false";
            _final = "false";
            _resultado = "";
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

        public string inicio
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

        public string final
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



        public DataTable Listar()
        {

            object contFilas;
            string sql = "select * from evento";
            ADODB.Recordset rs;
            _conexion = Program.conexion;
            rs = _conexion.Execute(sql, out contFilas);
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter();
            adapter.Fill(dt, rs);
            return dt;

        }

        public byte Guardar(bool alta)
        {
            byte resultado = 0;
            string sql;
            object contFilas;
            _conexion = Program.conexion;
            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {

                if (alta)
                {
                    sql = "insert into evento (pais,nombre,fecha_inicio,hora_de_inicio,inicio,final,resultado) values ('" + _pais + "','" + _nombre + "','" + _fecha + "','" + _hora + "'," + _inicio + "," + _final + ",'" + _resultado + "')";

                }
                else
                {
                    sql = "update evento set nombre ='" + _nombre + "',pais='" + _pais + "',fecha_inicio='" + _fecha + "',hora_de_inicio='" + _hora + "',inicio=" + _inicio + ",final=" + _final + ",resultado='" + _resultado + "' where id_evento= " + _id + ";";

                }
                try
                {
                    _conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    return (2);
                }
            }
            return (3);

        }

        /*
         
            SE PRESENTARON UNA SERIE DE PROBLEMAS PARA PONER TODAS LAS SENTENCIAS EN UN MISMO METODO
        POR ESTE MOTIVO SE CREO EL METODO Eliminar()
        */
        public byte Eliminar()
        {

            byte resultado = 0;
            string sql1,sql2;
            object contFilas;
            _conexion = Program.conexion;
            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                sql1 = "delete from corresponde where id_evento=" + _id + ";";

                sql2 = "delete from evento where id_evento=" + _id + ";";
                _conexion.Execute(sql1, out contFilas);
                _conexion.Execute(sql2, out contFilas);



                try
                {
                }
                catch
                {
                    return (2);
                }
            }

            return (3);
        }


    }
}
