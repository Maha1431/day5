using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class divider
    {
        public static void Main(string[] args)
        {

            int x, y, q, r;
            Console.Write(" Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            q = x / y;
            r = x % y;

            Console.WriteLine("Quotient is:" + q);
            Console.WriteLine("Reminder is:" + r);
        }

         



        

        
    }

}
