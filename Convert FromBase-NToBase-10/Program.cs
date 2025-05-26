using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Convert_FromBase_NToBase_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputNum = Console.ReadLine().Split(' ');

           int @base = int.Parse(inputNum[0]);
           string num = new string(inputNum[1].Reverse().ToArray());
           
            BigInteger sum = 0;

            for (int power = 0; power < num.Length; power++)
            {
                int currentNumber = int.Parse(num[power].ToString());
                sum += (currentNumber * (decimal)Math.Pow(@base, power));
            }
            Console.WriteLine(sum);
        }
    }
}
