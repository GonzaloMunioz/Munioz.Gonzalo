using System;
using Library_ProgObj;

namespace _3._Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Gonza", new DateTime(2002, 09, 18), 44361856);

            Console.WriteLine(personaUno.DisplayInfo());

        }
    }
}
