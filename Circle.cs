using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Circle
    {
        public const double PI = Math.PI;

        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateDiameter(double radius)
        {
            Console.WriteLine($"The diameter of the circle is {Math.Round(2 * radius, 3)}...");
            return Radius;
        }

        public double CalculateCircumference(double radius)
        {
            Console.WriteLine($"The circumference of the circle is {Math.Round(2 * PI * radius, 3)}...");
            return Radius;
        }

        public double CalculateArea(double radius)
        {
            Console.WriteLine($"The area of the circle is {Math.Round(Math.Pow(radius, 2) * PI, 3)}...");
            return Radius;
        }

        public void Grow()
        {
            Radius *= 2;
            CalculateDiameter(Radius);
            CalculateCircumference(Radius);
            CalculateArea(Radius);
        }

        public double GetRadius(double radius)
        {
            Radius = radius;
            return radius;
        }
    }
}
