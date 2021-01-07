using System;
using System.Collections.Generic;
using System.Text;

namespace Company2
{
    class ProductTest
    {
        static void Main(string[] agrs)
        {
            Product objProduct = new Product();
            Console.Write("Enter the customer name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the invoice number: ");
            int value = Convert.ToInt32(Console.ReadLine());

            objProduct.SetDetails(value, name);
            objProduct.SetDetails();
            objProduct.Display();
        }
    }
}
