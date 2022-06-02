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
    public class RectangleServiceTests
    {
        [DynamicData(nameof(GetTestDataArea), DynamicDataSourceType.Method)]
        
        [DataTestMethod()]
        public void ComputeAreaTest(int w, int h, int expected)
        {
            Rectangle rectangle = new Rectangle()
            { Width=w,Height=h };
            RectangleService rectangleService = new RectangleService() { Target = rectangle };

            var acyual = rectangleService.ComputeArea();
            Assert.AreEqual(expected, acyual);
        }

        [DynamicData(nameof(GetTestDataPerimeter),DynamicDataSourceType.Method)]
        [DataTestMethod()]
        public void ComputePerimeterTest(int w, int h, int expected)
        {
            Rectangle rectangle = new Rectangle()
            { Width = w, Height = h };
            RectangleService rectangleService = new RectangleService() { Target = rectangle };

            var acyual = rectangleService.ComputePerimeter();
            Assert.AreEqual(expected, acyual);
        }

        private static IEnumerable<object[]> GetTestDataArea()
        {
            {
                yield return new object[] { 6, 8, 48 };
                yield return new object[] { 3, 12, 36 };
                yield return new object[] { 15, 7, 105 };
            }
        }

        private static IEnumerable<object[]> GetTestDataPerimeter()
        {
            {
                yield return new object[] { 6, 8, 28 };
                yield return new object[] { 3, 12, 30 };
                yield return new object[] { 15, 7, 44 };
            }
        }


    }
}