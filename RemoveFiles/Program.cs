﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Settings settings = new Settings(args);
            settings.Execute();
        }
    }
}
