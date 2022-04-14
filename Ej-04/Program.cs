using System;

namespace Ej_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int contador = 0;

            while (contador < 4)
            {
                if(EncontrarPerfecto(i))
                {
                    Console.WriteLine("- {0}: Es un numero perfecto", i);
                    contador++;
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }

        public static bool EncontrarPerfecto(int num)
        {
            int acumulador = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    acumulador += i;
                }
            }
            if(acumulador == num)
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
