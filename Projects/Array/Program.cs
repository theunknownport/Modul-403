using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] arrResult = new string[24];

            Random zufall = new Random();
            int i = 0;

            while (arrAlphabet.Length > 0)
            {
                int intZahl = zufall.Next(0, arrAlphabet.Length);
                arrResult[i] = arrAlphabet[intZahl];
                arrAlphabet = arrAlphabet.Where((source, index) => index != i).ToArray();
                Console.Write(arrResult[i]);
            }
            Console.WriteLine("Das durchgewürfelte Array sieht wie folgt aus");
            for (int j = 0; j < arrResult.Length; j++)
            {
                Console.WriteLine(arrResult[j]);
            }
            Console.ReadKey();

        }
    }
}
