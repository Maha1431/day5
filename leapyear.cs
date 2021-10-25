using System;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year=");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 100 == 0)
            {
                if (num1 % 400 == 0)

                    Console.WriteLine(" It is a leapyear ");


                else

                    Console.WriteLine(" It is not leapyear ");
            }


            else

            {
                if (num1 % 4 == 0)

                    Console.WriteLine(" It is a leapyear ");


                else

                    Console.WriteLine("It is not leapyear ");
            }


            Console.Read();

        }


    }
}
    

