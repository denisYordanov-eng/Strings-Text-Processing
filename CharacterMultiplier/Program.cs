using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string word1 = input[0];
            string word2 = input[1];

            int minLength = Math.Min(word1.Length, word2.Length);
            long sum = 0L;
            for (int i = 0; i < minLength; i++)
            {
                sum += word1[i] * word2[i];
            }
            string longerWord = "";
            if (word1.Length > word2.Length)
            {
                longerWord = word1;
            }
            else
            {
                longerWord = word2;
            }
            for (int i = minLength; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }
            Console.WriteLine(sum);
        }
    }
}
