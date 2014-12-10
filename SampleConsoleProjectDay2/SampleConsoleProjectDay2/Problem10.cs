using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using  System.Diagnostics;

namespace SampleConsoleProjectDay2
{
    class Problem10
    {
        public void GetSumOfPrimes()
        {
            var st=new Stopwatch();
            
            const long con = 2000000;
            var listPrime=new List<long>{2};
            long v = 2;
            st.Start();
            for (long i = 3; i < con; i += 2)
                listPrime.Add(i);
            /*for (var i = 4; i < listPrime.Count; i+=3)
            {
                listPrime.RemoveAt(i);
                i--;
            }*/
            while(listPrime.Any(x=>x>v))
            {
                v = listPrime.Find(x => x > v);
                for (var c = 3; v*c < con; c+=2)
                {
                    if (listPrime.Any(x => x == v*c))
                        listPrime.Remove(v*c);
                }
            }
            /*foreach (var l in listPrime)
            {
                Console.WriteLine(l);
            }*/
            Console.WriteLine(listPrime.Sum());
            st.Stop();
            Console.WriteLine(st.Elapsed.Minutes+" "+st.Elapsed.Seconds+" "+st.Elapsed.Milliseconds);
        }
    }
}
