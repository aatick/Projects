using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProject
{
    class Problem2
    {

        public void GetSummation()
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
                GetSummation();
            }
            Console.WriteLine("\nEnter second number: ");
            try
            {
                num2 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                GetSummation();
            }
            Console.WriteLine("\n" + (num1 + num2));
            Console.ReadLine();
        }

        public void GetSubtraction()
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
                GetSubtraction();
            }
            Console.WriteLine("\nEnter second number: ");
            try
            {
                num2 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                GetSubtraction();
            }
            Console.WriteLine("\n" + (num1 - num2));
            Console.ReadLine();
        }

        public void GetMultiplication()
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
                GetMultiplication();
            }
            Console.WriteLine("\nEnter second number: ");
            try
            {
                num2 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                GetMultiplication();
            }
            Console.WriteLine("\n" + (num1 * num2));
            Console.ReadLine();
        }
        public void GetDivision()
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
                GetMultiplication();
            }
            Console.WriteLine("\nEnter second number: ");
            try
            {
                num2 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                GetMultiplication();
            }
            Console.WriteLine("\n" + (num1 / num2));
            Console.ReadLine();
        }

    }
}
