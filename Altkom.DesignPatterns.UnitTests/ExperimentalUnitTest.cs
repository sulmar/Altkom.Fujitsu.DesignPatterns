using System;
using System.Collections.Generic;
using Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns;
using Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns.ExperimenalPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Altkom.DesignPatterns.UnitTests
{
    [TestClass]
    public class ExperimentalUnitTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            // Arrange
            var order = new Order
            {
                Price = 100,
                Quantity = 2,
                OrderDate = DateTime.Parse("2018-03-06 14:00")
            };

            

            // Act
            IDiscountValidator validator = new HappyHourDiscountValidator(TimeSpan.FromHours(13), TimeSpan.FromHours(16));
            IDiscountCalculator calculator = new FixedDiscountCalculator(20);

            var orderCalculator = new OrderCalculator(validator, calculator);

            var amount = orderCalculator.Calculate(order);

            // Assert
            Assert.AreEqual(180, amount);
        }

        [TestMethod]
        public void CustomerTest()
        {
            // Arrange
            var order = new Order
            {
                Price = 100,
                Quantity = 2,
                OrderDate = DateTime.Parse("2018-03-06 14:00")
            };


            if (order.Customer != null)
            {
                Console.WriteLine(order.Customer.Name);
            }

            Console.WriteLine(order.Customer?.Name);
        }
    }
}
