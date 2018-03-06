using System;
using Altkom.DesignPatterns.ConsoleClient.StructuralPatterns.DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class DecoratorUnitTest
    {
        [TestMethod]
        public void DecoratorTest()
        {
            IWidget widget = new BorderDecorator(
                                new BorderDecorator(
                                    new Button(200, 70)));

            widget.Draw();
        }
    }
}
