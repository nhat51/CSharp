using System;

namespace ippet2
{
    class Supplier
    {
        private int supplierID;
        private string supplierName;
        private string City;
        private string phoneNo;
        private string email;
        internal void AccrptDetails()
        {
            Console.Write("Enter The ID of Supplier:");
            supplierID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name of supplier:");
            supplierName = Console.ReadLine();
            Console.Write("Enter name of the city:");
            City = Console.ReadLine();
            Console.Write("Enter phone no:");
            phoneNo = Console.ReadLine();
            Console.Write("Enter email address: ");
            email = Console.ReadLine();
        }
        internal void DisplayDetails(int supplierID)
        {
            Console.WriteLine("Supplier ID: " + supplierID);
        }
        internal void DisplayDetails(string supplierName)
        {
            Console.WriteLine("Supplier Name: " + supplierName);
        }
        internal void DisplayDetails(int supplierID, string supplierName)
        {
            Console.WriteLine("Supplier {0} with ID {1} lives in City {2}", supplierName, supplierID, City);
        }
    }
    
}
