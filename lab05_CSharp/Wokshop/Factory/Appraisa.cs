using System;

namespace Factory
{
    public sealed class Appraisa
    {
        private double bonus;
        public double CaculateBonus(string designation, int tenure, double salary)
        {
            if(designation == "Manager")
            {
                if(tenure <= 5)
                {
                    bonus = salary * 1.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if(designation == "Engineer")
            {
                if(tenure <= 5)
                {
                    bonus = salary;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if (designation == "technician")
            {
                if (tenure <= 3)
                {
                    bonus = salary * 0.25;
                }

                else if (tenure > 3 && tenure <= 5)
                {
                    bonus = salary * 0.5;

                }
            }
            else
            {
                bonus = salary * 2;
            }
            return bonus;
        }
    }
}
