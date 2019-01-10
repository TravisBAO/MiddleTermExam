using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiddleTermExam;


namespace UnitTestForRecepit
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        public void ReceiptNumber_Greater_Than_Zero()
        {
            //test is an istance of the target class.
            Receipt purchase = new Receipt(1, "20190110", 1, "Travis", "Bao", "13439974273", 1, 1.0M, 1);
            Assert.AreEqual(1, purchase.ReceiptNumber);
        }

    }

    [TestClass]
    public class UnitPriceTest
    {
        [TestMethod]
        public void UnitPrice_Greater_Than_Zero()
        {
            //test is an istance of the target class.
            Receipt purchase = new Receipt(1, "20190110", 1, "Travis", "Bao", "13439974273", 1, 25.0M, 1);
            Assert.AreEqual(25.0M, purchase.UnitPrice);
        }
    }
}
