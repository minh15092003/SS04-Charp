﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("EvenNumbers");
            do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            } while (num <= 11);
        }
    }
}
