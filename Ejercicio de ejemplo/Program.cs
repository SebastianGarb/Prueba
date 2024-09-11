using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la capital (monto prestado)");

            int Capital = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el interes anual: ");

            int Interes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese los años que se realizara el prestamo: ");

            int Tiempo = Convert.ToInt32(Console.ReadLine());

            double CapitalFinal = Capital * Math.Pow((1 + (Interes / 100)), Tiempo);

            Console.WriteLine("La capital final que se pagara por el prestamo sera: " +  CapitalFinal);
               
                    
                
            }
        }
    }
    
