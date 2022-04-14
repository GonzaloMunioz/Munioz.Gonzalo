using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Clase04
{
    public class Cosa
    {
        private Int32 entero;
        private String cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string pC) : this()
        {
            this.cadena = pC;
        }

        public Cosa(string pC, int pE) : this(pC)
        {
            this.entero = pE;
        }

        public Cosa(string pC, int pE, DateTime pF) : this(pC, pE)
        {
            this.fecha = pF;
        }

        public void EstablecerValor(int pE)
        {
            this.entero = pE;
        }

        public void EstablecerValor(string pC)
        {
            this.cadena = pC;
        }

        public void EstablecerValor(DateTime pF)
        {
            this.fecha = pF;
        }

        private string Mostrar()
        {
            return "\nEntero: " + this.entero + "\nCadena: " + this.cadena + "\nFecha: " + this.fecha;
        }

        public static string Mostrar(Cosa esto)
        { 
            return esto.Mostrar();
        }
    }
}
