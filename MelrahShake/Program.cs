using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MelrahShake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key = Console.ReadLine();

            while (true)
            {
                var rightIndex = input.LastIndexOf(key);
                var leftIndex = input.IndexOf(key);

                var leftIndexExists = leftIndex != -1;

                var rightIndexExists = rightIndex != -1;

                var leftIndexRightIndexAreEqual = leftIndex == rightIndex;

                var keyIsEmpty = key == String.Empty;
                
                if(leftIndexExists &&
                    rightIndexExists &&
                    !leftIndexRightIndexAreEqual &&
                    !keyIsEmpty)
                {
                   input = input.Remove(rightIndex, key.Length);
                   input = input.Remove(leftIndex, key.Length);
                    
                  key = key.Remove(key.Length / 2,1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
