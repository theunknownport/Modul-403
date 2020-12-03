using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatur
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Bitte geben sie die Temperatur ein:");
            input = Console.ReadLine();

            Console.WriteLine("Es ist " + input + " Grad warm");

            Console.WriteLine("Drücken sie eine beliebige Taste . . .");
            Console.ReadLine();

        }
    }
}
