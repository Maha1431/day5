﻿using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class even_and_odd
    {
        static void Main(string[] args)
        {
            int Number;
            Console.Write("Enter The Number: ");
            Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
            Console.Read();
        }
    }
}
    
