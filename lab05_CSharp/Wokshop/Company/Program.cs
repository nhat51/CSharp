using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Revenue objRevenue = new Revenue();
            Expenditure objExpenditure = new Expenditure();

            objExpenditure.AcceptDetails();
            objExpenditure.DisplayDetails();
            objRevenue.AcceptDetails();
            objRevenue.DisplayDetails();
        }
    }
}
