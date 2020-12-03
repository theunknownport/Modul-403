using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiprogramm
{
    class Program
    {
        static void Main(string[] args)
        {
            int intWeiter = 0;
            do
            {
                intWeiter = 0;
                Console.WriteLine("Wähle deine Option");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("1) Fläche Rechteck");
                Console.WriteLine("2) Umfang Kreis");
                Console.WriteLine("3) Diagonale Quadrat");
                Console.WriteLine("4) Guten Tag");
                string choice = Console.ReadLine();
                Console.Clear();
                if (Convert.ToInt32(choice) == 1)
                {
                    Console.WriteLine("Gib deine Länge ein:");
                    string length = Console.ReadLine();
                    Console.WriteLine("Gib deine Höhe ein:");
                    string height = Console.ReadLine();
                    Console.Clear();
                    double result = Convert.ToDouble(length) * Convert.ToDouble(height);
                    Console.WriteLine("Deine Fläche ist " + result);
                }
                else if (Convert.ToInt32(choice) == 2)
                {
                    Console.WriteLine("Gib deinen Durchmesser ein:");
                    string diameter = Console.ReadLine();
                    double result = Convert.ToDouble(diameter) * Math.PI;
                    Console.WriteLine("Dein Umfang ist " + result);
                }
                else if (Convert.ToInt32(choice) == 3)
                {
                    Console.WriteLine("Gib deine Länge ein:");
                    string lenght = Console.ReadLine();
                    double result = Math.Sqrt(Math.Pow(Convert.ToDouble(lenght), 2) + Math.Pow(Convert.ToDouble(lenght), 2));
                    Console.WriteLine("Die Diagonale ist " + result);
                }
                else if (Convert.ToInt32(choice) == 4)
                {
                    Console.WriteLine("Guten Tag");
                }
                Console.WriteLine("Willst du weiter machen? (0 für Ja, 1 für Nein)");
                intWeiter = Convert.ToInt32(Console.ReadLine());
            } while (intWeiter == 0);
        }
    }
}
