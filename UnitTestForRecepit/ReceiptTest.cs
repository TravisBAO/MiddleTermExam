using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiddleTermExam;


namespace UnitTestForRecepit
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        public void Receipt_Greater_Than_Zero()
        {
            //test is an istance of the target class.
            Receipt purchase = new Receipt(1, 1, 1, 1.0M, 1);
            Assert.AreEqual(1, purchase.ReceiptNumber);
        }
    }
}
