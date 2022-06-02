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
        [DataRow(2,4,8)]
        [DataTestMethod()]
        public void ComputeAreaTest(double w,double h,double expected)
        {
            Rectangle input = new Rectangle()
            {
                Width = w,
                Height = h,
            };
            var actual =  input.ComputeArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ComputeAreaTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ComputePerimeterTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ComputePerimeterTest1()
        {
            Assert.Fail();
        }


    }
}