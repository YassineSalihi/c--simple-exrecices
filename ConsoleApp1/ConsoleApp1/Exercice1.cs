using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercice1
    {
        static void main(string[] args)
        {
            Console.WriteLine("Entrer le premier nombre : ");
            string ch1 = Console.ReadLine();
            int nb1 = Convert.ToInt32(ch1);

            Console.WriteLine("Entrer le deuxieme nombre : ");
            string ch2 = Console.ReadLine();
            int nb2 = Convert.ToInt32(ch2);
            
            Console.WriteLine("La somme de deux nombres est : " + (nb1 + nb2));
            Console.WriteLine("La difference des deux nombres est  : " + (nb1  - nb2));

            if (nb2 == 0)
            {
                Console.WriteLine("Division impossible.");
            }
            else {
                Console.WriteLine("La division des deux nombres : " + (nb1 / nb2));
            }

            Console.WriteLine("Le produit des deux nombres est : " + (nb2 *  nb1));



        }
    }
}
