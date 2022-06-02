using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Services;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Services.Tests
{
    [TestClass()]
    public class CircleServiceTests
    {
        [DataRow(5,78.5)]
        [TestMethod()]
        public void ComputeAreaTest(double r,double expected)
        {
            Circle circle = new Circle() { Radius = r };
            CircleService circleService = new CircleService() { Target=circle};
            Assert.AreEqual(expected, circleService.ComputeArea(), expected/1000);
        }

        [DataRow(5, 31.4)]
        [TestMethod()]
        public void ComputePerimeterTest(double r, double expected)
        {
            Circle circle = new Circle() { Radius = r };
            CircleService circleService = new CircleService() { Target = circle };
            Assert.AreEqual(expected, circleService.ComputePerimeter(), expected / 1000);
        }
    }
}