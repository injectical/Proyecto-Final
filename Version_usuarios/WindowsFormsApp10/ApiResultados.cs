using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace WindowsFormsApp10
{
    class ApiResultados
    {
        public ApiResultados() { }

        public string SerializarEventosSinIniciar()
        {
            bool tipo = false;
            string resultado;
            DataTable tabla = new DataTable();
            Evento e = new Evento();
            e.conexion = Program.conexion;
            try
            {
                tabla = e.Buscar(tipo);
            }
            catch
            {

                throw;
            }

            if (tabla.Rows.Count > 0)
            {
                resultado = JsonConvert.SerializeObject(tabla, Formatting.Indented);
            }
            else
                resultado = "1";
            e = null;
            tabla = null;
            return resultado;



        }

        public DataTable Deserializar(string EventoSerializado)
        {
            byte resultado = 0;
            DataTable tabla =(DataTable) JsonConvert.DeserializeObject(EventoSerializado, typeof(DataTable));
            return tabla;
        }

        public string SerializarEventosFinalizados()
        {
            bool tipo = true;
            string resultado;
            DataTable tabla = new DataTable();
            Evento e = new Evento();
            e.conexion = Program.conexion;
            try
            {
                tabla = e.Buscar(tipo);
            }
            catch
            {
                throw;
               
            }

            if (tabla.Rows.Count > 0)
            {
                resultado = JsonConvert.SerializeObject(tabla, Formatting.Indented);
            }
            else
                resultado = "1";
            e = null;
            tabla = null;
            return resultado;


        }
        public string SerializarEventosEnProceso( )
        {
            string resultado;
            DataTable tabla = new DataTable();
            Evento e = new Evento();
            e.conexion = Program.conexion;
            try
            {
                tabla = e.MostarEnProceso();
            }
            catch
            {
                throw;

            }
            if (tabla.Rows.Count>0) {
               resultado = JsonConvert.SerializeObject(tabla, Formatting.Indented);
            }else
            resultado ="1";
            e = null;
            tabla = null;
            return resultado;
        }

        

    }
}
