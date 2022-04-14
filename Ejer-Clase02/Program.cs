using System;

namespace Ejer_Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola Mundo";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
        }
    }
}
