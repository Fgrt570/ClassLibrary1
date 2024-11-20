using TestProject1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeAreaCalculator calculator = new ShapeAreaCalculator();
            double area = calculator.CalculateRectangleArea(5, 10);
            Console.WriteLine($"Area of rectangle: {area}"); // Должно вывести: Area of rectangle: 
        }
    }
}
