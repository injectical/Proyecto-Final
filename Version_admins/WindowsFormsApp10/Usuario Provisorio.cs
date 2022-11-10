using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Usuario_Provisorio : Usuario
    {
        private string _pass;

        public Usuario_Provisorio(string pass,string nombre,string apellido,string nombreUsuario,string 
            correo,ADODB.Connection conexion) : base( nombre, apellido, nombreUsuario,correo,conexion  )
        {
            _rol = 3;//se le asigna el rol de forma predeterminada ya que este va a ser un usuario invitado
            _nombre = nombre;
            _apellido = apellido;
            _conexion = conexion;
            _pass = pass;
            _nombreUsuario = nombreUsuario;
            _conexion = conexion;
         
       
        }

        public string Pass
        {
            get
            {
                return (_pass);
            }

            set
            {
                _pass = value;
            }
        }

        // este metodo es para usuarlo cuando se da de alta a un usuario desde la tabla de espera
        public byte altaDeUsuarioEnEspera()
        {
            ADODB.Recordset rs= new ADODB.Recordset();
            byte resultado=0;
            object contFilas;
            string sql1 = "create user '"+_nombreUsuario+"'@'%' identified by '"+_pass+"';";
            string sqlDelet = "delete from usuario_provisorio where nombre_clave='" + _nombreUsuario + "';";
             try
            {
            
              _conexion.Execute(sql1, out contFilas);
              
            }
            catch 
            {
               
              return (2);//error al crear el usuario
            }

            string sql2 = "grant select  on injectical.usuario to '"+_nombreUsuario+"';";
            string sql3 = "grant select on  injectical.deportista to '" + _nombreUsuario+"';";
            string sql4 = "grant select on  injectical.deportista_group to '" + _nombreUsuario + "';";
            string sql5 = "grant select on  injectical.deportista_individual to '" + _nombreUsuario + "';";
            string sql6= "grant select on  injectical.equipo to '" + _nombreUsuario + "';";
            string sql7 = "grant select on  injectical.disciplina to '" + _nombreUsuario + "';";
            string sql8 = "grant select on  injectical.evento to '" + _nombreUsuario + "';";
            string sql9 = "grant select on  injectical.vs to '" + _nombreUsuario + "';";
            string sql10 = "grant select on  injectical.se_juega_por to '" + _nombreUsuario + "';";
            string sql11 = "grant select on  injectical.masivo to '" + _nombreUsuario + "';";
            string sql12 = "grant select on  injectical.detalles to '" + _nombreUsuario + "';";
            string sql13 = "grant select on  injectical.usuario_invitado to '" + _nombreUsuario + "';";
            string sql14 = "grant select on  injectical.banners to '" + _nombreUsuario + "';";
            string sql15 = "grant select on  injectical.idioma to '" + _nombreUsuario + "';";
            string sql16 = "grant select on  injectical.pertenece to '" + _nombreUsuario + "';";
            string sql17 = "grant select on  injectical.participan to '" + _nombreUsuario + "';";
            string sql18 = "grant select on  injectical.participa to '" + _nombreUsuario + "';";
            string sql19 = "grant select on  injectical.corresponde to '" + _nombreUsuario + "';";
            string sql20 = "grant select on  injectical.tiene to '" + _nombreUsuario + "';";
            string sql21 = "grant select on  injectical.prefiere to '" + _nombreUsuario + "';";
            string sql22 = "grant select on  injectical.se_muestra to '" + _nombreUsuario + "';";
            string sql23 = "grant select on  injectical.participa_masivo to '" + _nombreUsuario + "';";
            string sql24= "grant insert on  injectical.usuario_espera_pago to '" + _nombreUsuario + "'; ";
            string sql26 = "grant select on  injectical.se_envia to '" + _nombreUsuario + "'; ";
            string sql25= "grant update (nombre,apellido,email) on  injectical.usuario to '" + _nombreUsuario + "'; ";
            string commit = "commit;";
            string rollback = "rollback;";
            string sqlfp = "flush privileges;";

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
                _conexion.Execute(sql23, out contFilas);

                _conexion.Execute(sql24, out contFilas);
                _conexion.Execute(sql25, out contFilas);
                _conexion.Execute(sql26, out contFilas);

                _conexion.Execute(sqlfp, out contFilas);
               

           }
            catch
            {
                return (3);//error al asignar permisos
            }
            // luego de realizar el insert en usuario  se realiza una consulta en la tabla usuario para sabar con que
            // ID quedo registrado ese usuario, 
            //sigiente paso es memorisar ese id para insertar el usuario en la tabla usuario_invitadao
            string sqluse = "use  injectical;";
            string sqlInsert ="insert into usuario (nombre,apellido,email,rol,nombre_clave) values ('" + _nombre + "','" + _apellido + "','" + _email + "','" + _rol + "','" + _nombreUsuario + "')";
            string sqlSelectId="select id_usuario from usuario where nombre_clave = '"+_nombreUsuario+"';";

            try
            {
                _conexion.Execute(sqluse, out contFilas);
                _conexion.Execute(sqlInsert, out contFilas);
            }
            catch 
            {
                return (4);//error al insertar el nuevo usuario a la tabla usuario

            }

            try
            {
               rs= _conexion.Execute(sqlSelectId, out contFilas);
            }
            catch 
            {

                return (5);//error al obtener id de usuario
            }

            _id = rs.Fields[0].Value;

            string sqlInsertUserInvitado = "insert into usuario_invitado(id_us_invi) values("+_id+") ;";

            try
            {
                _conexion.Execute(sqlInsertUserInvitado, out contFilas);
                
            }
            catch 
            {
                return (6);// error al insertar en la tabla Usuario_invitado
                
            }

            return resultado;//si devuelve el valor de esta variable es porque todo salio correcto


        }



    }
}
