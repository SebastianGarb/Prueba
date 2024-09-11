using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reforzamiento_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double CapitalI, CapitalF, TMeses;

            Console.WriteLine("Ingrese la capital inicial: ");
            CapitalI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese los meses que pasara: ");
            TMeses = Convert.ToDouble(Console.ReadLine());
            
            if (TMeses >= 7)
            {
                CapitalF = CapitalI * (Math.Pow(1 + 0.05,TMeses));
                Console.WriteLine("La capital final sera: " + CapitalF);
            }
            else
            {
                CapitalF = CapitalI * (Math.Pow(1 + 0.04,TMeses));
                Console.WriteLine("La capital final sera: " + CapitalF);
            }
            Console.ReadKey();
            
        }
    }
}
