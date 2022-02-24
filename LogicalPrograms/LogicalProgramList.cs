using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class LogicalProgramList
    {
        //creating method of fibonacci series
        public void FibonacciSeries()
        {
            //take variable a(previous) and b(current) and c(sum of a & b) 
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine();
            Console.WriteLine("*******Fibonacci Serious*********");
            Console.Write(a +",");
            Console.Write(b +",");
            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(c +",");
                a = b;
                b = c;
            }
        }
    }
}
