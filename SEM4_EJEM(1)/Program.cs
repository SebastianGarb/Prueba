using System;
using System.Net;


namespace SEM4_EJEM_1_
{
    internal class Program
    {
        static void Main(string[] args, ConsoleColor consoleColor)
        {
            Console.WriteLine("hola");

            string nombre;

            Console.WriteLine("¿Como te llamas?");

            nombre =Console.ReadLine();


            Console.WriteLine( "Mucho gusto " + nombre + " es un placer");

            Console.WriteLine("¿Cual tu animal favorito?");

            string animal;

            animal = Console.ReadLine();

            Console.WriteLine(" Que bien a mi tambien me encantan " + animal);

             
        }
    }
}
