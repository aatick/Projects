using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class Problem6
    {
        public void GetDifference()
        {
            long sumOfSquares = 0, squareOfSums = 0;
            for(int i=1; i<=10; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }
            squareOfSums *= squareOfSums;
            Console.WriteLine("Difference: " + (squareOfSums - sumOfSquares));
        }
    }
}
