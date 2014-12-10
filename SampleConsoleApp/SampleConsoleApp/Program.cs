using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double inputNumber = 19;
            Console.WriteLine(GetSquare(inputNumber));
            Console.ReadLine();
        }

        static double GetSquare(double aValue)
        {
            double squareValue = aValue*aValue;
            return squareValue;
        }
    }
}
