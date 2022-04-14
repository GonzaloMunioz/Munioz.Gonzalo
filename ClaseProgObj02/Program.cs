using System;
using Logica;

namespace ClaseProgObjUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int status;

            if(Sistem.CheckAccess("Boyka", "Undisputed", out status) && status == 1)
            {
                Console.WriteLine("USUARIO LOGUEADO");
            }
            else if(status == 0)
            {
                Console.WriteLine("CONTRASENIA INCORRECTA");
            }
            else
            {
                Console.WriteLine("USUARIO INEXISTENTE");
            }
        }
    }
}
