using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace WindowsFormsApp10
{
    class ApiAtenticacion
    {
       



            public ApiAtenticacion() { }
        //realizar la conexion en este metodo
          public byte Autenticar(string Nomusuario, string pass)
          {
               
            try
            {
                Program.conexion.Open("miodbc", Nomusuario, pass);
                return 1;
            }
            catch 
            {
                return 0;
               
            }

            



          }


        
        public string MostarDatos(string nombreUser, ADODB.Connection con)
        {
            string resultado;
            Usuario u = new Usuario(nombreUser,con);
           
            u.nombreUsuario = nombreUser;
            u.conexion = con;

            try
            {

                u.CargarDatos();
            }
            catch 
            {

                throw;
            }

            u.conexion = null;

            resultado = JsonSerializer.Serialize(u);
            u = null;
            return resultado;
            

        }

       
    }
}

