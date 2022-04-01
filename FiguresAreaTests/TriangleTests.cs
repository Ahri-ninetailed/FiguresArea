using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresArea;
using System;
namespace FiguresAreaTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Сторона треугольника не может быть равной 0")]
        public void AreaAtSide0()
        {
            new Triangle(0, 1, 2).Area();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Треугольник существует только тогда, когда сумма двух его сторон больше третьей")]
        public void AreaOfANonexistentTriangle()
        {
            new Triangle(2, 2, 5).Area();
        }

        [TestMethod]
        public void AreaAtSide4_2_5()
        {
            Assert.AreEqual(3.8, new Triangle(4, 2, 5).Area());
        }

        [TestMethod]
        public void AreaAtSide10dot6_10dot3_10dot9()
        {
            Assert.AreEqual(48.575, new Triangle(10.6, 10.3, 10.9).Area());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Сторона треугольника не может быть отрицательной")]
        public void AreaAtSideIsNegative()
        {
            new Triangle(-1, 2, 3).Area();
        }
    }
}
