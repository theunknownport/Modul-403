using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int choise;

            Console.WriteLine("1) Zahlen bis 10 ausgeben");
            Console.WriteLine("2) Eigene Zahlen ausgeben");
            choise = Console.Read();

            if (choise == 1)
            {
                int zahlreal;
                zahlreal = 1;
                do
                {
                    Console.WriteLine("Dies ist die Zahl " + zahlreal);
                    zahlreal = zahlreal + 1;
                } while (zahlreal < 10);
                Console.WriteLine("Drücken sie eine beliebige Taste . . .");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gib deine Zahl ein: ");
                int zahluser;
                zahluser = Console.Read();
                for (int i = 1; i < zahluser + 1; i++)
                {
                    Console.WriteLine("Dies ist die Zahl " + i);
                }
                Console.WriteLine("Drücken sie eine beliebige Taste . . .");
                Console.ReadKey();
            }
        }
    }
}
