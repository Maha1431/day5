using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class flip_coin
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" lets flip a coin n  times");
           
            
            Coinflip();
        }
        private static int Coinflip()
        {
            Random random = new Random();
            int heads = 0;
            int tails = 0;
            int result = 0;
            int i, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < n; i++)
            {
                result = random.Next(0, 2);

                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine("head was flipped {0} times", heads);
            Console.WriteLine("tails was flipped {0} times", tails);

            return result;
        }
    }
}
