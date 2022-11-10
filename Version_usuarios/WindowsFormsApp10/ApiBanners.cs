using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class ApiBanners
    {
        public ApiBanners() { }

       

        public string SerializarBanners()
        {
           
            string resultado="";
            Banner B = new Banner();
            B.con = Program.conexion;
           

            switch (B.CargarBanners())
            {
                case 1:
                    resultado = "1";//error de conexion
                    break;
                case 2:
                    B.con = null;//se dejaen null la conexion porque el metodo deserializar no soporta un objeto de la clase ADodb
                    resultado =  JsonSerializer.Serialize(B);
                    break;
                case 3:
                    resultado = "3";//consulta vacia
                    break;

            }

            return resultado;
          

        }
    }
}
