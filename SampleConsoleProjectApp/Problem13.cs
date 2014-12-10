using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace SampleConsoleProject
{
    class Problem13
    {
        public void ShowAllServices()
        {
            foreach (var x in ServiceController.GetServices())
            {
                Console.WriteLine(x.ServiceName);
            }
        }
    }
}
