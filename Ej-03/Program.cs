using System;

namespace Ej_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string string_aux;

            Console.Title = "Ejercicio-03";

            do
            {
                Console.WriteLine("Ingrese un numero si desea iterar o escriba SALIR si desea cerrar el programa:");
                string_aux = Console.ReadLine();
                while (!int.TryParse(string_aux, out num) && string_aux != "SALIR")
                {
                    Console.WriteLine("ERROR, reingrese un valor numerico o escriba SALIR si desea cerrar el programa: ");
                    string_aux = Console.ReadLine();
                }
                for (int i = 0; i < (num + 1); i++)
                {
                    if (Validador.ValidarPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Escriba SI si desea iterar nuevamente o SALIR si desea cerrar el programa:");
                if(Console.ReadLine() == "SALIR")
                {
                    string_aux = "SALIR";
                }
              
            } while (string_aux != "SALIR");
        }
    }
}
