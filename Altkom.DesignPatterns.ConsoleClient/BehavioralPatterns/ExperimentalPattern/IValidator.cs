using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns.ExperimenalPattern
{
    public interface IDiscountValidator
    {
        bool CanDiscount(Order order);
    }

    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(Order order);
    }

    public class PercentageDiscountCalculator : IDiscountCalculator
    {
        private readonly float percentage;

        public PercentageDiscountCalculator(float percentange)
        {
            this.percentage = percentange;
        }

        public decimal CalculateDiscount(Order order)
        {
            return order.Amount * (decimal) percentage;
        }
    }

    public class FixedDiscountCalculator : IDiscountCalculator
    {
        private readonly decimal discountAmount;

        public FixedDiscountCalculator(decimal discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public decimal CalculateDiscount(Order order)
        {
            return discountAmount;
        }
    }

    public class HappyHourDiscountValidator : IDiscountValidator
    {
        private readonly TimeSpan beginTime;
        private readonly TimeSpan endTime;

        public HappyHourDiscountValidator(TimeSpan beginTime, TimeSpan endTime)
        {
            this.beginTime = beginTime;
            this.endTime = endTime;
        }

        public bool CanDiscount(Order order)
        {
            return order.OrderDate.TimeOfDay >= beginTime 
                && order.OrderDate.TimeOfDay <= endTime;
        }
    }

    public class OrderCalculator
    {
        private readonly IDiscountValidator discountValidatorStrategy;
        private readonly IDiscountCalculator discountCalculatorStrategy;

        public OrderCalculator(IDiscountValidator validator, IDiscountCalculator calculator)
        {
            this.discountValidatorStrategy = validator;
            this.discountCalculatorStrategy = calculator;
        }


        public decimal Calculate(Order order)
        {
            #region 

            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            if (order.Quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(order.Quantity));
            }


            #endregion

            if (discountValidatorStrategy.CanDiscount(order))
            {
                return order.Amount - discountCalculatorStrategy.CalculateDiscount(order);
            }
            else
            {
                return order.Amount;
            }

        }
    }
}
