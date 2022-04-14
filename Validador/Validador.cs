using System;

namespace Validadores
{
    public class Validador
    {
        public static bool ValidarRango(int valor, int min, int max)
        {
            if (valor > max || valor < min)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidarRespuesta(string caracter)
        {
            if(caracter != "S" && caracter != "s")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
