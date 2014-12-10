using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class Problem2
    {
        public void GetSumOfEvenFibonocciNum()
        {
            int a = 1, b = 2, c, d;
            double sum = 0;
            for (; ; )
            {
                if (b <= 4000000)
                {
                    if (a%2 == 0)
                        sum += a;
                    if (b%2 == 0)
                        sum += b;
                }  
                else
                    break;
                c = a + b;
                d = b + c;
                a = c;
                b = d;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
