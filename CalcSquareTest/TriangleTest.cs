using NUnit.Framework;
using CalculateSquare;
using System;

namespace CalcSquareTest
{
    public class TriangleTest
    {
        [Test]
        public void TriangleSquareTest()
        {
            // Arrange
            double result;
            Triangle triangle = new Triangle(2, 1, 2);
            // Act
            result = triangle.Square();
            // Assert
            Assert.AreEqual(0.9682458365518543, result);
        }
        [Test]
        public void TriangleABSTest()
        {
            // Arrange
            double result;
            Triangle triangle = new Triangle(-3, -4, -5);
            // Act
            result = triangle.Square();
            // Assert
            Assert.AreEqual(6, result);
        }
        [Test]
        public void NotTriangleTest()
        {
            try
            {
                new Triangle(0, 4, 5);
                Assert.Fail("Exception");
            }
            catch (ArgumentException)
            {

            }
        }
        [Test]
        public void IsRectangularCorrectTest()
        {
            // Arrange
            bool result;
            Triangle triangle = new Triangle(3, 4, 5);
            // Act
            result = triangle.IsRectangular();
            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void IsRectangularWrongTest()
        {
            // Arrange
            bool result;
            Triangle triangle = new Triangle(2, 4, 5);
            // Act
            result = triangle.IsRectangular();
            // Assert
            Assert.IsFalse(result);
        }
    }
}
