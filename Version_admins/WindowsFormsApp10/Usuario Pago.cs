using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Usuario_Pago : Usuario


    {
        protected byte _pago;
        protected string _fechaDePago;

        public Usuario_Pago(int id, string nom, string ap, string nomUser, string correo, string pass, int rol, byte pago, string fechaPago, ADODB.Connection conn) : base(id, nom, ap, nomUser, correo, pass, rol, conn)
        {
            _pago = pago;
            _fechaDePago = fechaPago;
        }

        public Usuario_Pago()
        {

        }
        public byte pago
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
            byte resultado = 0;
            string sql, sql2;
            object contFilas;
            _conexion = Program.conexion;

            //_conexion.Execute("use sports360", out contFilas);

            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                sql = "insert into usuario_pago (id_us_pago,nombre_clave) select id_usuario,usuario.nombre_clave from usuario, usuario_espera_pago where usuario.nombre_clave = usuario_espera_pago.nombre_clave;";
                sql2 = "delete from usuario_espera_pago where nombre_clave='" + _nombreUsuario + "';";

                try
                {
                    _conexion.Execute(sql, out contFilas);
                    _conexion.Execute(sql2, out contFilas);

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

