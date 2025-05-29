using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(" \t".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            for (int i = 0; i < inputLine.Length; i++)
            {
                string input = inputLine[i];
                char firstLetter = input[0];
                char lastLetter = input[input.Length - 1];
                double number = double.Parse(input.Substring(1, input.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetter - ('A' - 1);
                }
                else if (char.IsLower(firstLetter))
                {
                    number *= firstLetter - ('a' - 1);
                }
                if (char.IsUpper(lastLetter))
                {
                    number -= lastLetter - ('A' - 1);
                }
                else if (char.IsLower(lastLetter))
                {
                    number += lastLetter - ('a' - 1);
                }
                sum += number;
            }
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
