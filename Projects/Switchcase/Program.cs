using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentYear = DateTime.Now.Year.ToString();

            Console.WriteLine("Gib das aktuelle Jahr ein");
            string choice = Console.ReadLine();
            if (choice == currentYear)
            {
                Console.WriteLine("Gib dein Geburtsjahr ein");
                string birthyear = Console.ReadLine();
                int age = Convert.ToInt32(currentYear) - Convert.ToInt32(birthyear);
                string comment = "";
                if (age < 10)
                {
                    comment = "Du bist zu jung um an der Umgfrage mitzumachen";
                }
                else if (age >= 10 && age <= 30)
                {
                    comment = "Du Kannst an der Umfrage teilnehmen";
                }
                else if (age > 30)
                {
                    comment = "Warum sitzt du noch im Schulzimmer!!!";
                }
                Console.WriteLine("Du bist " + age + " Jahre alt" + comment);

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Gib das Richtige Jahr ein"); 
            }
            Console.ReadKey();
        }
    }
}
