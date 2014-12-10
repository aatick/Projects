using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class Problem11
    {
        public void GetProduct()
        {
            int[,] numInts =
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            };
            long c = -1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var v=0;
                    var v1=0;
                    var v2=0;
                    try
                    {
                        v = numInts[i, j]*numInts[i + 1, j + 1]*numInts[i + 2, j + 2]*numInts[i + 3, j + 3];
                    }
                    catch { }
                    try
                    {
                        v1 = numInts[i, j]*numInts[i + 1, j]*numInts[i + 2, j]*numInts[i + 3, j];
                    }
                    catch { }
                    try
                    {
                        v2 = numInts[i, j]*numInts[i, j + 1]*numInts[i, j + 2]*numInts[i, j + 3];
                    }
                    catch{}
                    var list = new List<long> {v, v1, v2};
                    if (list.Max() > c)
                        c = list.Max();
                }
            }
            Console.WriteLine(c);
        }
    }
}
