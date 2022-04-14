using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_ProgObj
{
    public class Cuenta
    {
        private string holder;
        private decimal amount;

        public Cuenta()
        {
            this.holder = "Vacio";
            this.amount = 0;
        }

        public Cuenta(string titular, decimal cantidad) : this()
        {
            this.holder = titular;
            this.amount = cantidad;
        }

        public string GetHolder()
        {
            return this.holder;
        }

        public decimal GetAmount()
        {
            return this.amount;
        }

        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los datos de la cuenta son:");
            sb.AppendLine($" - Titular: {holder}");
            sb.AppendLine($" - Cantidad: ${amount}");

            return sb.ToString();
        }

        public bool Deposit(decimal amount)
        {
            if(amount > 0)
            {
                this.amount += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if(amount > 0)
            {
                this.amount -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
