using System;
using MathOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_MathOperations
{
    [TestClass]
    public class UnitTest1
    {
        BasicOp op = new BasicOp();
        [TestMethod]
        public void Test_AdditionMethod()
        {
            double result = op.Addition(10, 10);
            Assert.AreEqual(result, 20);
        }

        [TestMethod]
        public void Test_MultiplicationMethod()
        {
            double result = op.Multiplication(10, 10);
            Assert.AreEqual(result, 100);
        }

        [TestMethod]
        public void Test_SubtractionMethod()
        {
            double result = op.Subtraction(10, 10);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Test_DivisionMethod()
        {
            double result = op.Division(10, 10);
            Assert.AreEqual(result, 1);
        }
    }
}
