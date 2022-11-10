using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp10
{
    class Detalle
    {

        protected ADODB.Connection _conexion;
        protected string _nombre;
        protected int _id;
        


        public Detalle(ADODB.Connection conexion, string nombre)
        {
            _nombre = nombre;
            _conexion = conexion;

        }
        public Detalle()
        {

        }


        public string Nombre
        {
            get { return (_nombre); }
            set { _nombre = value; }
        }

        public int Id
        {
            get { return (_id); }
            set { _id = value; }
        }

        public ADODB.Connection Conexion
        {
            get { return (_conexion); }
            set { _conexion = value; }
        }

        

       


        public byte Guardar()
        {
            byte resultado = 0;
            object contFilas;
         
            string sql = "insert into detalles(nombre_det) values ('" + _nombre + "'); ";

            if (_conexion.State == 0)
            {
                return (1);//coneccion cerrada
            }
            try
            {
                _conexion.Execute(sql, out contFilas);
            }
            catch 
            {

                return (2);//error al guardar
            }



            return resultado;//ok
            contFilas = null;
        } 


        public byte Modificar()
        {
            byte resultado = 0;
            object contFilas;
            string sql = "update detalles set nombre_det='"+_nombre+"' where id_detalles="+_id+" ";

            if (_conexion.State == 0)
            {
                return (1);//se perdio conexion
            }
            else
            {
            

                 try
                 {
                     _conexion.Execute(sql, out contFilas);
                 }
                 catch 
                 {

                     return (2);//error al insertar
                 }

            }
            return resultado;//ok
        }

        /*public DataTable Busacar()
        {
            string sql = "";
        }*/


    }
}
