using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Banner
    {
        string _ruta;
        ADODB.Connection _con;


        public Banner() {
            
        }

        public string ruta
        {
            get
            {
                return (_ruta);
            }
            set
            {
                _ruta = value;
            }
        }

        public ADODB.Connection con
        {
            get
            {
                return (_con);
            }
            set
            {
                _con = value;
            }
        }


        public byte CargarBanners()
        {
            object contFilas;
            byte resultado = 2;//todo ok
            string sql = "select ruta from banners WHERE  id_banners=1";

            ADODB.Recordset rs;

            try
            {
                rs = _con.Execute(sql, out contFilas);
            }
            catch
            {
                return 1;//error de conexion

            }
            if (rs.RecordCount > 0)
            {
                _ruta = Convert.ToString(rs.Fields[0].Value);
            }
            else
            {
                resultado = 3;//Consulta vacia
            }
           
            return resultado;
        }
    }



}
