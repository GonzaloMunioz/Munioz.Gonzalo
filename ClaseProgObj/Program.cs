using System;
using Veterinaria;

namespace ClaseProgObj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gato garfield = new Gato();
            //Console.WriteLine(garfield.ObtenerDatos());
            Gato garfield2 = new Gato("Garfield", new DateTime(2018, 09, 18), 4.1);
            Console.WriteLine(garfield2.ObtenerDatos());






            //Gato garfield2 = garfield;
            //Gato felix = new Gato("Felix", new DateTime(2020, 03, 20), 5.8);

            //
            //Console.WriteLine(garfield2.ObtenerDatos());
            //Console.WriteLine(felix.ObtenerDatos());

            //Console.WriteLine("¿Son iguales?: {0}", garfield == garfield2);
            //Console.WriteLine("¿Son iguales?: {0}", garfield.Equals(garfield2));
            //Console.WriteLine("HashCode Garfield: {0}", garfield.GetHashCode());
            //Console.WriteLine("HashCode Garfield2: {0}", garfield2.GetHashCode());
            //Console.WriteLine("HashCode Felix: {0}", felix.GetHashCode());
        }
    }
}
