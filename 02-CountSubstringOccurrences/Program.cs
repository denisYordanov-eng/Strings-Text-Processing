using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CountSubstringOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
           
            string wantedWord = Console.ReadLine().ToLower();

            int wordCounter = 0;
            var lastIndex = -1;
            while (true)
            {
                 lastIndex = word
                    .IndexOf(wantedWord, lastIndex + 1);
                if(lastIndex != -1)
                {
                    wordCounter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(wordCounter);
        }
    }
}
