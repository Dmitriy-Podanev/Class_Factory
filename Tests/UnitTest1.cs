using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MasterTest()
        {
            MathFactory factory = new MathFactory();
            Assert.AreEqual(10, factory.GetMathOperation(MathOperationType.Multiply).PerformMathAction(2, 5));
            Assert.AreEqual(8, factory.GetMathOperation(MathOperationType.Add).PerformMathAction(2, 6));
        }
    }
}
