using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleProjectDay2
{
    class Problem4
    {
        public void GetPallindrome()
        {
            long v = 0;
            for (int i = 100; i <= 998; i++)
            {
                for (int j = i + 1; j <= 999; j++)
                {
                    var str = (i*j).ToString();
                    var s = string.Empty;
                    foreach (char c in str.Reverse())
                        s += c;

                    if (s == str && v < Convert.ToInt64(str))
                        v = Convert.ToInt64(str);
                }
            }
            Console.WriteLine(v);
        }
    }
}
