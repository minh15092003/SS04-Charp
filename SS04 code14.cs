using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS04_code14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int investment;
            int returns;
            int expenses;
            int profit;
            int counter = 0;
            for (investment = 1000,returns =0;returns < investment;)
            {
                Console.WriteLine("Enter the monthly expenditure");
                expenses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the monthly profit");
            }
        }
    }
}
