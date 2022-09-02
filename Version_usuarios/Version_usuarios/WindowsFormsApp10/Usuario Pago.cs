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

        
    



        public byte guardarSolicitudProvisoria()
        {
            byte resultado = 0;
            string sql;
            object contFilas;
            _conexion = Program.conexion;


            //_conexion.Execute("use sports360", out contFilas);

            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                sql = "insert into usuario_espera_pago values ('" + _nombreUsuario + "');";
                _conexion.Execute(sql, out contFilas);


                try
                {
                    MessageBox.Show("OK! Se le enviará un mail de confirmación para que pueda acceder");

                    _conexion.Execute(sql, out contFilas);
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
