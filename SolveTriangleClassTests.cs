using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolveTriangleLibraryTests
{
    [TestClass]
    public class SolveTriangleClassTests
    {
        [TestMethod]
        public void SolveTriangleArea_3and4and5_6returned()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //act
            SolveTriangleLibrary.SolveTriangleClass Triangle = new SolveTriangleLibrary.SolveTriangleClass();
            double actual = Triangle.SolveTriangleArea(a, b, c);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
