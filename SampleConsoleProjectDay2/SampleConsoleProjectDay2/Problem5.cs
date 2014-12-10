using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class Problem5
    {
        
        public void GetSmallestMultiple()
        {
            long num = 0;
            bool isSmallest = false;
            while (isSmallest == false)
            {
                num++;
                
                for (long i = 1; i <= 20; i++)
                {
                    if (num%i != 0)
                    {
                        isSmallest = false;
                        break;
                    }
                    else
                    {
                        isSmallest = true;
                    }
                }
                if (isSmallest)
                    Console.WriteLine(num);
            }
            
        }
    }
}
