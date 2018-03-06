using System;
using Altkom.DesignPatterns.ConsoleClient.CreationalPatterns.PrototypePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class PrototypUnitTest
    {
        [TestMethod]
        public void PrototypTest()
        {
            Invoice invoice = new Invoice
            {
                Id = 1,
                Number = "FV 001/2018",
                Amount = 100,
                CreateDate = DateTime.Now
            };

            Invoice copyInvoice = (Invoice) invoice.Clone();

            Invoice copy = (Invoice) invoice.Clone();

            Assert.AreNotSame(invoice, copyInvoice);

            
        }
    }
}
