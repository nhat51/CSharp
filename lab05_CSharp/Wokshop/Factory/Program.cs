using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            worker objWorker = new worker();
            if (objWorker.InputDetail())
            {
                objWorker.DisplayDetails();
            }
        }
    }
}
