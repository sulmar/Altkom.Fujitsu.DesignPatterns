using System;
using Altkom.DesignPatterns.ConsoleClient.StructuralPatterns.AdapterPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class AdapterUnitTest
    {
        [TestMethod]
        public void AdapterTest()
        {
            IDevice device = new DeviceAdapter();
            device.Start();

            Assert.IsTrue(device.IsRunning);

            device.Stop();
            Assert.IsFalse(device.IsRunning);

        }
    }
}
