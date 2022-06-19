using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary.Tests
{
    [TestClass()]
    public class RectangleOperationTests
    {
        [DataRow(8,9,72)]
        [DataRow(5,6,30)]

        [DataTestMethod()]
        public void ComputeAreaTest(int w,int h,int expected)

        {
            Rectangle rectangle = new Rectangle()
            { Width = w, Height = h };
            var opepration=new RectangleOperation()
            { Target = rectangle };
            var acyual=opepration.ComputeArea();
            Assert.AreEqual(expected, acyual);
        }

        [DynamicData(nameof(GetTestData),DynamicDataSourceType.Method)]
        [DataTestMethod()]
        public void ComputeAreaByDataSourse(int w, int h, int expected)
        {
            Rectangle rectangle = new Rectangle()
            { Width = w, Height = h };
            var opepration = new RectangleOperation()
            { Target = rectangle };
            var acyual = opepration.ComputeArea();
            Assert.AreEqual(expected, acyual);
        }

        private static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { 6, 8, 48 };
            yield return new object[] { 3,12, 36 };
            yield return new object[] { 15, 7, 105 };

        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod()]
        public void Given_Rectangle_null_When_ComputeArea_Then_NullReferenceException()
        {
            Rectangle input = null;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputeArea();
        }
    }
}