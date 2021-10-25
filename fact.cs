using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Fact

    {
         static void Main(string[] args)
        {
            int n, fact=1, i;
            Console.WriteLine(" Enter n values ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
                Console.WriteLine(" fact:" + fact);
            }
            Console.WriteLine("Factorial Number:" + fact);
        }
    }
}
