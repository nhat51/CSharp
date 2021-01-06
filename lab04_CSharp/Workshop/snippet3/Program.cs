using System;

namespace snippet3
{
    class Product
    {
        private int productID;
        private string productName;
        private float price;
        private int stock;

        public Product()
        {
            productID = 101;
            productName = "Refirigerator";
            price = 420.5f;
            stock = 30;
        }
        public Product(int id)
        {
            productID = id;
            productName = "Washing machine";
            price = 677.3f;
            stock = 25;
        }
        public Product(int id, string name, float price, int stock)
        {
            productID = id;
            productName = name;
            price = price;
            stock = stock;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Product Details");
            Console.WriteLine("Product ID: " + productID);
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Price: " + price + "$");
            Console.WriteLine("Quantity in stock: " + stock);
        }
    }
    class ProductTest
    {
        static void Main(string[] args)
        {
            Product objProduct = new Product();

            objProduct.DisplayDetails();
            Console.WriteLine();

            Product objProduct2 = new Product(103, "Television", 5660.45f, 68);

            objProduct2.DisplayDetails();
        }
    }
}
