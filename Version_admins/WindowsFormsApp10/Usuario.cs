﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
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
        protected int _rol;

        protected ADODB.Connection _conexion;




        public Usuario(string nom, string ap,
            string nomUser, string correo, ADODB.Connection conn)
        {

            _nombre = nom;
            _apellido = ap;
            _nombreUsuario = nomUser;
            _email = correo;

            _conexion = conn;

        }

        public Usuario()
        {

            _nombre = "";
            _apellido = "";
            _nombreUsuario = "";
            _email = "";
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

        public ADODB.Connection conexion
        {
            get { return (_conexion); }
            set { _conexion = value; }
        }


        // la respuesta la adapta a una tabla del tipo DateTable
        //para mostrar por pantalla hay que cargar el return de este metodo a una data gridview
        // de la sigiente manera dataGridView1.DataSource=dt;
        //

        public DataTable Filtrar()
        {
            int rol = _rol;
            object contFilas;
            string sql = "";
            ADODB.Recordset rs = new ADODB.Recordset();
            switch (rol)
            {
                case 1:
                   sql = "select * from usuario where rol=1;";
                    break;
                case 2:
                    sql = "select * from usuario where rol=2; ";
                    break;
                case 3:
                    sql = "select * from usuario where rol =3;";
                    break;
                case 4:
                   sql="select * from usuario where rol =4;";
                    break;
            }

            try
            {
                rs = _conexion.Execute(sql, out contFilas);
            }

            catch
            {
                throw;
                


            }

            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            adapter.Fill(dt, rs);
            return dt;//si el dt esta vacio es porque no se encontro nada
        }

       /* public DataTable ObtenerUsuarios()
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            object contFilas;
            string sql = "select * from usuario";
            try
            {
                rs = _conexion.Execute(sql, out contFilas);
            }

            catch
            {
                throw;


            }

            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            adapter.Fill(dt, rs);
            return dt;//si el dt esta vacio es porque no se encontro nada
        }*/

        

        public byte Modificar()
        {
              byte resultado = 0;
              object contFilas;
               string sql = "update usuario set nombre='"+_nombre+"',apellido='"+_apellido+"',email='"+_email+"' where nombre_clave='"+_nombreUsuario+"';";
              if (_conexion.State == 0)
              {
                resultado = 1;//conexion cerrada
              }
              else
              {
                try
                {
                    _conexion.Execute(sql, out contFilas);
                }
                catch
                {

                    return (2);//no se realizo la modificacion 
                }
            
              }
              return resultado;//ok
        }

        public DataTable Buscar()

        {
            ADODB.Recordset rs = new ADODB.Recordset();
            object contFilas;
           
            string sql = "select * from usuario where nombre_clave='" + _nombreUsuario + "';";
            
            try
            {
                rs = _conexion.Execute(sql, out contFilas);
            }
            catch 
            {

                throw;
            }

            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            adapter.Fill(dt, rs);
            return dt;//si el dt esta vacio es porque no se encontro nada

        }



        public byte Eliminar()
        {

            byte resultado = 0;
            string sql;
            object contlineas;
            if (_conexion.State == 0)
            {
                resultado = 1;//no hay conexion
            }
            else
            {
                sql = "delete from usuario where nombre_clave= '" + _nombreUsuario+"'";
                string sqldrop =" DELETE FROM mysql.user WHERE user = '"+_nombreUsuario+"';";
                try
                {
                    _conexion.Execute(sql, out contlineas);
                    _conexion.Execute(sqldrop, out contlineas);
                }
                catch
                {
                    return (2);//error al intentar eliminar el usuario
                }

            }
            return resultado;// usuario eliminado
        }
    }
}
