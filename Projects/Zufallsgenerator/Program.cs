using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallsgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Gib die Länge deines Zufallsstrings ein:");
            //int choise = Convert.ToInt32(Console.ReadLine());
            string final = "";
            int i = 1;
            Random zufall = new Random();
            while (true)
            {
                int intZahl = zufall.Next(1, 51);
                final = final + ", " + Convert.ToString(intZahl);
                Console.WriteLine("Dein Zufallsstring ist: " + final);

                //i++;
            }
            Console.WriteLine("Dein Zufallsstring ist: " + final);
            Console.ReadKey();

        }
    }
}
