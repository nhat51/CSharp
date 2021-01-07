using System;
using System.Collections.Generic;
using System.Text;

namespace Company2
{
    class Product : Invoice
    {
        private string productName;
        private int quantity;
        private double price;
        private double totalValue;

        public override void SetDetails()
        {
            base.SetDetails();
            Console.Write("Enter the product Name:");
            productName = Console.ReadLine();
        Sale:
            Console.Write("Enter the quantity sold: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            if(quantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative");
                goto Sale;
            
            }
        price:
            Console.Write("Enter the price per unit: ");
            price = Convert.ToDouble(Console.ReadLine());
            if(price < 0)
            {
                Console.WriteLine("Price cannot be negative");
                goto price;
            }
            totalValue = quantity * price;
            
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\nPRODUCT DETAILS");
            Console.WriteLine("\nProduct: " + productName);
            Console.WriteLine("Quantity Sold: " + quantity);
            Console.WriteLine("Price per unit: " + price);
            Console.WriteLine("Total amount: " + totalValue);
        }
    }
}
