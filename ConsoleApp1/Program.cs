using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string carrera;
            int creditos;
            double mensualidad = 0, descuento = 0, recargo = 0, pagoFinal;
            Console.WriteLine("Ingrese su carrera(INGENIERIA,SALUD,MEDICINA, OTROS)");
            carrera = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese el numero de creditos");
            creditos = int.Parse(Console.ReadLine());
            switch (carrera)
            {
                case "INGENIERIA":
                    mensualidad = 800;
                    if (creditos >= 2 && creditos <= 12)
                    {
                        descuento = 0.25;
                    }
                    else if (creditos >= 13 && creditos <= 22)
                    {
                        descuento = 0;
                        recargo = 0;
                    }
                    else if (creditos >= 23 && creditos <= 26)
                    {
                        recargo = 0.15;
                    }
                    else
                    {
                        Console.WriteLine("Creditos no validos");
                        creditos = 0;
                    }
                    break;
                case "SALUD":
                    mensualidad = 750;
                    if (creditos >= 2 && creditos <= 12)
                    {
                        descuento = 0.20;
                    }
                    else if (creditos >= 13 && creditos <= 22)
                    {
                        descuento = 0.10;
                    }
                    else if (creditos >= 23 && creditos <= 26)
                    {
                        recargo = 0.10;
                    }
                    else
                    {
                        Console.WriteLine("Creditos no validos");
                        creditos = 0;
                    }
                    break;
                case "MEDICINA":
                    mensualidad = 2500;
                    if (creditos >= 2 && creditos <= 12)
                    {
                        descuento = 0.15;
                    }
                    else if (creditos >= 13 && creditos <= 22)
                    {
                        descuento = 0.05;
                    }
                    else if (creditos >= 23 && creditos <= 26)
                    {
                        descuento = 0.10;
                    }
                    else
                    {
                        Console.WriteLine("Creditos no validos");
                        creditos = 0;
                    }
                    break;
                default:
                    mensualidad = 700;
                    if (creditos <= 26 && creditos >= 2)
                    {
                        Console.WriteLine("Creditos no validos");
                        creditos = 0;
                    }
                    break;
            }
            if (creditos == 0)
            {
                Console.WriteLine("Vuelva a intentarlo");
            }
            else
            {
                pagoFinal = mensualidad - (mensualidad * descuento) + (mensualidad * recargo);
                Console.WriteLine("El pago de la mensualidad es de {0}soles", mensualidad);
                if (recargo > 0)
                {
                    Console.WriteLine("La regarga es de {0} soles", (mensualidad * recargo));
                }
                else if (descuento > 0)
                {
                    Console.WriteLine("El descuneto de de {0} soles", (mensualidad * descuento));
                }
                Console.WriteLine("El pago final sera de {0}soles", pagoFinal);

            }
        }
    }
}


