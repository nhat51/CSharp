using System;

namespace Practice
{
    class Cylinder
    {

        double Height;
        double Radius;
        double BaseArea;
        double LateralArea;
        double TotalArea;
        double Volume;
        public void Process()
        {
            Console.WriteLine("Enter the dimensions of the cylinder");
            Console.Write("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Base: {0} || Lateral: {1} || Total: {2} || Volume: {3}",BaseArea, LateralArea,TotalArea,Volume );
        }

        static void Main(string[] args)
        {
            Cylinder objCylinder = new Cylinder();
            objCylinder.Process();
            objCylinder.Result();
        }
    }
}
