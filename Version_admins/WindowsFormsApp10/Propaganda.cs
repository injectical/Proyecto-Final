using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Propaganda
    {

        protected string _ruta;
        protected ADODB.Connection _conexion;
        protected byte _cantidad_de_banners;

        public Propaganda()
        {
              
        }

        public string Ruta
        {
            get { return (_ruta); }
            set { _ruta = value; }
        }

        public byte Cantidad_de_banners
        {
            get { return (_cantidad_de_banners); }
            set { _cantidad_de_banners = value; }
        }

        public byte obtenerRuta()
        {
            byte resultado=0;
            ADODB.Recordset rs = new ADODB.Recordset();
            string sql = "select ruta from banners;";
            object contFilas;
            if (_conexion.State == 0)
            {
                return (1);//conexion cerrada
            }
            else
            {
                try
                {
                    rs = _conexion.Execute(sql, out contFilas);
                }
                catch
                {

                    throw;
                }

                _ruta = Convert.ToString(rs.Fields[0].Value);
            }

            return resultado;
        }

        
        


    }




}
