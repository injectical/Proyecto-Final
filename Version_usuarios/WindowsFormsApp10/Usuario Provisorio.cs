using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Usuario_Provisorio : Usuario

    {

        private string _pass;

        public Usuario_Provisorio(string pass, string nombre, string apellido, string nombreUsuario, string
            correo, ADODB.Connection conexion) : base(nombre, apellido, nombreUsuario, correo, conexion)
        {
            _rol = 3;//se le asigna el rol de forma predeterminada ya que este va a ser un usuario invitado
            _nombre = nombre;
            _apellido = apellido;
            _conexion = conexion;
            _pass = pass;
            _nombreUsuario = nombreUsuario;
            _conexion = conexion;


        }

        public Usuario_Provisorio():base()
        {
            _rol = 3;
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

        public byte provisorioGuardar()
        {
            byte resultado = 0;
            string sql, sql2;
            object contFilas;
            ADODB.Recordset rs;
            try
            {
                _conexion.Open("miodbc", "fabio.fernandez", "1234");
            }
            catch 
            {

                return 1;
            }
           
            

            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {//primero busca en la tabla de usuario si existe algun usuario con el mismo nombre-clave
                sql2 = "select id_usuario from usuario where nombre_clave='" + _nombreUsuario + "'";


                try
                {
                    rs = _conexion.Execute(sql2, out contFilas);

                }
                catch
                {
                    return (3);//error al obtener Datos de la tabla Usuario provisorio
                }

                if (contFilas.Equals(0))//si el resultado es 0 es porque no existe ninguna tupla con el mismo nombre de usuario
                {

                    sql = "insert into usuario_provisorio (nombre,apellido,email,nombre_clave,contrasena,rol) values ('" + _nombre + "','" + _apellido + "','" + _email + "','" + _nombreUsuario + "','" + _pass + "','"+_rol+"')";
                    try
                    {
                        _conexion.Execute(sql, out contFilas);
                       

                    }
                    catch
                    {
                        return (2);//error al insertar enla tabla usuario Provisorio
                    }
                   

                }else
                {
                   
                    return (4);//ya existe el nombre clave de usuario

                }



            }

            _conexion.Close();
            return (resultado);

        }

        public byte ConsultarProvisorio()
        {
            byte resultado = 3;
            object contFilas;
            string sql = "select * from usuario_provisorio where nombre_clave ='" + _nombreUsuario + "'";
            ADODB.Recordset rs;
            try
            {
                _conexion.Open("miodbc", "fabio.fernandez", "1234");
            }
            catch 
            {

                return 1;//error al conectarce
            }

            try
            {
                rs = _conexion.Execute(sql, out contFilas);
            }
            catch 
            {

                return 2;//error al consultar
            }

            if (contFilas.Equals(0))
            {
                resultado = 0;
            }
            _conexion.Close();
            return resultado;//si retorna 3 es porque ya existe algu usuario con el mismo nombre de usuario
            
        }


    }
}
