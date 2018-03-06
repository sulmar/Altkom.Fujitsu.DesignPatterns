using System;
using Altkom.DesignPatterns.ConsoleClient.CreationalPatterns.FluentApiPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class FluentApiUnitTest
    {
        [TestMethod]
        public void FluentApiTest()
        {
            Mail.Create()
                .From("marcin.sulecki@altkom.pl")
                .To("marcin.sulecki@altkom.pl")
                .CC("marcin.sulecki@gmail.com")
                .CC("marcin.sulecki@gmail.com")
                .CC("marcin.sulecki@gmail.com")
                .Subject("Hello World")
                .Send();
        }
    }
}
