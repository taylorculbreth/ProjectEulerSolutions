using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblem10
{
    class Program
    {
        static void Main(string[] args)
        {
            double largestNum = 2000000;
            double tot = 0;
            int i = 1;
            int b = 1;


            for (i = 1; i < 2000000; i+=2)
            {
                if ((i % 2 != 0) && (i % 3 != 0))
                {
                    for (b = 1; b < 2000000; b++)
                    {
                        if ((i % b == 0))
                        {
                            if ((i == b) || (i / b == i))
                            {
                                tot += i;
                                Console.WriteLine(tot);

                            }
                        }
                    }
                }
            }

            Console.WriteLine("final tot:" + tot);
            Console.ReadKey();

        }
    }
}
