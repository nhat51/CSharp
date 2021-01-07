using System;

namespace Company2
{
    class Invoice
    {
        private int invoiceNumber;
        private string customerName;
        private DateTime invoiceDate;

        public virtual void SetDetails()
        {
            invoiceDate = DateTime.Now;
        }
        public void SetDetails(int number,string name)
        {
            invoiceNumber = number;
            customerName = name;
        }
        public virtual void Display()
        {
            Console.WriteLine("\nINVOICE DETAILS");
            Console.WriteLine("\nInvoice No: " + invoiceNumber);
            Console.WriteLine("Invoice Date: " + invoiceDate.ToShortDateString());

        }
    }
}
