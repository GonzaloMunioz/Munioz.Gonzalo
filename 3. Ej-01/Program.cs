using System;
using Library_ProgObj;

namespace _3._Ej_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaUno = new Cuenta("Gonzalo Munioz", 15000);

            Console.WriteLine(cuentaUno.Display());
            cuentaUno.Deposit(2500);
            Console.WriteLine(cuentaUno.Display());
            cuentaUno.Withdraw(20000);
            Console.WriteLine(cuentaUno.Display());
        }
    }
}
