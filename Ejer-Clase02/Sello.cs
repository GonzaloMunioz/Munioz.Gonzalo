using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Clase02
{
    public static class Sello
    {
        public static String mensaje;
        public static ConsoleColor color;

        public static String Imprimir()
        {
            return Sello.mensaje;
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }
      
        public static void Borrar()
        {
            Sello.mensaje = "";
        }


    }
}
