using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omar_OyarceP1
{
    class Interfaceman
    {
        public int Saludar(string nombre)
        {
            Console.WriteLine("Bienvenido " + nombre + " digame que quiere hacer: ");
            Console.WriteLine("Escriba (1) para arrendar un vehiculo");
            Console.WriteLine("Escriba (2) para recibir un vehiculo");
            Console.WriteLine("Escriba (3) para salir");
            string linea = Console.ReadLine();
            int opcion = int.Parse(linea);
            while (opcion != 1 && opcion != 2 && opcion != 3)
            {
                Console.WriteLine("Opcion no valida. ");
                Console.WriteLine("Escriba (1) para arrendar un vehiculo");
                Console.WriteLine("Escriba (2) para recibir un vehiculo");
                Console.WriteLine("Escriba (3) para salir");
                linea = Console.ReadLine();
                opcion = int.Parse(linea);
            }
            return opcion;
        }
    }
}
