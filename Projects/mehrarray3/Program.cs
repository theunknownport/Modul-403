// file: mehrarray3.cs
// date: 09.12.2020
// creator: Finn Barbieri
// version: 1.00a
// changes: Created and tested script
// description: Change the content of two arrays// file: mehrarray1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mehrarray3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define variable outside of try catch
            int intLaenge = 0;
            // Ask user for array lenght
            try
            {
                Console.WriteLine("Gib deine Array länge ein: ");
                 intLaenge = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            // Create array with given lenght
            char[] arrAlphabetRandom = new char[intLaenge];
            // Create alphabet letter
            char[] arrAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Random zufall = new Random();
            // Define count variable
            int i = 0;
            // While loop to randomly fill the new array
            while (arrAlphabet.Length != 0 && i < intLaenge)
            {
                // Get a random number which is in the range of the lenght of the alphabet array
                int intZufallsnumber = zufall.Next(0, arrAlphabet.Length);
                // Add the random choosen entry from the alphabet array to the new array
                arrAlphabetRandom[i] = arrAlphabet[intZufallsnumber];
                // Add 1 to the count variable
                i++;
            }
            // Print random Array
            Console.WriteLine("Das zufällig gefüllte Array: ");
            Console.WriteLine(arrAlphabetRandom);
            Console.ReadKey();
        }
    }
}
