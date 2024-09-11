using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_13_Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Movilidad;
            double KilometroRecorrido, ConsumoPorGalon = 0, PrecioCombustible, MontoTotal, MontoConsumo, Capacidad;

            Console.WriteLine("|__________________________________________|");
            Console.WriteLine("|MOVILIDAD DISPONIBLE:                     |");
            Console.WriteLine("| -FURGONETA  <--- Capacidad 10 toneladas  |");
            Console.WriteLine("| -CAMION     <--- Capacidad 20 toneladas  |");
            Console.WriteLine("| -TRAILER    <--- Capacidad 40 toneladas  |");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el tipo de Movilidad: ");

            Movilidad = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese la cantidad de peso(En toneladas) que desea transportar: ");

            Capacidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantos kilometros correra hasta el destino de la carga: ");

            KilometroRecorrido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio de combustible por galon:");

            PrecioCombustible = Convert.ToInt32(Console.ReadLine());

            

            switch (Movilidad)
            {
                case "FURGONETA":
                    if (Capacidad >= 5 && Capacidad <= 10)
                    {
                        ConsumoPorGalon = 30;
                    }
                    else if (Capacidad >= 0 && Capacidad <= 5)
                    {
                        ConsumoPorGalon = 35;
                    }
                    break;
                case "CAMION":
                    if (Capacidad >= 10 && Capacidad <= 20)
                    {
                        ConsumoPorGalon = 25;
                    }
                    else if (Capacidad >= 0 && Capacidad <= 10)
                    {
                        ConsumoPorGalon = 30;
                    }
                    break;
                case "TRAILER":
                    if (Capacidad >= 30 && Capacidad <= 40)
                    {
                        ConsumoPorGalon = 15;
                    }
                    if (Capacidad >=20 &&  Capacidad <=30)
                    {
                        ConsumoPorGalon = 20;
                    }
                    if (Capacidad <=20 && Capacidad >= 0)
                    {
                        ConsumoPorGalon = 25;
                    }
                    break;
                default: 
                    Console.WriteLine("Movilidad no reconocida...");
                    break;
            }
            MontoConsumo = KilometroRecorrido / ConsumoPorGalon;
            MontoTotal = MontoConsumo * PrecioCombustible;

            Console.WriteLine("El consumo por galon es:" + ConsumoPorGalon);
            Console.WriteLine("Al usar la movilidad {0} el costo para llevar la carga sera: {1} soles",Movilidad, MontoTotal);
            Console.ReadKey();
        }
    }
}
