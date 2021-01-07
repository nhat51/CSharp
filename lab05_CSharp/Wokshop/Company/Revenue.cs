using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Revenue : Expenditure
    {
        private double totalIncome;
        private double balance;

        internal override void AcceptDetails()
        {
            Console.WriteLine("\n");
            base.AcceptDetails();
            Console.Write("Enter the venue earned annually");
            totalIncome = Convert.ToDouble(Console.ReadLine());
        }

        internal override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Totalincome\t\t\t" + totalIncome);
            balance = totalIncome - TotalExpenses;
            if(balance < 0)
            {
                Console.WriteLine("Net loss: " + balance);
            }
            else
            {
                Console.WriteLine("Net Profit: " + balance);
            }
        }
    }
}
