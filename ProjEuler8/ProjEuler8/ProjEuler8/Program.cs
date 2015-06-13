using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEuler8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var primeNum = 1;
            bool isPrimne = false;
            var sqrt = 0.0;
            var j = 1;
            for (int k = 1; k < 100000000000; k++)
            {
                if (k != 0)
                {
                    sqrt = GetSqrRoot(k);
                }

                if (sqrt != 0.0)
                {
                   isPrimne = IsNumberAPrime(k, sqrt);
                }
                if (isPrimne)
                {
                    if (j == 10 || j == 100 || j == 10000 || j == 10001 || j == 10002 || j == 10003 || j == 10004)
                    {
                        Console.WriteLine(k);
                    }
                    j++;
                }
            }
        }

        public static double GetSqrRoot(double num)
        {
            var sqrt = 0.0;
            sqrt = Math.Sqrt(num);
            return sqrt;
        }

        private static bool IsNumberAPrime(double num, double sqrt)
        {
            var isPrime = true;
            var remainder = 0.0;

            if (num != 0.0 && sqrt != 0.0)
            {
                for (double i = 2; i <= sqrt; i++)
                {
                    remainder = num % i;
                    if (remainder == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            return isPrime;
        }
    }
}
