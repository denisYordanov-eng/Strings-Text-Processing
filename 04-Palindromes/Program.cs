using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new[] { ',', '.','!','?',' ' }
                ,StringSplitOptions.RemoveEmptyEntries );

            List<string> palindromes = new List<string>();
            foreach (var w in words)
            {
                string reversedWord = new string(w.Reverse().ToArray());
                if(w == reversedWord)
                {
                    palindromes.Add(reversedWord);
                }
            }
           var filteredPalindromes = palindromes.Distinct().OrderBy(w =>w).ToList();
            Console.WriteLine(string.Join(", ", filteredPalindromes));
        }
    }
}
