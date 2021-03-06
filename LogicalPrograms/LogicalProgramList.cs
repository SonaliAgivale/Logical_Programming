using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Diagnostics;


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

        //creating method for Prime Number. 
        //Prime number means the number is divided by 1 or that number itself ex:3,7,11...
        public void PrimeNumber()
        {
            int n, m = 0, flag = 0;
            Console.WriteLine();
            Console.WriteLine("******** Prime Number ********");
            Console.Write("Please enter the number:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            //we initialize i=2 because ever number is divisible by 1
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("The entered number is not a Prime number.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("The entered number is a Prime number. ");
        }

        //Creating method Reverse Number as static so we can called it using class name no need create object
        public static void reverseNo()
        {
            Console.WriteLine();
            Console.WriteLine("********* Reverse Number *********");
            Console.Write("Enter the Number:");
            int number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (number > 0)
            {
                int rem = number % 10;
                Reverse = (Reverse * 10) + rem;
                number = number / 10;
            }
            Console.WriteLine("Reverse Number is: {0}", Reverse);
            Console.ReadLine();
        }

        //coupan number  
        public static void GetCoupons()
        {
            List<int> coupons = new List<int>();
            Random rand = new Random();
            int randomInput;
            Console.WriteLine();
            Console.WriteLine("******** Coupons Numbers ********");
            Console.Write("Please enter the number:");
            int n = int.Parse(Console.ReadLine());
            while (coupons.Count < n)
            {
                randomInput = rand.Next(1, n + 1);
                if (coupons.Contains(randomInput) is false)
                    coupons.Add(randomInput);
            }
            Console.WriteLine("Generated Coupons are:");
            foreach (int coupon in coupons)
            Console.Write(coupon + " ");
        }

        //Creating static method for StopWatch
        public static void TimeElapsed()
        {
            Stopwatch timer = Stopwatch.StartNew();
            Console.WriteLine();
            Console.WriteLine("******** Stop Watch *********");
            Console.WriteLine("Enter any key to start timer");
            Console.ReadKey(true);
            timer.Start();
            Console.WriteLine("Enter any key to stop timer");
            Console.ReadKey(true);
            timer.Stop();
            Console.WriteLine("Time elapsed: " + timer.Elapsed);
        }
    }

}

