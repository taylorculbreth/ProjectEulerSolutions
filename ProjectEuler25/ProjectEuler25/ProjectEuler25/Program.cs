using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger index = 2;
            BigInteger newNum = 1;
            BigInteger oldNum = 0;
            BigInteger fibNum = 0;
            BigInteger limit = BigInteger.Pow(10, 999);
            List<BigInteger> nums = new List<BigInteger>();
            for (int i = 0; i < 5000; i++)
            {
                fibNum = newNum + oldNum;
                oldNum = newNum;
                newNum = fibNum;
                index++;
                nums.Add(fibNum);
                if (fibNum.ToString().Length == 1000)
                {
                    Console.WriteLine((nums.Count + 1) + "    " + fibNum);// + 1 becuase my program doesn't account for f2 == 1
                    Console.ReadLine();
                }
            }
        }
    }
}
