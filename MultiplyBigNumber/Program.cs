using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine().TrimStart('0');
            string number2 = Console.ReadLine().TrimStart('0');

            int length1 = number1.Length;
            int length2 = number2.Length;

            int[] result = new int[length1 + length2];

            for (int i = length1 - 1; i >= 0; i--)
            {
                int digit1 = number1[i] - '0';

                for (int j = length2 - 1;  j >= 0;  j--)
                {
                    int digit2 = number2[j] - '0';
                    int product = digit1 * digit2;
                    int p1 = i + j;
                    int p2 = i + j + 1;

                    int sum = product + result[p2];
                    result[p2] = sum % 10;
                    result[p1] += sum / 10;
                }
                
            }
            StringBuilder sb = new StringBuilder();

            foreach (int num in result)
            {
                if (!(num == 0 && sb.Length == 0))
                {
                    sb.Append(num);
                }
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
