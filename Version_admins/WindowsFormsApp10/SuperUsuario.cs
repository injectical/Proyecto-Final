using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class SuperUsuario : Usuario
    {

        public SuperUsuario(string nombre, string apellido, string nomUsuario, string correo, ADODB.Connection conexion) :
            base(nombre, apellido, nomUsuario, correo, conexion)
        {
            _nombre = nombre;
            _apellido = apellido;
            _nombreUsuario = nomUsuario;
            _email = correo;
            _conexion = conexion;
            _rol = 1;


        }


        public byte DarDeAlta()
        {
            byte retorno = 0; 
            ADODB.Recordset rs = new ADODB.Recordset();
            object contFilas;
            string sqlCommit = "commit;";
            string sqlRollback = "rollback;";
            string sqlFP = "flush privileges;";


            string sqlcreate= "create user '" + _nombreUsuario + "'@'%' identified by '1234';";
            string sqlInsert = "insert into usuario(nombre,apellido,email,nombre_clave,rol) values('" + _nombre + "','" + _apellido + "','" + _email + "','" + _nombreUsuario + "'," + _rol + ");";
            string sqlSelectId = "select id_usuario from usuario where nombre_clave= '" + _nombreUsuario + "';";
            string sqlGrant= "grant all privileges on *.* to '" + _nombreUsuario + "'@'%' with grant option; ";
            if (_conexion.State == 0)
            {
                return (1);//coexion cerrada

            }
            else
            {
                try
                {
                    _conexion.Execute(sqlcreate, out contFilas);
                    _conexion.Execute(sqlGrant, out contFilas);
                    _conexion.Execute(sqlFP, out contFilas);
                   
                }
                catch 
                {

                  return (2);//error al crear el usuario
                }

                try
                {
                    _conexion.Execute(sqlInsert, out contFilas);                   
                    rs = _conexion.Execute(sqlSelectId, out contFilas);
                    _id = rs.Fields[0].Value;
                    string sqlInsertUsAdm = "insert into usuario_adm(id_us_adm) values(" + _id + ");";
                    _conexion.Execute(sqlInsertUsAdm, out contFilas);
                    _conexion.Execute(sqlCommit, out contFilas);
                    

                }
                catch 
                {
                    _conexion.Execute(sqlRollback, out contFilas);
                    return (3);//error al insertar en la tabla de usuario
                    
                }                    
                
            }

            return retorno;
        }

    }
}
