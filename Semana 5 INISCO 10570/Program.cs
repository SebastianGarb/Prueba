using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Semana_5_INISCO_10570
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            int HLunes, HMartes, HMiercoles, HJueves, HViernes, HSabado, PagoHora;

            double Pago, Bono, Montototal;

            Console.WriteLine("Introduce las horas trabajadas de la semana ");

            Console.WriteLine("Lunes: ");
            HLunes =  Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Martes: ");
            HMartes = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Miercoles: ");
            HMiercoles = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Jueves: ");
            HJueves = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Viernes: ");
            HViernes = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Sabado: ");
            HSabado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuanto se paga por hora: ");
            
            PagoHora = Convert.ToInt32(Console.ReadLine());

            Pago = (HLunes + HMartes +  HMiercoles + HJueves + HViernes + HSabado)* PagoHora;

            Console.WriteLine("El pago es " + Pago);

            Bono = Pago * 0.25;

            Console.WriteLine("El bono por transporte es " + Bono);

            Montototal = Bono + Pago; 

            Console.WriteLine("El Monto total seria " + Montototal);

            Console.ReadKey();

        }
    }
}
