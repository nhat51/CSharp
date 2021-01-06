using System;

namespace codesnippet7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the month");
            input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "JANUARY":
                case "MARCH":
                case "MAY":
                case "JULY":
                case "AUGUST":
                case "OCTOBER":
                case "DECEMBER":
                    Console.WriteLine("This months has 31 days");
                    break;
                case "APRIL":
                case "JUNE":
                case "SEPTEMBER":
                case "NOVEMBER":
                    Console.WriteLine("This months has 30 days");
                    break;
                case "FEBRUARY":
                    Console.WriteLine("This month has 28 days in a non-leap yaer" +
                        "and 29 days in a leap year");
                    break;
            }
        }
    }
}
