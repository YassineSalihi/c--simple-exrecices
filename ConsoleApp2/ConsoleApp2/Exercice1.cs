using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercice1
    {
        static void main(String[] args)
        {
            int somme = 0;
            int[] entiers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            foreach (int i in entiers)
            {
                somme = somme + i;
            }
            Console.WriteLine(somme);
        }
    }
}
