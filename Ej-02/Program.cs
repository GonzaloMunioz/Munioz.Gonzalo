using System;

namespace Ej_02
{
    class Program
    {
        static void Main(string[] args)
        {
            String num_string;
            Int32 num;
            Int32 cuadrado;
            Int32 cubo;

            Console.Title = "Ejercicio-02";
            Console.WriteLine("Ingrese un numero, luego se mostrara el cuadrado y el cubo del mismo: ");
            num_string = Console.ReadLine();
            num = int.Parse(num_string);
            while(num < 1)
            {
                Console.Clear();
                Console.WriteLine("ERROR! Se debe ingresar un valor mayor a cero, porfavor reingrese: ");
                num_string = Console.ReadLine();
                num = int.Parse(num_string);
            }
            cuadrado = num * num;
            cubo = cuadrado * num;
            Console.Clear();
            Console.WriteLine("Su numero es: {0}\nEl cuadrado es: {1}\nEl cubo es: {2}", num, cuadrado, cubo);
        }
    }
}
