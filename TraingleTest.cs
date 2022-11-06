using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProject
{
    [TestFixture]

    class TraingleTest
    {
        [Test]
        public void AreaTest()
        {
            //Arrange
            Traingle c = new Traingle();
            double SideA= 4.0;
            double SideB = 2.0;
            double SideC = 5.0;
            double expectedValue = Math.Sqrt(231) / 4;
            //Act
            double actualValue = c.Area(SideA, SideB, SideC);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void PerimeterTest()
        {
            Traingle c = new Traingle();
            double SideA = 5.0;
            double SideB = 8.0;
            double SideC = 12.0;
            double expectedValue = 25.0;
            double actualValue = c.Perimeter(SideA, SideB, SideC);
            Assert.AreEqual(expectedValue, actualValue);

        }


    }

}
