using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProject
{
    class Problem11
    {
        public void ShowEnvironment()
        {
            foreach (DictionaryEntry x in Environment.GetEnvironmentVariables())
            {
                Console.WriteLine(x.Key+"  =  "+x.Value);
            }
        }
    }
}
