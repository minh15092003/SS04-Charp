using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS04_code3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            if (num < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if ((num % 2) == 0)
                Console.WriteLine("The number is even");
        }
    }
}
