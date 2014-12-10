using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SampleConsoleProject
{
    class Problem12
    {
        public void ShowEventLog()
        {
            foreach (var x in EventLog.GetEventLogs(System.Environment.MachineName))
            {
                Console.WriteLine(x.Log);
            }
        }
    }
}
