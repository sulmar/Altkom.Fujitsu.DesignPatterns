using System;
using Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns;
using Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns.StrategyPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class StrategyUnitTest
    {
        [TestMethod]
        public void CalculateOrderDiscountTest()
        {
            // Arrange
            var order = new Order
            {
                Price = 100,
                Quantity = 2,
                OrderDate = DateTime.Parse("2018-03-06")
            };

            // Act
            var orderCalculator = new OrderCalculator(new LimitDiscountStrategy(100, 0.1m));

            var amount = orderCalculator.Calculate(order);

            // Assert
            Assert.AreEqual(180, amount);
        }

        [TestMethod]
        public void CalculateOrderTest()
        {
            // Arrange
            var order = new Order
            {
                Price = 40,
                Quantity = 2,
                OrderDate = DateTime.Parse("2018-03-06")
            };

            // Act
            var orderCalculator = new OrderCalculator(new NoDiscountStrategy());

            var amount = orderCalculator.Calculate(order);

            // Assert
            Assert.AreEqual(80, amount);

        }
    }
}
