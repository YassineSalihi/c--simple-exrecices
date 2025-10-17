using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercice3
    {
        static int factioal(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * factioal(n - 1);
            }
        }
        static void main(string[] args)
        {
            Console.WriteLine(factioal(5));
        }
    }
}
