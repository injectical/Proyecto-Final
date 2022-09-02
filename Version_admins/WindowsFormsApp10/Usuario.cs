using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    class Usuario
    {
        protected int _id;
        protected string _nombre;
        protected string _apellido;
        protected string _nombreUsuario;
        protected string _email;
        protected string _contraseña;
        protected int _rol;
        protected ADODB.Connection _conexion;




        public Usuario(int id, string nom, string ap, string nomUser, string correo, string pass, int rol, ADODB.Connection conn)
        {
            _id = id;
            _nombre = nom;
            _apellido = ap;
            _nombreUsuario = nomUser;
            _email = correo;
            _contraseña = pass;
            _rol = rol;
            _conexion = conn;
        }

        public Usuario()
        {
            _id = 0;
            _nombre = "";
            _apellido = "";
            _nombreUsuario = "";
            _email = "";
            _contraseña = "";
            _rol = 0;
            _conexion = new ADODB.Connection();
        }

        public int id
        {
            get
            {
                return (_id);

            }

            set
            {
                _id = value;
            }
        }

        public string nombre
        {
            get
            {
                return (_nombre);

            }

            set
            {
                _nombre = value;
            }



        }

        public string apellido
        {
            get
            {
                return (_apellido);
            }

            set
            {
                _apellido = value;
            }
        }

        public string nombreUsuario
        {
            get
            {
                return (_nombreUsuario);
            }

            set
            {
                _nombreUsuario = value;
            }
        }

        public string email
        {
            get
            {
                return (_email);
            }

            set
            {
                _email = value;
            }
        }

        public string contraseña
        {
            get
            {
                return (_contraseña);
            }

            set
            {
                _contraseña = value;
            }
        }

        public int rol
        {

            get
            {
                return (_rol);
            }

            set
            {
                _rol = value;
            }
        }



        public byte Guardar(bool alta)
        {
            byte resultado = 0;
            string sql, sql2, sql1, sql3, sql4, sql5, sql6;
            object contFilas;

            _conexion = Program.conexion;
            if (_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada

            }
            else
            {

                if (alta)
                {
                    sql = "insert into usuario (nombre,apellido,email,rol,nombre_clave) values ('" + _nombre + "','" + _apellido + "','" + _email + "','" + _rol + "','" + _nombreUsuario + "')";

                    sql1 = "create user" + "'" + _nombreUsuario + "'" + "@localhost identified by" + "'" + _contraseña + "'";
                    sql2 = "grant select, update on sports360.usuario to" + "'" + _nombreUsuario + "'" + "@localhost";
                    sql3 = "grant select, update on sports360.evento to" + "'" + _nombreUsuario + "'" + "@localhost";
                    sql4 = "grant select, update on sports360.corresponde to" + "'" + _nombreUsuario + "'" + "@localhost";
                    sql5 = "grant select, update on sports360.disciplina to" + "'" + _nombreUsuario + "'" + "@localhost";
                    sql5 = "grant select, update on sports360.disciplina to" + "'" + _nombreUsuario + "'" + "@localhost";
                    sql6 = "grant insert on sports360.usuario_espera_pago to" + "'" + _nombreUsuario + "'" + "@localhost";




                    try
                    {
                        _conexion.Execute(sql, out contFilas);
                        _conexion.Execute(sql1, out contFilas);
                        _conexion.Execute(sql2, out contFilas);
                        _conexion.Execute(sql3, out contFilas);
                        _conexion.Execute(sql4, out contFilas);
                        _conexion.Execute(sql5, out contFilas);
                        _conexion.Execute(sql6, out contFilas);

                        MessageBox.Show("Se ha autorizado al usuario con éxito");
                    }
                    catch
                    {
                        MessageBox.Show("Hubo un problema al crear el usuario");

                        return (2);
                    }


                    sql6 = "delete from usuario_provisorio where nombre_clave='" + nombreUsuario + "';";

                    try
                    {
                        _conexion.Execute(sql6, out contFilas);

                    }
                    catch
                    {
                        MessageBox.Show("No se borró de provisorios");

                        return (2);

                    }
                }
                else
                {
                    sql = "update usuario set nombre ='" + _nombre + "',apellido='" + _apellido + "',email='" + _email + "',rol='" + _rol + "',nombre_clave='" + _nombreUsuario + "';";

                    try
                    {
                        _conexion.Execute(sql, out contFilas);

                        MessageBox.Show("Actualización exitosa");

                    }
                    catch
                    {
                        MessageBox.Show("No se actualizaron los datos");

                        return (2);
                    }
                }

            } 
            return (3);

        }
    }
}
