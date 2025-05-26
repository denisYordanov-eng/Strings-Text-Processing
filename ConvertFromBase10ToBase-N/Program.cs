using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10ToBase_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');

            int @base = int.Parse(numbers[0]);

            var num = BigInteger.Parse(numbers[1]);

            StringBuilder sb =  new StringBuilder();
            while (num > 0)
            {
                var remainder = num % @base;
                sb.Append(remainder);
                num /= @base;
            }
            string reversed = new string
                (sb.ToString().Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
