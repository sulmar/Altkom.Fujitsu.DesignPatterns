using System;
using Altkom.DesignPatterns.ConsoleClient.StructuralPatterns.FacadePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class FacadeUnitTest
    {
        [TestMethod]
        public void FacadeTest()
        {
            IWashMachine machine = new MyWashMachine(
                    new MyEngine(), 
                    new MyPump(), 
                    new MyHeater());

            machine.Start();
        
        }
    }
}
