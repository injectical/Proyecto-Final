using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Usuario_Provisorio : Usuario
    {
        public Usuario_Provisorio(int id, string nom, string ap, string nomUser, string correo, string pass, int rol, byte pago, DateTime fechaPago, ADODB.Connection conn) : base(id, nom, ap, nomUser, correo, pass, rol, conn)
        {
        }

        public Usuario_Provisorio()
        {

        }


    }
}
