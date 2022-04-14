using System;
using Validadores;

namespace _2._Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int min = 0;
            int max = 0;
            int acumulador = 0;
            float promedio;
            bool flag = true;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero que este dentro del rango -100 hasta 100: ");
                while (!int.TryParse(Console.ReadLine(), out num) || !Validador.ValidarRango(num, -100, 100))
                {
                    Console.WriteLine("ERROR, reingrese un valor numerico desde -100 hasta 100: ");
                }
                if (flag == true)
                {
                    min = num;
                    max = num;
                    flag = false;
                }
                else if(min > num)
                {
                    min = num;
                }
                else if(max < num)
                {
                    max = num;
                }
                acumulador += num;
            }

            promedio = (float) acumulador / 10;
            Console.WriteLine("El minimo numero ingresado es: {0}\nEl maximo numero ingresado es: {1}\nEl promedio es: {2}", min, max, promedio);
        }
    }
}
