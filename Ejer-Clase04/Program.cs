using System;
using Library;

namespace Ejer_Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa esto = new Cosa();
            Cosa esto1 = new Cosa("aaa");
            Cosa esto2 = new Cosa("bbb", 18);
            Cosa esto3 = new Cosa("ccc", 27, new DateTime(2018, 12, 09));

            //DateTime fecha = new DateTime(2018, 12, 09);

            Console.WriteLine(Cosa.Mostrar(esto));
            Console.WriteLine(Cosa.Mostrar(esto1));
            Console.WriteLine(Cosa.Mostrar(esto2));
            Console.WriteLine(Cosa.Mostrar(esto3));
        }
    }
}
