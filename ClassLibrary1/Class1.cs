using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ShapeAreaCalculator
    {
        public double CalculateRectangleArea(double width, double height)
        {
            return width * height; // Площадь прямоугольника
        }

        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius; // Площадь круга
        }

        public double CalculateTriangleArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2; // Полупериметр
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); // Формула Герона
        }
    }
}
