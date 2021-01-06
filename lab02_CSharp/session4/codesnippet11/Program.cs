using System;

namespace codesnippet11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Even numbers ");
            for(num = 1; num < 11; num++)
            {
                if ((num % 2)== 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
