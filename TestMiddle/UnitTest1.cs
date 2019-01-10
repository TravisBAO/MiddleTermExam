using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMiddle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
   
            
                //test is an istance of the target class.
                Receipt purchase = new Receipt(1, 1, 1, 1.0M, 1);
                Assert.AreEqual(1, purchase.ReceiptNumber);
            
        }
    }
}
