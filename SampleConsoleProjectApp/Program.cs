﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Forms;

namespace SampleConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            new Problem13().ShowAllServices();
        }
    }
}
