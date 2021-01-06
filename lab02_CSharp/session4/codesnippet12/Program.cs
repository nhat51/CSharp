using System;

namespace codesnippet12
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 2;
            int columns = 2;
            for(int i = 0; i< row; i++)
            {
                for(int j =0; j < columns; j++)
                {
                    Console.Write("{0}", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
