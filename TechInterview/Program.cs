using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            int Odds = 0;
            int[] intArray = { 1, 2, 7, 8, 5, 13, 7, 20, 33, 10 };
            for (int i = 0; i < intArray.Length; i++)
            {
                if ((intArray[i] % 2) != 0)
                {
                    Odds += intArray[i];
                }
            }
            Console.WriteLine(Odds);
            Console.ReadLine();


            long Adder = 0; // long is used because some integers may be very large - this is the largest whole number data type
            for (int i = 0; i < intArray.Length; i++)
            {
                Adder += intArray[i];
            }
            Console.WriteLine(Adder);
            Console.ReadLine();


            string txt = "timothycalhoun";
            StringBuilder reverse = new StringBuilder();
            for (int i = txt.Length-1; i >= 0;  i--)
            {
                reverse.Append(txt[i]);
            }
            Console.WriteLine(reverse);
            Console.ReadLine();


            string removeRepeats = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if (removeRepeats.IndexOf(txt[i]) == -1)
                {
                    removeRepeats += txt[i];
                }
            }
            Console.WriteLine(removeRepeats);
            Console.ReadLine();


            // Fizzbuzz
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) & (i % 5 != 0))
                {
                    Console.WriteLine(i + " is divisible by 3... FIZZ!!!");
                }
                if ((i % 3 != 0) & (i % 5 == 0))
                {
                    Console.WriteLine(i + " is divisible by 5... BUZZ!!!");
                }
                if ((i % 3 == 0) & (i % 5 == 0))
                {
                    Console.WriteLine(i + " is divisible by 3 & 5... FIZZBUZZ!!!");
                }
            }
            Console.ReadLine();
        }
    }
}
