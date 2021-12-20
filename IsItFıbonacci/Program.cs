using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItFıbonacci
{
    internal class Program:FibonacciNumbers
    {
        static void Main(string[] args)
        {
            GetFibonacci(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();

            Console.Read();

        }
    }
}
