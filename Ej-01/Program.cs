using System;

namespace Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            String numero_string;
            Int32 numero;
            Int32 suma = 0;
            Single promedio;
            Int32 max = 0;
            Int32 min = 0;
            Boolean flag = false;

            Console.Title = "Ejercicio-01";
            for(Int32 i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero_string = Console.ReadLine();
                numero = int.Parse(numero_string);
                suma += numero;
                if(flag != true)
                {
                    max = numero;
                    min = numero;
                    flag = true;
                }
                else
                {
                    if(max < numero)
                    {
                        max = numero;
                    }
                    else if(min > numero)
                    {
                        min = numero;
                    }
                }
            }
            Console.Clear();
            promedio = (float)suma / 5;
            Console.WriteLine("\nEl maximo es: {0}\nEl minimo es: {1}\nEl promedio es: {2}", max, min, promedio);
        }
    }
}
