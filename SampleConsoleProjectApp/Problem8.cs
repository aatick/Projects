using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProject
{
    class Problem8
    {
        public void ShowFibonocciNumberUntil100()
        {
            int a = 0, b = 1, c, d;

            for (;;)
            {
                if (b < 100)
                    Console.WriteLine(a + "\n" + b);
                else
                    break;
                c = a + b;
                d = b + c;
                a = c;
                b = d;
            }
        }
    }
}
