using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class ExerciceString5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un chaine de charactere : ");
            string text = Console.ReadLine();

            char[] cArray = text.ToCharArray();
            string reverse = "";
            for (int i = cArray.Length - 1; i > -1; i--) { 
                reverse = reverse + cArray[i];
            }
            
            Console.WriteLine(reverse);

        }
    
    }
}
