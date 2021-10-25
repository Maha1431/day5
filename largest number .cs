using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class largest_number
    {
        public static void Main()
        {
            int num1, num2, num3;
            Console.Write("Find the largest of three numbers:\n");

            Console.Write("Enter  the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the largest among three numbers. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the largest among three numbers. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the largest among three numbers \n\n");
            else
                Console.Write("The 3rd Number is the largest among three numbers \n\n");
        }
    }
}

