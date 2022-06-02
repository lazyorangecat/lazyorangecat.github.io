using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary2.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [DynamicData (nameof(GetTestData),DynamicDataSourceType.Method)]
        [DataTestMethod()]
        public void ComputeTest(int w, int h, int expected)
        {
            Rectangle rectangle = new Rectangle()
            { Width = w, Height = h };
            
            var acyual = rectangle.Compute();
            Assert.AreEqual(expected, acyual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            {
                yield return new object[] { 6, 8, 48 };
                yield return new object[] { 3, 12, 36 };
                yield return new object[] { 15, 7, 105 };
            }
        }
    }
}