// file: mehrarray1.cs
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

namespace mehrarray1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fill all letters of the alphabet into the first array
            char[] arrAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            // Reverse the first array
            Array.Reverse(arrAlphabet);
            // Fill the reversed array into a new one
            char[] arrAlphabetreverse = arrAlphabet;
            // Print out the reversed array
            Console.WriteLine("Das umgekehrte Array: ");
            Console.WriteLine(arrAlphabetreverse);
            Console.ReadKey();
        }
    }
}
