using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    [TestFixture]
    class CircleTest
    {
        [Test]
        public void AreaTest()
        {
            //Arrange
            Circle c = new Circle();
            double Radius = 4.0;
            double expectedValue = 16 * Math.PI;
            //Act
            double actualValue = c.Area(Radius);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void PerimeterTest()
        {
            Circle c = new Circle();
            double Radius = 5.0;
            double expectedValue = 10 * Math.PI;
            double actualValue = c.Perimeter(Radius);
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
