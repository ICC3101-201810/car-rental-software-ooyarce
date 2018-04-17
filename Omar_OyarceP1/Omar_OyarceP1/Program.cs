using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omar_OyarceP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad: ");
            string linea = Console.ReadLine();
            int edad = int.Parse(linea);
            Persona p0 = new Persona(nombre, edad);
            Interfaceman i0 = new Interfaceman();
            int respuesta = i0.Saludar(nombre);
            if (respuesta == 1)
            {
                p0.Verificador();
                if (p0.GetVerdad())
                {
                    Arriendo a = new Arriendo();
                    a.MostrarOpciones();
                    a.Agregar();
                    a.Transaccion();
                }
            }
            
        }
    }
}
