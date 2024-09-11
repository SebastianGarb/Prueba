using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_antes_del_examen_final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciudad, Calidad;
            
            double Precio = 0, Descuento = 0, Total = 0, Cantidad;

            Console.WriteLine("Ingrese la ruta que desea ir (Solo ingrese el nombre de la segunda ciudad): Lima a Trujillo o Lima a Arequipa");
            ciudad = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese la calidad que desea (A como economico,B como regular,C como premiun) pagar:  ");
            Calidad = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese la cantidad de boletos que desea comprar: ");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            switch (ciudad)
            {
                case "TRUJILLO":
                    if (Calidad == "A")
                    {
                        Precio = 45;
                        if (Cantidad >= 4)
                        {
                            Descuento = Precio - Precio * 0.05;
                        }
                        
                    }
                    if (Calidad == "B")
                    {
                        Precio = 50;
                    }
                    if (Calidad == "C")
                    {
                        Precio = 60;
                    }
                    
                    Total = Precio*Cantidad - Descuento;

                    break;
                case "AREQUIPA":
                    if (Calidad == "A")
                    {
                        Precio = 55;
                        if (Cantidad >= 4)
                        {
                            Descuento = Precio - Precio * 0.05;
                        }

                    }
                    if (Calidad == "B")
                    {
                        Precio = 65;
                    }
                    if (Calidad == "C")
                    {
                        Precio = 75;
                    }
                    Total = Precio * Cantidad - Descuento;

                    break;
            }
            Console.WriteLine("El precio del boleto es: " + Precio);
            Console.WriteLine("El precio que tendra el boleto con su descuento sera: " + Descuento);
            Console.WriteLine("El precio total de los boleto(s) sera: " + Total);

            
            
            
        }
    }
}
