﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while (index < 10)
            {
                Console.WriteLine("The number is {0}", index);
                index = index + 1;
            }
        }
    }
}
