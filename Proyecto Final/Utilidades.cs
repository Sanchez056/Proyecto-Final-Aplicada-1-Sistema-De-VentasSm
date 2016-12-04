using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal_Aplicada1
{
   public class Utilidades
    {
        public static int ToInt(string numero)
        {
            int retorno = 0;
            int.TryParse(numero, out retorno);
            return retorno;
        }
    }
}
