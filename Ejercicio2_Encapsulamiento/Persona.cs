using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_Encapsulamiento
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad {get; set; }

        public string EstablecerNombre(string nombre)
        {
            return Nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public int EstablecerEdad(int edad)
        {
            return Edad = edad;
        }
        public int ObtenerEdad()
        {
            return Edad;
        }


    }
}
