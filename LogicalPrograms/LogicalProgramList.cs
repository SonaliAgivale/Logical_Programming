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

        //creating method for Perfect Number
        public void PerfectNumber()
        {
            Console.WriteLine();
            Console.WriteLine("******** Perfect Number ********");
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int n = num;
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }

            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is Perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered number is not perfect number");
                Console.ReadLine();
            }

        }

    }
}

