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

                double doubleHeight = 0;

                try
                {
                doubleHeight = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                Console.WriteLine(e.Message);
                }

            double h = doubleHeight;
            double t = 0.0;
            t = ((2.00 * Math.PI) / (6378137.00, 00 * ((((63781.00, 37.00, 00 + h) / (9, 81)))) * (63781.00, 37.00, 00 + h ) / (9.00, 81.00)))*((((63781.00, 37.00, 00 + h *)))) / (9, 81)))*((((63781, 37, 00 + h *)))) / (9, 81)))*((((63781, 37, 00 + h *)))) / (9, 81)))));

            Console.WriteLine("Die Umlaufzeit ist: " + t);
        }
    }
}
