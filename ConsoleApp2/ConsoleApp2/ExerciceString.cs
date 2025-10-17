using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExerciceString
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter une phrase : ");
            string texte = Console.ReadLine();

            int voyelles = 0;
            int consonnes = 0;

            foreach (char c in texte.ToLower())  
            {
                if (Char.IsLetter(c))  
                {
                    if ("aeiouy".Contains(c))
                        voyelles++;
                    else
                        consonnes++;
                }
            }

            Console.WriteLine($"Nombre de voyelles : {voyelles}");
            Console.WriteLine($"Nombre de consonnes : {consonnes}");
        }


    }
    }

