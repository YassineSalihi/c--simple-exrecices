using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercice4
    {
        static void Main(string[] args)
        {
            int nombre;

            do
            {
                Console.Write("Entrez un nombre entre 10 et 20 : ");
                nombre = int.Parse(Console.ReadLine());

                if (nombre < 10)
                {
                    Console.WriteLine("Plus grand !");
                }
                else if (nombre > 20)
                {
                    Console.WriteLine("Plus petit !");
                }

            } while (nombre < 10 || nombre > 20);

            Console.WriteLine("Bravo ! Vous avez entré un nombre correct : " + nombre);
        }
    }
}
