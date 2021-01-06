using System;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 13;
            if (num < 10)
            {
                Console.WriteLine("The number is neagtive");
            }else if ((num % 2) == 0)
            {
                Console.WriteLine("The number is even");
            }
        }
    }
}
