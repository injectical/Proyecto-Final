using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected int rol
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

        

     
    }
}
