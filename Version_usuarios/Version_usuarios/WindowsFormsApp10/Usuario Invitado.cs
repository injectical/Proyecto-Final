﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
     class Usuario_Invitado : Usuario
    {
        public Usuario_Invitado(int id, string nom, string ap, string nomUser, string correo, string pass, int rol, ADODB.Connection conn) : base(id, nom, ap, nomUser, correo, pass, rol, conn)
        {
        }

       


    }
}