using System;

namespace codesnippet8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classOne = { "Alan", "Chris", "Monica" };
            string[] classTwo = { "Katie", "Niel", "Mark" };
            Console.WriteLine("students of class I:\tStudents of Class II");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);
            }
            classTwo = classOne;
            Console.WriteLine("\nStudents of classII after referencing classI: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(classTwo[i] + "");


            }
            Console.WriteLine();
            classTwo[2] = "Mike";
            Console.WriteLine("Students of class I after changing the third students in class II:   ");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "");
            }
        }
    }
}
