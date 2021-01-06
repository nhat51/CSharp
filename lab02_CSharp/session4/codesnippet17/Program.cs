using System;

namespace codesnippet17
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int num, i;
            Console.WriteLine("Enter the number whose factorial you wish to caculate");
            num = Convert.ToInt32(Console.ReadLine());
            for(i =1; i <= num; fact *= i++)
            {
                Console.WriteLine("Factorial: " + fact);
            }
        }
    }
}
