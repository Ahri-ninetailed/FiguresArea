using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresArea; 
namespace FiguresAreaTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void AreaAtRadius1()
        {
            Assert.AreEqual(3.141592653589793, new Circle(1).Area());
        }
        [TestMethod]
        public void AreaAtRadius1dot5()
        {
            Assert.AreEqual(7.0685834705770345, new Circle(1.5).Area());
        }
        [TestMethod]
        public void AreaAtRadius0()
        {
            Assert.AreEqual(0, new Circle(0).Area());
        }
        [TestMethod]
        public void AreaAtRadius200()
        {
            Assert.AreEqual(125663.70614359173, new Circle(200).Area());
        }
    }
}
