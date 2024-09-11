using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Dia;

            Console.WriteLine("Ingrese un dia de la semana: ");
            Dia = Console.ReadLine().ToUpper();

            switch (Dia)
            {
                case "LUNES":
                    Console.WriteLine("DIA DE SEMANA");
                    break;
                case "MARTES":
                    Console.WriteLine("DIA DE SEMANA");
                    break;
                case "MIERCOLES":
                    Console.WriteLine("DIA DE SEMANA");
                    break;
                case "JUEVES":
                    Console.WriteLine("DIA DE SEMANA");
                    break;
                case "VIERNES":
                    Console.WriteLine("DIA DE SEMANA");
                    break;
                case "SABADO":
                    Console.WriteLine("FIN DE SEMANA");
                    break;
                case "DOMINGO":
                    Console.WriteLine("FIN DE SEMANA");
                    break;
                default:
                    Console.WriteLine("Dia no valido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
