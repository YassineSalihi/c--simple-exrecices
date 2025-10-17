using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercice2
    {
        static void main(string[] args)
        {
            int max = 0;
            int[] entiers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            for (int i = 0; i < entiers.Length; i++)
            {
                if (entiers[i] > max) { max = entiers[i]; }
            }
            Console.WriteLine(max);
        }
    }
}
