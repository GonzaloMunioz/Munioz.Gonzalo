using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Gato
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;

        public Gato()
        {
            AsignarNombre("Sin nombre");
            this.fechaNacimiento = DateTime.Today;
            this.peso = 0;

            Console.WriteLine($"NOMBRE: {nombre}");
            Console.WriteLine($"FECHA NACIMIENTO: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"PESO: {peso}");
        }

        public Gato(string nombre, DateTime fechaNacimiento, double peso) : this()
        {
            AsignarNombre(nombre);
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
        }

        public void AsignarNombre (string nombre)
        {
            this.nombre = nombre;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                this.nombre = "Sin nombre";
            }
        }

        public void AsignarPeso(double peso)
        { 
            this.peso = peso;   
        }

        public double ObtenerPeso()
        {
            return peso;
        }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del gato:");
            sb.AppendLine($" - Nombre del gato: {nombre}");
            sb.AppendLine($" - Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($" - Peso: {peso}kgs");

            return sb.ToString();
        }






    }
}
