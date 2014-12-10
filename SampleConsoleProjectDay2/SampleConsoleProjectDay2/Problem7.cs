using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class Problem7
    {
        public void GetPrimeNumber()
        {
            int num = 1, count = 0, isPrime = 1;
            for (; ; )
            {
                num++;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                    else
                        isPrime = 1;
                }
                if (isPrime == 1)
                    count++;
                if (count == 10001)
                {
                    Console.WriteLine("10001st Prime Number: " + num);
                    break;
                }
            }
        }
    }
}
