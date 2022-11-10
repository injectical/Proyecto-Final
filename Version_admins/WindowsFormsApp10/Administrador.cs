using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
     class Administrador : Usuario
    {
        public Administrador(string nom, string ap, string nomUser, string correo, ADODB.Connection conn) : base(nom, ap, nomUser, correo,conn)
        {
            _nombre = nom;
            _apellido = ap;
            _nombreUsuario = nomUser;
            _rol = 2;
            _email = correo;
            _conexion = conn;

            
        }

        //este metodo crea un usuario administrador deportivo, le asigna una
        //contraseña por default 1234
        public byte darDeAlta() {

            ADODB.Recordset rs = new ADODB.Recordset();
            object contFilas;
            byte retorno = 0;

            string sqlCommit = "commit;";
            string sqlRollback = "rollback;";
            string sqlFP = "flush privileges;";

            string sql1 = "create user '" + _nombreUsuario + "'@'%' identified by '1234';";
            string sqlInsert = "insert into usuario(nombre,apellido,email,nombre_clave,rol) values('" + _nombre + "','" + _apellido + "','" + _email + "','" + _nombreUsuario + "'," + _rol + ");";
            string sqlSelectId = "select id_usuario from usuario where nombre_clave= '" + _nombreUsuario + "';";
           

            string sql2 = "grant all privileges on injectical.deportista to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql3 = "grant all privileges on injectical.deportista_group to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql4 = "grant all privileges on injectical.deportista_individual to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql5 = "grant all privileges on injectical.equipo to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql6 = "grant all privileges on injectical.disciplina to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql7 = "grant all privileges on injectical.evento to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql8 = "grant all privileges on injectical.vs to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql9 = "grant all privileges on injectical.se_juega_por to'" + _nombreUsuario + "'@'%.%.%.%';";
            string sql10 = "grant all privileges on injectical.masivo to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql11 = "grant all privileges on injectical.detalles to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql12 = "grant all privileges on injectical.banners to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql13 = "grant all privileges on injectical.pertenece to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql14 = "grant all privileges on injectical.participan to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql15 = "grant all privileges on injectical.participa to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql16 = "grant all privileges on injectical.corresponde to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql17 = "grant all privileges on injectical.tiene to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql18 = "grant all privileges on injectical.se_muestra to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql19 = "grant all privileges on injectical.participa_masivo to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql20 = "grant update (nombre,apellido,email) on injectical.usuario to  '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql21 = "grant select on injectical.usuario to '" + _nombreUsuario + "'@'%.%.%.%';";
            string sql22= "grant select on injectical.usuario_adm to '" + _nombreUsuario + "'@'%.%.%.%';";

            try
            {
                _conexion.Execute(sql1, out contFilas);
              
            }
            catch
            {
                _conexion.Execute(sqlRollback, out contFilas);
                
                return (1);//error al craer el usuario
            }

            try
            {
              _conexion.Execute(sql2, out contFilas);
                 _conexion.Execute(sql3, out contFilas);
                     _conexion.Execute(sql4, out contFilas);
                          _conexion.Execute(sql5, out contFilas);
                             _conexion.Execute(sql6, out contFilas);
                                 _conexion.Execute(sql7, out contFilas);
                _conexion.Execute(sql8, out contFilas);
                _conexion.Execute(sql9, out contFilas);
                _conexion.Execute(sql10, out contFilas);
                _conexion.Execute(sql11, out contFilas);
                _conexion.Execute(sql12, out contFilas);
                  _conexion.Execute(sql13, out contFilas);
                  _conexion.Execute(sql14, out contFilas);
                  _conexion.Execute(sql15, out contFilas);
                  _conexion.Execute(sql16, out contFilas);
                 _conexion.Execute(sql17, out contFilas);
               _conexion.Execute(sql18, out contFilas);
                 _conexion.Execute(sql19, out contFilas);
                  _conexion.Execute(sql20, out contFilas);
                 _conexion.Execute(sql21, out contFilas);
                  _conexion.Execute(sql22, out contFilas);
                  _conexion.Execute(sqlFP, out contFilas);


            }
            catch 
            {

                return (4);
            }

            try
            {
                _conexion.Execute(sqlInsert, out contFilas);
               
                rs = _conexion.Execute(sqlSelectId, out contFilas);
                
            }
            catch
            {
                _conexion.Execute(sqlRollback, out contFilas);
                return (2);//error al insertar usuario administrador en la tabla usuario
            }
            


            _id = rs.Fields[0].Value;
            string sqlInsertUsAdm = "insert into usuario_adm(id_us_adm) values(" + _id + ");";
            try
            {
               
                
                _conexion.Execute(sqlInsertUsAdm, out contFilas);
                
            }
            catch
            {
                return (3);//error al insertar el usuario administrador en la tabla usuario-adm
               
            }

            

            return retorno;
        }

        
        

        
    }
}
