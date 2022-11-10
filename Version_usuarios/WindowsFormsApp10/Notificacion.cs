using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Notificacion
    {
        public ADODB.Connection _con;
        public int _idUs;


        public Notificacion() { }

        public ADODB.Connection Con
        {
            get { return (_con); }
            set { _con = value; }
        }

        public int IdUs
        {
            get { return (_idUs); }
            set { _idUs = value; }
        }

        public ADODB.Recordset TraerNotificaciones()
        {
            object contFilas;
            string sql = "select evento.nombre,  date_format(evento.fecha_inicio, '%d-%m-%Y') " +
                            " from evento, se_envia " +
                            "WHERE se_envia.id_evento = evento.id_evento " +
                            "and evento.final = 0 and se_envia.id_us_pago="+_idUs+";";
            ADODB.Recordset rs=null;

            if (Con.State > 0) { 
            try
            {
                rs = _con.Execute(sql, out contFilas);
            }
            catch 
            {

                throw;
            }
            }
            return rs;
        }
    }
}
