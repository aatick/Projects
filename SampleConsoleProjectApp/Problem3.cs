using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProject
{
    class Problem3
    {
        public void FindMaximumAndMinimum()
        {
            double num1 = 0, num2 = 0;
            Console.WriteLine("Enter first number: ");
            try
            {
                num1 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                FindMaximumAndMinimum();
            }
            Console.WriteLine("\nEnter second number: ");
            try
            {
                num2 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                FindMaximumAndMinimum();
            }
            if (num1 > num2)
            {
                Console.WriteLine("\nLarge Number: " + num1);
                Console.WriteLine("\nSmall Number: " + num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("\nBoth the numbers are equal.");
            }
            else
            {
                Console.WriteLine("\nLarge Number: " + num2);
                Console.WriteLine("\nSmall Number: " + num1);
            }
                
            Console.ReadLine();
        }
    }
}
