using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03
{
    public static class Validador
    {
        public static bool ValidarPrimo(int num)
        {
            int contador = 0;

            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }

            if(contador == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
