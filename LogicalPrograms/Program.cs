using System;
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
            //calling method by class name because it is static method
            LogicalProgramList.GetCoupons();
            Console.ReadKey();
        }
    }
}
