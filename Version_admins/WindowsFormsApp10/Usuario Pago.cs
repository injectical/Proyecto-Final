using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Usuario_Pago : Usuario

    


    {
        protected bool _pago;
        protected string _fechaDePago;

        public Usuario_Pago( string nom, string ap, string nomUser, string correo,
               ADODB.Connection conn) : base ( nom, ap, nomUser, correo, conn)
        {
            _pago = true ;
          
        }

        public Usuario_Pago():base ()
        {
            _pago = true;
        }
        public bool pago
        {
            get
            {
                return (_pago);
            }
            set
            {
                _pago = value;
            }
        }

        public string fechaDePago
        {
            get
            {
                return (_fechaDePago);
            }

            set
            {
                _fechaDePago = value;
            }

        }

       
        //TOMA LOS DATOS DE USUARIO_PROVISORIO_PAGO Y LOS PASA A LA TABLA USUARIO_PAGO
        public byte GuardarMembresia()
        {
            byte resultado = 0;//todo ok
            ADODB.Recordset rsid = new ADODB.Recordset();
            ADODB.Recordset rsFecha=new ADODB.Recordset();
            string sqlIdUsuario = "select usuario.id_usuario from usuario, usuario_espera_pago" +
                " where usuario.nombre_clave = usuario_espera_pago.nombre_clave " +
                "and usuario_espera_pago.nombre_clave='"+_nombreUsuario+"';";

           
            string sqlDelete  = "delete from usuario_espera_pago where nombre_clave='" + _nombreUsuario + "';";
            string sqlfecha= "select date_format(CURDATE(),'%y-%m-%d');";
            string sqlUpdateRol = "update usuario set rol = 4 where nombre_clave = '"+_nombreUsuario+"';";
            string sqlGrant="grant select  on injectical.notificaciones to '" + _nombreUsuario + "'@'%';";
            string sqlGrant1 = "grant insert  on injectical.se_envia to '" + _nombreUsuario + "'@'%';";
            string sqlfp = "flush privileges;";
            object contFilas;
           
            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                

                try
                {
                    rsid=_conexion.Execute(sqlIdUsuario, out contFilas);
                    rsFecha= _conexion.Execute(sqlfecha, out contFilas);



                }
                catch
                {
                    return (2);//error al obtener id y fecha
                }

                _fechaDePago = Convert.ToString( rsFecha.Fields[0].Value);
                _id =rsid.Fields[0].Value;
                string sqlInsertUsuarioPago = "insert into usuario_pago (id_us_pago,fecha_pago,pago) " +
               "values (" + _id + ",'" + _fechaDePago + "'," + _pago + ");";

                try
                {
                    _conexion.Execute(sqlInsertUsuarioPago, out contFilas);
                    _conexion.Execute(sqlUpdateRol, out contFilas);
                    _conexion.Execute(sqlDelete, out contFilas);
                    _conexion.Execute("commit", out contFilas);
                    _conexion.Execute(sqlGrant, out contFilas);
                    _conexion.Execute(sqlGrant1, out contFilas);
                    _conexion.Execute(sqlfp, out contFilas);

                }
                catch
                {
                    _conexion.Execute("rollback", out contFilas);
                    return (3);//error al insertar en usuario_Pago

                }

            }

            return resultado;


        }


    }
}

