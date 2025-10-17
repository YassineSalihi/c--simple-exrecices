using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExerciceMatrice2
    {
        static void Main(string[] args)
        {
            int[,] A = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] B = {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            };

            int lignes = A.GetLength(0);
            int colonnes = A.GetLength(1);
            int[,] somme = new int[lignes, colonnes];

            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    somme[i, j] = A[i, j] + B[i, j];
                }
            }

            Console.WriteLine("Résultat de l'addition des deux matrices :");
            for (int i = 0; i < lignes; i++)
            {
                for (int j = 0; j < colonnes; j++)
                {
                    Console.Write(somme[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
