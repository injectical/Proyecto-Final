using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp10
{
    class DetalleDeEvento
    {
        protected int _idEvento;
        protected int _idDetalle;
        protected string _descripcion;
        protected ADODB.Connection _conexion;

        public DetalleDeEvento(string desc, int idEv, int idDet, ADODB.Connection con)
        {
            _idDetalle = idDet;
            _idEvento = idEv;
            _descripcion = desc;
            _conexion = con;
        }
        public DetalleDeEvento() { }

        public string Descripcion
        {
            set { _descripcion = value; }
            get { return (_descripcion); }
        }

        public int IdeEvento
        {
            set { _idEvento = value; }
            get { return (_idEvento); }
        }

        public int IdDetalle
        {
            set { _idDetalle = value; }
            get { return (_idDetalle); }
        }

        public ADODB.Connection Conexion
        {
            set { _conexion = value; }
            get { return (_conexion); }
        }

        public byte AsociarDeatlle()
        {
            object contFilas;
            byte resultado = 0;
            string sql = "insert into tiene(id_evento, id_detalles, descripcion) values("+_idEvento+", "+_idDetalle+", '"+_descripcion+"'); ";

            if (_conexion.State == 0)
            {
                return 1;
            }
            else
            {
                try
                {
                    _conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    return 2;

                }
                return resultado;
                contFilas = null;
            }
            

        }

        public byte desasociarDetalle()
        {
            byte resultado=0;
            string sql = "delete from tiene where id_detalles = "+_idDetalle+";";
            object contfilas;
            if (_conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                try
                {
                    _conexion.Execute(sql, out contfilas);
                }
                catch
                {
                    return 2;//problema para borrar

                }
            }
            return resultado;
        }
       
    }
}
