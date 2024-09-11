using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_del_examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantHorasTrabajo;

            double PagoHora, Sueldo, DescuentoAFP, DescuentoESSALUD, BeneficioMovilidad, BeneficioAlimenta;

            Console.WriteLine("Ingrese la cantidad de horas trabajandas a la semana: ");

            CantHorasTrabajo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el monto a pagar por hora: ");

            PagoHora = Convert.ToInt32(Console.ReadLine());

            Sueldo = CantHorasTrabajo * PagoHora;

            DescuentoAFP = Sueldo * 0.12;

            DescuentoESSALUD = Sueldo * 0.05;
            
            BeneficioMovilidad = (Sueldo - (DescuentoAFP + DescuentoESSALUD)) * 0.07;

            BeneficioAlimenta = (Sueldo - (DescuentoAFP + DescuentoESSALUD)) * 0.20;

            Console.WriteLine("El descuento de la AFP es: " + DescuentoAFP);

            Console.WriteLine("El descuento de ESSALUD es: " + DescuentoESSALUD);

            Console.WriteLine("El beneficio por Movilidad es: " + BeneficioMovilidad);

            Console.WriteLine("El beneficio por Alimento es: " + BeneficioAlimenta);

            Console.WriteLine("El total a recibir es: " + (Sueldo - (DescuentoAFP + DescuentoESSALUD)) + BeneficioMovilidad + BeneficioAlimenta);

            Console.ReadKey();






        }
    }
}
