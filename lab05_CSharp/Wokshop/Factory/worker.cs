using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class worker
    {
        private string workerName;
        private int workerID;
        private string designation;
        private double salary;
        private double amount;
        private int yearsOfService;
        Appraisa objAppraisa = new Appraisa();
        public bool InputDetail()
        {
            Console.Write("Enter woker name: ");
            workerName = Console.ReadLine();
            Console.Write("Enter worker ID: ");
            workerID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSelect the designation(1-3): ");
            Console.WriteLine("1.Manager");
            Console.WriteLine("2.Engineer");
            Console.WriteLine("3.Technical");
            Console.Write("Enter the choice: ");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    designation = "Manager";
                    salary = 1000;
                    break;
                case 2:
                    designation = "Engineer";
                    salary = 4000;
                    break;
                case 3:
                    designation = "Technical";
                    salary = 3000;
                    break;
                default:
                    Console.WriteLine("Invalid option selected");
                    break;
            }
        Service:
            Console.Write("Enter the years of service: ");
            yearsOfService = Convert.ToInt32(Console.ReadLine());
           if(yearsOfService < 0)
            {
                Console.WriteLine("Year of service cannot be negative");
                goto Service;

            }
            return true;
        }
        public void DisplayDetails()
        {
            amount = objAppraisa.CaculateBonus(designation, yearsOfService, salary);

            Console.WriteLine("\n\nEmployee Name: " + workerName);
            Console.WriteLine("Employee ID: " + workerID);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + amount + "$");
            Console.WriteLine("Total income earned: " + (amount + salary));

        }
        
        
    }
}
