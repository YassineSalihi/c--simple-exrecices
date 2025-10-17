using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExerciceMatrice1
    {
        static void main(string[] args)
        {
            int[,] matrice = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int somme = 0;

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    somme = somme + matrice[i, j];
                }
            }
            Console.WriteLine("Somme est : " + somme);
        }
    }
}
