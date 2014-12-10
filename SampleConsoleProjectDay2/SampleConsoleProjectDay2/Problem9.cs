using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class Problem9
    {
        public void GetPythagoreanNumbers()
        {
            int i = 0;
            bool isFind = false;
            while (!isFind)
            {
                i++;
                for (int j = 1; j < i; j++)
                {
                    for (int k = 1; k < j; k++)
                    {
                        long a = i * i, b = j * j, c = k * k;
                        if ((i + j + k) == 1000 && (b + c) == a)
                        {
                            Console.WriteLine("Numbers: "+k + ", " + j + ", " + i+"\nProduct: "+i*j*k);
                            isFind = true;
                        }
                        if (isFind)
                            break;
                    }
                    if (isFind)
                        break;
                }

            }
        }
    }
}
