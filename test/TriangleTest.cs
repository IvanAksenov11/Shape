using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;

namespace ShapeTest
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TriangleTest()
        {
            Shape shape = new Triangle(5, 4, 3);
            Assert.AreEqual(6, shape.getSquare()); 
        }

        [TestMethod]
        public void IsTriangleRight()
        {
            Shape shape = new Triangle(5, 4, 3);
            Assert.AreEqual(true, ((Triangle)shape).IsRight());
        }

        [TestMethod]
        public void CircleTest()
        {
            Shape shape = new Circle(5);
            Assert.AreEqual(79, Math.Round(shape.getSquare()));
        }
    }
}
