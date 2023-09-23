using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas_unitarias
{
    public class Funciones
    {
        public static bool EsPar(int num)
        {
            if ((num % 2) == 0)
                return true;
            else
                return false;
        }
    }
}
