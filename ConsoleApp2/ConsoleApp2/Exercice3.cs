using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Exercice3
    {
        static void main(string[] args)
        {
            Console.Write("Entrez le numéro du mois (1-12) : ");
            int mois = int.Parse(Console.ReadLine());

            string nomMois;

            switch (mois)
            {
                case 1:
                    nomMois = "Janvier";
                    break;
                case 2:
                    nomMois = "Février";
                    break;
                case 3:
                    nomMois = "Mars";
                    break;
                case 4:
                    nomMois = "Avril";
                    break;
                case 5:
                    nomMois = "Mai";
                    break;
                case 6:
                    nomMois = "Juin";
                    break;
                case 7:
                    nomMois = "Juillet";
                    break;
                case 8:
                    nomMois = "Août";
                    break;
                case 9:
                    nomMois = "Septembre";
                    break;
                case 10:
                    nomMois = "Octobre";
                    break;
                case 11:
                    nomMois = "Novembre";
                    break;
                case 12:
                    nomMois = "Décembre";
                    break;
                default:
                    Console.WriteLine("Numéro invalide ! Entrez un nombre entre 1 et 12.");
                    return;
            }

            Console.WriteLine($"Le mois numéro {mois} est : {nomMois}");
        }
    }
}
