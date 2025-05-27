using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();

            
            for (int i = 0; i < inputWord.Length; i++)
            {
                int letter = (int)(inputWord[i]);
               Console.Write("\\u{0:x4}",letter);
            }  
          
        }
    }
}
