using System;
using Altkom.DesignPatterns.ConsoleClient.CreationalPatterns.SingletonPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class SingletonUnitTest
    {
        [TestMethod]
        public void SingletonTest()
        {
            Service service1 = Service.Instance;

            Service service2 = Service.Instance;

            Assert.AreSame(service1, service2);
        }

        [TestMethod]
        public void GenericSingletonTest()
        {
            Context instance1 = Singleton<Context>.Instance;

            Context instance2 = Singleton<Context>.Instance;

            Assert.AreSame(instance1, instance2);

        }
    }
}
