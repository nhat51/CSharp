using System;

namespace Workshop
{
    class Supplier
    {
        private int supplierID;
        private string supplierName;
        private string City;
        private string phoneNo;
        private string email;
        public void AcceptDetails()
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
        public void DisplayDetails()
        {
            Console.WriteLine("Supplier Details: ");
            Console.WriteLine("Supplier ID: " + supplierID);
            Console.WriteLine("Supplier Name: " + supplierName);
            Console.WriteLine("City: " + City);
            Console.WriteLine("Phone no: " + phoneNo);
            Console.WriteLine("Email: " + email);
        }
    }
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Supplier objSupplier = new Supplier();

            objSupplier.AcceptDetails();
            objSupplier.DisplayDetails();

        }
    }
}
