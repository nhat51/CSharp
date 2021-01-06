using System;

namespace codesnippet14
{
    class Program
    {
        static void Main(string[] args)
        {
            int investment;
            int retunrs;
            int express;
            int profit;
            int counter = 0;
            for(investment = 1000, retunrs =0; retunrs < investment;)
            {
                Console.WriteLine("Enter the monthly expenditure");
                express = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the monthly profit");
                profit = Convert.ToInt32(Console.ReadLine());
                investment += express;
                retunrs += profit;
                counter++;
            }
            Console.WriteLine("Number of months to break even: " + counter);


        }
    }
}
