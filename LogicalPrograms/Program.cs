﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogicalProgramList list=new LogicalProgramList();
            list.FibonacciSeries();
            Console.ReadKey();
        }
    }
}
