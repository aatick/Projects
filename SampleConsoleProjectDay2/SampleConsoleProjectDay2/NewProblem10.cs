using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class NewProblem10
    {
        public void GetSum()
        {
            const long con = 2000000;
            long sum = 0,prime=0;
            //bool isPrime = true;
            List<long> listPrime = new List<long>();
            for (long i = 2; i < con; i++)
            {
                listPrime.Add(i);
            }
            foreach (long num in listPrime)
            {
                for (int j = 2; prime < con; j++)
                {
                    prime = num*j;
                    listPrime.Remove(prime);
                }
            }
            foreach (long number in listPrime)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
