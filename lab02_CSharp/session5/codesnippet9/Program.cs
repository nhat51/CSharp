using System;

namespace codesnippet9
{
    class Program
    {
         void Students()
        {
            Console.WriteLine("Enter the number of students: ");
            int noOfstds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of exams: ");
            int exams = Convert.ToInt32(Console.ReadLine());

            string[] stdNmae = new string[noOfstds];
            string[,] details = new string[noOfstds, exams];

            for(int i = 0; i < noOfstds; i++)
            {
                Console.WriteLine();
                Console.Write("Enter the students Name: ");
                stdNmae[i] = Convert.ToString(Console.ReadLine());
                for(int y = 0; y < exams; y++)
                {
                    Console.Write("Enter score in exam" + (y + 1) + ":");
                    details[i, y] = Convert.ToString(Console.ReadLine());

                }

            }
            Console.WriteLine();
            Console.WriteLine("Students Exams details");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("Students\t\tMarks");
            Console.WriteLine("-----\t\t-----");
            for(int i = 0; i < stdNmae.Length; i++)
            {
                Console.WriteLine(stdNmae[i]);
                for(int j = 0; j < exams; j++)
                {
                    Console.WriteLine("\t\t" + details[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Program objProgram = new Program();
            objProgram.Students();
        }
    }
}
