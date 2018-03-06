using System;
using Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns.CommandPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class CommandUnitTest
    {
        [TestMethod]
        public void CommandTest()
        {
            Mail mail = new Mail
            {
                From = "marcin.sulecki@altkom.pl",
                To = "marcin.sulecki@altkom.pl"
            };

            ICommand command = new SendCommand(mail);

            Assert.IsTrue(command.CanExecute());

            command.Execute();
        }

        [TestMethod]
        public void CommandNotSendTest()
        {
            Mail mail = new Mail
            {
                From = "marcin.sulecki@altkom.pl",         
            };

            ICommand command = new SendCommand(mail);

            Assert.IsFalse(command.CanExecute());

            command.Execute();
        }
    }
}
