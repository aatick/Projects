using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProject
{
    class Problem4
    {
        public void GetGreeting()
        {
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nHi "+name+", good day.");
        }
    }
}
