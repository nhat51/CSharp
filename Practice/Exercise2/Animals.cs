using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Animals
    {
        string name;
        double weight;
        public void SetMe(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public virtual void Show()
        {
            Console.WriteLine("Name: {0},Weight: {1}", name, weight);
        }
    }
    class Lion : Animals
    {    
        public override void Show()
        {
            base.Show();
        }
    }
    class Tiger : Animals
    {
        public override void Show()
        {
            base.Show();
        }
    }
    class Result
    {
        static void Main(string[] agrs)
        {
            Lion objLion = new Lion();
            objLion.SetMe("Lion", 100);
            objLion.Show();
            Tiger obgTiger = new Tiger();
            obgTiger.SetMe("Tiger", 200);
            obgTiger.Show();
        }
    }
}
