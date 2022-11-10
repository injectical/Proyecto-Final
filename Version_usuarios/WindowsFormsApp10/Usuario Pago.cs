using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    class Usuario_Pago : Usuario


    {
               

        public Usuario_Pago():base()
        {

        }    
   
        public byte guardarSolicitudProvisoria()
        {
            byte resultado = 0;//todo ok
            string sql;
            object contFilas;
            

            //_conexion.Execute("use sports360", out contFilas);

            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                sql = "insert into usuario_espera_pago(nombre_clave) values ('" + _nombreUsuario + "');";


                try
                {

                    _conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    return (2);//error al insertar en la tabla de usuario espera pago
                }
            }
            return resultado;

        }

        public byte InsertarNotificacion(int idevento)
        {
            byte resultado = 0;//todo ok
            string sql;
            object contFilas;

            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                sql = "insert into se_envia (id_us_pago,id_not,id_evento) values ("+_id+",1,"+idevento+");";


                try
                {

                    _conexion.Execute(sql, out contFilas);
                }
                catch
                {
                    return (2);//error al insertar notificacion
                }
            }
            return resultado;

        }
    }
}
