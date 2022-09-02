using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Usuario_Provisorio : Usuario
    {
        public Usuario_Provisorio(int id, string nom, string ap, string nomUser, string correo, string pass, int rol, byte pago, DateTime fechaPago, ADODB.Connection conn) : base(id, nom, ap, nomUser, correo, pass, rol, conn)
        {
        }

        public Usuario_Provisorio()
        {

        }

        public byte provisorioGuardar()
        {
            byte resultado = 0;
            string sql;
            object contFilas;
            _conexion = Program.conexion;

            _conexion.Open("miodbc", "creador", " ");
            //_conexion.Execute("use sports360", out contFilas);

            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {
                sql = "insert into usuario_provisorio (nombre,apellido,email,nombre_clave,contraseña) values ('" + _nombre + "','" + _apellido + "','" + _email + "','" + _nombreUsuario + "','" + _contraseña + "')";
                try
                {
                    _conexion.Execute(sql, out contFilas);
                    _conexion.Close();

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
