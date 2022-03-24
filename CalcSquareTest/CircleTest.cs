using NUnit.Framework;
using CalculateSquare;

namespace CalcSquareTest
{
    public class CircleTest
    {
        [Test]
        public void CircleSquareTest()
        {
            // Arrange
            double result;
            Circle circle = new Circle(3);
            // Act
            result = circle.Square();
            // Assert
            Assert.AreEqual(28.274333882308138, result);
        }
        [Test]
        public void CircleABSTest()
        {
            // Arrange
            double result;
            Circle circle = new Circle(-3);
            // Act
            result = circle.Square();
            // Assert
            Assert.AreEqual(28.274333882308138, result);
        }
        [Test]
        public void CircleZeroSquareTest()
        {
            // Arrange
            double result;
            Circle circle = new Circle(0);
            // Act
            result = circle.Square();
            // Assert
            Assert.AreEqual(0, result);
        }
    }
}