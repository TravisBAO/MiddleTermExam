using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestForRecepit
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        public void Receipt_Greater_Than_Zero()
        {
            Receipt purchase = new Receipt(1, 1, 1, 1.0M, 1);
            Assert.AreEqual(1, purchase.ReceiptNumber);
        }
    }
}
