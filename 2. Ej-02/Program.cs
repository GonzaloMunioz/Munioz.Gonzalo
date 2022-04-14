using System;
using Validadores;

namespace _2._Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int acumulador = 0;
            string respuesta = "S";

            while(Validador.ValidarRespuesta(respuesta) == true)
            {
                Console.WriteLine("Ingrese un numero para sumar: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("ERROR, reingrese un valor numerico: ");
                }
                acumulador += num;
                Console.WriteLine("¿Desea continuar con el ingreso de numeros?. Indique S (si) o N (no): ");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("El total acumulado es: {0}", acumulador);
        }
    }
}
