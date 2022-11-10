using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
     class Usuario_Invitado : Usuario
    {
        public Usuario_Invitado( string nom, string ap, string nomUser,
            string correo, ADODB.Connection conn) : 
            base( nom, ap, nomUser, correo,conn)
        {
            _nombre = nom;
            _apellido = ap;
            _nombreUsuario = nomUser;
            _email = correo;
            _conexion = conn;
            _rol = 3;
        }

        public byte GuardarUserProvisorioPago()
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            object contFilas;
            byte resultado = 0;

            string sql = "insert into usario_espera_pago(nombre_clave,id_usuario) values ('" + _nombreUsuario + "',"+_id+"); ";

            if (_conexion.State == 0)
            {
                return (1);//conexion cerrada
            }
            else {
                try
                {
                    _conexion.Execute(sql, out contFilas);
                }
                catch 
                {

                    return (2);//error al insertar datos 
                }
            }

                return resultado;//todo ok 
        }

       


    }
}
