using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MasterTestAdd()
        {
            MathFactory factory = new MathFactory();
            Assert.AreEqual(10, factory.GetMathOperation(MathOperationType.Multiply).PerformMathAction(2, 5));
            
        }

        [TestMethod]
        public void MasterTestMultiply()
        {
            MathFactory factory = new MathFactory();
           
            Assert.AreEqual(8, factory.GetMathOperation(MathOperationType.Add).PerformMathAction(2, 6));
        }


    }
}
