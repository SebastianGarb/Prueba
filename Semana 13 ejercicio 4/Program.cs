using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double TotalPagar = 0, Precio = 0, Cantidad, Oferta = 0;
            string Producto, Tamaño;

            Console.WriteLine("Ingrese el producto que desea comprar (Cafe,Jugo,Helado):");
            Producto = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese el tamaño que desea (Pequeño, Mediano, Grande)");
            Tamaño = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese la cantidad que desea comprar: ");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            switch (Producto)
            {
                case "CAFE":
                    switch (Tamaño)
                    {
                        case "PEQUEÑO":
                            Precio = 7.5;
                            break;
                        case "MEDIANO":
                            Precio = 9.5;
                            break;
                        case "GRANDE":
                            Precio = 10;
                            break;
                    }
                    if (Cantidad >= 2)
                    {
                        Oferta = 0.15;
                        TotalPagar = Precio * Oferta;
                    }
                    else
                    {
                        TotalPagar = Precio;
                    }
                    break;
                
                case "JUGO":
                    switch (Tamaño)
                    {
                        case "PEQUEÑO":
                            Precio = 11.5;
                            break;
                        case "MEDIANO":
                            Precio = 14;
                            break;
                        case "GRANDE":
                            Precio = 16.5;
                            break;
                    }
                    if (Cantidad >= 3)
                    {
                        Oferta = 0.10;
                        TotalPagar = Precio * Oferta;
                    }
                    else
                    {
                        TotalPagar = Precio;
                    }
                    break;

                case "HELADO":
                    switch (Tamaño)
                    {
                        case "PEQUEÑO":
                            Precio = 4.6;
                            break;
                        case "MEDIANO":
                            Precio = 6.5;
                            break;
                        case "GRANDE":
                            Precio = 8;
                            break;
                    }
                    if (Cantidad >= 2)
                    {
                        Oferta = 0.20;
                        TotalPagar = Precio * Oferta;
                    }
                    else
                    {
                        TotalPagar = Precio;
                    }
                    break;
            }

            Console.WriteLine("El monto del producto es: " + TotalPagar);
            Console.WriteLine("Laa oferta que tendra el producto es: " + Oferta);
            Console.WriteLine("El total a pagar del producto es: " + TotalPagar);
        }
    }
}
