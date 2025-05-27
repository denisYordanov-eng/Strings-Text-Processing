using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1= Console.ReadLine();
            string number2= Console.ReadLine();

            int longestLength = Math.Max(number1.Length, number2.Length);
            number1 = number1.PadLeft(longestLength, '0');
            number2 = number2.PadLeft(longestLength, '0');

            int carry = 0;
            StringBuilder result = new StringBuilder();

            for (int i = longestLength - 1; i >= 0; i--)
            {
                int digit1 = number1[i] - '0';
                int digit2 = number2[i] - '0';

                int sum = digit1 + digit2 + carry;
                result.Insert(0, sum % 10);
                carry = sum / 10;
            }
            if (carry > 0)
            {
                result.Insert(0, carry);
            }
            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
