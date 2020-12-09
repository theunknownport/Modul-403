// file: mehrarray2.cs
// date: 09.12.2020
// creator: Finn Barbieri
// version: 1.00a
// changes: Created and tested script 
// description: Change the content of two arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mehrarray2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fill all letters of the alphabet into a alphabet array
            char[] arrAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            // Create a empty array to randomly fill in the characters 
            char[] arrAlphabetRandom = new char[26];
            // Define the random object
            Random zufall = new Random();
            // Define count variable
            int i = 0;
            // While loop to randomly fill the new array
            while (arrAlphabet.Length != 0 && i  < 26)
            {
                // Get a random number which is in the range of the lenght of the alphabet array
                int intZufallsnumber = zufall.Next(0, arrAlphabet.Length);
                // Add the random choosen entry from the alphabet array to the new array
                arrAlphabetRandom[i] = arrAlphabet[intZufallsnumber];
                // Add 1 to the count variable
                i++;
                // Delete added entry from the alphabet array
                arrAlphabet = arrAlphabet.Where(w => w != arrAlphabet[intZufallsnumber]).ToArray();
            }
            // Print the random filled array
            Console.WriteLine("Das unsortierte, zufällige Array: ");
            Console.WriteLine(arrAlphabetRandom);
            // Sort the random array
            Array.Sort(arrAlphabetRandom);
            // Print the sorted array
            Console.WriteLine("Das sortierte Array: ");
            Console.WriteLine(arrAlphabetRandom);
            // Prevent the programm from closing immediately
            Console.ReadKey();

        }
    }
}
