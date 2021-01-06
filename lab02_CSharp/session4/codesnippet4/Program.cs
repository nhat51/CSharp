using System;

namespace codesnippet4
{
    class Program
    {
        static void Main(string[] args)
        {
            int yrsOfService = 3;
            double salary = 1500;
            int bouns = 0;
            if(yrsOfService < 5)
            {
                if(salary < 500)
                {
                    bouns = 100;

                }
                else
                {
                    bouns = 200;
                }
            }
            else
            {
                bouns = 700;
            }
            Console.WriteLine("Bounus amount: "+ bouns)
        }
    }
}
