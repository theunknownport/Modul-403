// --------------------------------------------
// Datei:			Satelit.cs
// Datum:			27.11.2020
// Ersteller:		Finn Barbieri terreActive AG
// Version:		    1.00
// Änderungen:		
// Beschreibung:
// Berechne die Umlaufzeit eines Sateliten
// --------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sateliten_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Willkommen beim Sateliten rechner. Bitte gib deine Höhe ein: ");

                try
                {
                int height = Convert.ToInt32(Console.ReadLine());
                }
                
               
                double pi = Math.PI;
                double Re = 6378137.0;
                double g = 9.81;
                double powr1 = Re + Convert.ToDouble(height);
                double powr12 = Math.Pow(powr1, 3);
                double part1 = pi / Re;
                double part2 = powr12 / g;
                double part21 = Math.Pow(Convert.ToDouble(part2), Convert.ToDouble(0.50));
                double t = 2 * part1 * part21;
                Console.WriteLine(Convert.ToString(t));
                Console.ReadKey();
        }
    }
}
