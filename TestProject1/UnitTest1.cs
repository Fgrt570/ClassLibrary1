using NUnit.Framework;
using ClassLibrary1;
namespace TestProject1
{
    
    [TestFixture]
    public class ShapeAreaCalculatortest
    { 
        private ShapeAreaCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new ShapeAreaCalculator(); // Создаем новый экземпляр класса перед каждым тестом
        }

        [Test]
        public void CalculateRectangleArea_ValidInput_ReturnsCorrectArea()
        {
            double width = 5;
            double height = 10;
            double area = _calculator.CalculateRectangleArea(width, height);
            Assert.AreEqual(50, area); // Проверяем, что площадь равна 50
        }

        [Test]
        public void CalculateCircleArea_ValidInput_ReturnsCorrectArea()
        {
            double radius = 7;
            double area = _calculator.CalculateCircleArea(radius);
            Assert.AreEqual(Math.PI * 7 * 7, area, 0.0001); // Проверяем площадь круга
        }

        [Test]
        public void CalculateTriangleArea_ValidInput_ReturnsCorrectArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double area = _calculator.CalculateTriangleArea(a, b, c);
            Assert.AreEqual(6, area, 0.0001); // Проверяем площадь треугольника
        }

        
       
    }
}
