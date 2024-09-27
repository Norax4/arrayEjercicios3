using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayEjercicios3
{
    internal class Persona
    {
        public string? Nombre { get; set; }
        public int Edad {  get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"{Nombre}, {Edad} años.";
        }
    }
}
