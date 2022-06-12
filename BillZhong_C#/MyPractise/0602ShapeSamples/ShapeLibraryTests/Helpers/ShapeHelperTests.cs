using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Helpers;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Helpers.Tests
{
    [TestClass()]
    public class ShapeHelperTests
    {
        [TestMethod()]
        public void ComputeAreaTest(int w, int h, int expected)
        {
            Rectangle rectangle=new Rectangle { Width = w, Height = h };
            Assert.AreEqual(expected, ShapeHelper.ComputeArea(rectangle));
        }

        [TestMethod()]
        public void ComputeAreaTest1(double r, double expected)
        {
            Circle circle=new Circle() { Radius = r };
            Assert.AreEqual(expected, ShapeHelper.ComputeArea(circle));
        }

        [TestMethod()]
        public void ComputePerimeterTest(int w, int h, int expected)
        {
            Rectangle rectangle = new Rectangle { Width = w, Height = h };
            Assert.AreEqual(expected, ShapeHelper.ComputePerimeter(rectangle));
        }

        [TestMethod()]
        public void ComputePerimeterTest1(double r, double expected)
        {
            Assert.Fail();
        }
    }
}