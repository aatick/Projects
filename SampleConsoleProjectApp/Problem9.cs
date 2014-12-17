using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Forms;

namespace SampleConsoleProject
{
    class Problem9
    {
        public void EnumerateKeysRecurse(string keyPath)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey regKey = hklm.OpenSubKey(keyPath);
            string[] subKeys = regKey.GetSubKeyNames();

            foreach (string subKey in subKeys)
            {
                string fullPath = keyPath + "\\" + subKey;
                this.EnumerateKeysRecurse(fullPath);
                Console.WriteLine(fullPath);
            }
        }
    }
}
