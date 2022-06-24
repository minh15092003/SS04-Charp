using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS04_code5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yrsOFService = 3;
            double salary = 1500;
            int bonus = 0;
            if (yrsOFService < 5)
            {
                if (salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonus amount :" + bonus);
        }
    }
}
