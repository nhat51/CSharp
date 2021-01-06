using System;

namespace codesnippet11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[3] { "Ashley", "Joe", "Mikel" };
            foreach(string studName in studentName)
            {
                Console.WriteLine("Congratulations!!" + studName + " you have been gratned an extra leave");
            }
        }
    }
}
