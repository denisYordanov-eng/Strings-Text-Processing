using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string reverseWord = 
                new string(word.Reverse().ToArray());

            Console.WriteLine(reverseWord);
        }
    }
}
