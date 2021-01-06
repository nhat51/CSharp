using System;

namespace codesnippet6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne;
            int numTwo;
            int result = 0;

            Console.WriteLine("(1) Addtion");
            Console.WriteLine("(2) Subtraction");
            Console.WriteLine("(3) Multiplication");
            Console.WriteLine("(4) Divison");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value one: ");
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value two: ");
            numTwo = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    result = numOne + numTwo;
                    break;
                case 2:
                    result = numOne - numTwo;
                    break;
                case 3:
                    result = numOne * numTwo;
                    break;
                case 4:
                    Console.WriteLine("Do you want to caculate thr quotient or remainder?");
                    Console.WriteLine("(1) Quotent");
                    Console.WriteLine("(2) Remainder");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            result = numOne / numTwo;
                            break;
                        case 2:
                            result = numOne % numTwo;
                            break;
                        default:
                            Console.WriteLine("Incorrect choice");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }
            Console.WriteLine("Result: " + result);



        }
    }
}
