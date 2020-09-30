using System;
using System.Threading;

namespace _2_6_studio
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputRadius;
            double circleArea;

            Console.WriteLine("Please enter circle radius:");
            inputRadius = Convert.ToDouble(Console.ReadLine());
            circleArea = (Math.Pow(inputRadius, 2)) * Math.PI;
            Console.WriteLine("Area:" + circleArea);


            double circleCircumference;
            double circleDiameter;
            circleCircumference = (2 * Math.PI * inputRadius);
            circleDiameter = (2 * inputRadius);
            Console.WriteLine("Circumference: " + circleCircumference);
            Console.WriteLine("Diameter: " + circleDiameter);

            double inputMPG;
            double totalGallons;
            Console.WriteLine("Miles per Gallon?");
            inputMPG = Convert.ToDouble(Console.ReadLine());
            totalGallons = circleCircumference / inputMPG;
            Console.WriteLine("Total gallons used:" + totalGallons);
        }
    }
}
