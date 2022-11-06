using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void AreaTest()
        {
            //Arrange
            Rectangle c = new Rectangle();
            double Height = 4.0;
            double Width = 5.0;
            double expectedValue = 20.0;
            //Act
            double actualValue = c.Area(Height, Width);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void PerimeterTest()
        {
            Rectangle c = new Rectangle();
            double Height = 5.0;
            double Width = 4.0;
            double expectedValue = 18.0;
            double actualValue = c.Perimeter(Height, Width);
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
