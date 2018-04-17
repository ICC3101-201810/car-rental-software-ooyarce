using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omar_OyarceP1
{
    class Persona
    {
        string name;
        bool licencia;
        int edad;
        public Persona(string name, int edad)
        {
            this.name = name;
            this.edad = edad;
        }
        public void Verificador()
        {
            if (edad >= 21) { licencia = true; }
            else { Console.WriteLine("No tiene edad suficiente para arrendar"); licencia = false; }
        }
        public bool GetVerdad() { return licencia; }
    }
}
