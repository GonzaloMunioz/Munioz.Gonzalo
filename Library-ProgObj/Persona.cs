using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_ProgObj
{
    public class Persona
    {
        private string name;
        private DateTime birthDate;
        private double dni;

        public Persona(string name, DateTime birthDate, double dni)
        {
            this.SetName(name);
            this.SetDate(birthDate);
            this.SetDNI(dni);
        }

        public string GetName()
        {
            return this.name;
        }

        public DateTime GetDate()
        {
            return this.birthDate;
        }

        public double GetDNI()
        {
            return this.dni;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public void SetDNI(double dni)
        {
            this.dni = dni;
        }

        private int CalculateAge()
        {
            TimeSpan days = DateTime.Now - this.birthDate;
            return days.Days / 365;
        }

        public string IsOfLegalAge()
        {
            if (this.CalculateAge() > 17)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }

        public string DisplayInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los datos de la persona son:");
            sb.AppendLine($" - Nombre: {this.name}");
            sb.AppendLine($" - Edad: {this.CalculateAge()} | {this.IsOfLegalAge()}");
            sb.AppendLine($" - Fecha de nacimiento: {this.birthDate.ToShortDateString()}");
            sb.AppendLine($" - DNI: {this.dni}");
            return sb.ToString();
        }        
    }
}
