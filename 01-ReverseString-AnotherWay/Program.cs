using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReverseString_AnotherWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  word = Console.ReadLine();
            StringBuilder  sb = new StringBuilder();
            for (int i = word.Length -1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
