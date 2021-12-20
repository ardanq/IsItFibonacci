using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItFıbonacci
{
    public  class FibonacciNumbers
    {
        public static void GetFibonacci(int n)
        {
            int number = n - 1;
            int[] Fib = new int[n];
            Fib[0] = 0;
            Fib[1] = 1;
            

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }


            //indexof returns -1 when array doesn't contain n

            int index = Array.IndexOf(Fib, n);


            if (index != -1)
            {
                Console.WriteLine("yes");
                
            }
            else
            {
                Console.WriteLine("no");
            }


        }


    }
}
