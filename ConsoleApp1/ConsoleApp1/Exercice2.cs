using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercice2
    {
        static void main(string[] args)
        {
            Console.WriteLine("Entrer l'année : ");
            int annee = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le numéro du mois (1-12) : ");
            int mois = int.Parse(Console.ReadLine());

            var months31 = new[] { 1, 3, 5, 7, 8, 10, 12 };
            var months30 = new[] { 4, 6, 9, 11 };

            int jours;

            if (Array.Exists(months31, m => m == mois))
            {
                jours = 31;
            }
            else if (Array.Exists(months30, m => m == mois))
            {
                jours = 30;
            }
            else if (mois == 2)
            {
                if ((annee % 4 == 0 && annee % 100 != 0) || (annee % 400 == 0))
                    jours = 29;
                else
                    jours = 28;
            }
            else
            {
                Console.WriteLine("Numéro de mois invalide !");
                return;
            }

            Console.WriteLine($"Le mois {mois} de l'année {annee} contient {jours} jours.");
        }

    }
}
