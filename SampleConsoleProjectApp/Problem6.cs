using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProject
{
    class Problem6
    {
        public void ShowAllIntegers()
        {
            int lower = 0, upper = 0;
            Console.WriteLine("Enter Lower limit: ");
            try
            {
                lower = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                ShowAllIntegers();
            }
            Console.WriteLine("\nEnter Upper limit: ");
            try
            {
                upper = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number.");
                ShowAllIntegers();
            }
            Console.WriteLine("\n");
            for (int i = lower; i <=upper; i++)
            {
                Console.WriteLine(i+"\n");
            }
        }
    }
}
