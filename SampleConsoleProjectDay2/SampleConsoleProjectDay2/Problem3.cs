using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SampleConsoleProjectDay2
{
    class Problem3
    {
        public void GetLargestPrimeFactor(long num)
        {
            var st=new Stopwatch();
            st.Start();
            
            long x = 2;
            long div=0;
            var list=new List<long>();
            var primeList = new List<long> {2};
            for (long i = 1; i<=Math.Sqrt(num); i++)
            {
                if (num%x == 0)
                {
                    div = num/x;
                    if (!list.Contains(x))
                    {
                        list.Add(x);
                    }
                    if (!list.Contains(div))
                    {
                        list.Add(div);
                    }
                }
                x++;
            }
            list.Sort();
            foreach (long prime in list)
            {
                int isPrime = 1;
                if (primeList.Where(l => prime != 2).Any(l => prime%l == 0))
                {
                    isPrime = 0;
                }
                if (isPrime==1)
                {
                    primeList.Add(prime);
                }
            }
            Console.WriteLine("Largest Prime Factor = " +primeList.Max() );
            st.Stop();
            Console.WriteLine(st.ElapsedMilliseconds+" ms");
        }
    }
}
