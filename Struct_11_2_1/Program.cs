using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_11_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation linEq = new LinearEquation { k = 2, b = -1 };
            linEq.Root();
            Console.ReadKey();
        }
    }
    struct LinearEquation
    {
        public double k;
        public double b;

        public void Root()
        {
            double x = -b / k;
            Console.WriteLine(x);
        }
    }
}
