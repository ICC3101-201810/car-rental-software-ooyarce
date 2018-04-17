using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Omar_OyarceP1
{
    
    public class Arriendo
    {
        List<Vehiculo> Carrito = new List<Vehiculo>();
        List<Vehiculo> Autos = new List<Vehiculo>() {
            new Vehiculo("Ferrari Enzo",100000,5),
            new Vehiculo("Porshe 911 Turbo",50000,10),
            new Vehiculo("Lamborghini Gerardo",80000,5),
            new Vehiculo("Chevrolet Corsa",1000,100) };
        public void MostrarOpciones()
        {
            for (int i = 0; i < 4; i++)
            {
                Vehiculo v = Autos[i];
                Console.WriteLine("Tenemos un " + v.GetNombre() + " a un precio de " + v.GetPrecio() + ". Hay " + v.GetStock() + " unidades disponibles.");
            }
        }
        public void Agregar()
        {
            Vehiculo v1 = Autos[0];
            Vehiculo v2 = Autos[1];
            Vehiculo v3 = Autos[2];
            Vehiculo v4 = Autos[3];
            int stock1 = v1.GetStock();
            int stock2 = v2.GetStock();
            int stock3 = v3.GetStock();
            int stock4 = v4.GetStock();
            for (int i = 0; i < 4; i++)
            {
                Vehiculo v = Autos[i];
                int xd = i + 1;
                Console.WriteLine("Seleccione " + xd  + " para agregar el "+ v.GetNombre()+ "al carrito.");
            }
            string linea = Console.ReadLine();
            int opcion = int.Parse(linea);
            while (opcion != 1 && opcion !=2 && opcion !=3 && opcion !=4)
            {
                Console.WriteLine("Opcion invalida, intente nuevamente: ");
                linea = Console.ReadLine();
                opcion = int.Parse(linea);
            }
            if (opcion == 1) { Vehiculo v = Autos[0];  stock1 -= 1; string nombre = v.GetNombre(); Carrito.Add(Autos[0]); }
            if (opcion == 2) { Vehiculo v = Autos[1];  stock2 =- 1; string nombre = v.GetNombre(); Carrito.Add(Autos[1]); }
            if (opcion == 3) { Vehiculo v = Autos[2];  stock3 =- 1; string nombre = v.GetNombre(); Carrito.Add(Autos[2]); }
            if (opcion == 4) { Vehiculo v = Autos[3];  stock4 =- 1; string nombre = v.GetNombre(); Carrito.Add(Autos[3]); }
            int contador = 1;
            while (true)
            {
                Console.WriteLine("Desea agregar otro auto?");
                Console.WriteLine("Escriba (1) para agregar o (0) para proceder con el pago");
                linea = Console.ReadLine();
                opcion = int.Parse(linea);
                if (opcion == 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int xd = i + 1;
                        Vehiculo v = Autos[i];
                        Console.WriteLine("Seleccione " + xd + " para agregar el "+ v.GetNombre()+ "al carrito.");
                    }
                    linea = Console.ReadLine();
                    opcion = int.Parse(linea);
                    while (opcion != 1 && opcion != 2 && opcion != 3 && opcion != 4)
                    {
                        Console.WriteLine("Opcion invalida, intente nuevamente: ");
                        linea = Console.ReadLine();
                        opcion = int.Parse(linea);
                    }
                    if (opcion == 1) { Vehiculo v = Autos[0];  stock1 =- contador; string nombre = v.GetNombre(); Carrito.Add(Autos[0]); }
                    if (opcion == 2) { Vehiculo v = Autos[1];  stock2 =- contador; string nombre = v.GetNombre(); Carrito.Add(Autos[1]); }
                    if (opcion == 3) { Vehiculo v = Autos[2];  stock3 =- contador; string nombre = v.GetNombre(); Carrito.Add(Autos[2]); }
                    if (opcion == 4) { Vehiculo v = Autos[3];  stock4 =- contador; string nombre = v.GetNombre(); Carrito.Add(Autos[3]); }
                    contador++;
                    if (stock1 == 0 || stock2 == 0 || stock3 == 0 || stock4 == 0) { Console.WriteLine("Auto fuera de stock"); break; }
                    continue;
                }
                if (opcion == 0) { break; }
                else { Console.WriteLine("Opcion Invalida."); continue; }
            }
        }
        public void Transaccion()
        {
            int largo = Carrito.Count;
            int Sumatoria = 0;
            for (int i =0;i < largo; i++)
            {
                Vehiculo v = Carrito[i];
                Sumatoria += v.GetPrecio();

            }
            Console.WriteLine("Precio total del pedido = "+ Sumatoria);

        }
        public void Adios()
        {
            Console.WriteLine("Disfute del pedido!");
        }

    }
        

}
