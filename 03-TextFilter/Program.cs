﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine()
                .Split
                (new[] {',',' '},StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text
                        .Replace
                        (banWord, new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
