using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns.StrategyPattern
{
    public interface IStrategy
    {
        bool CanDiscount(Order order);

        decimal Discount(Order order);
    }


    public class NoDiscountStrategy : IStrategy
    {
        public bool CanDiscount(Order order) => false;

        public decimal Discount(Order order) => throw new NotSupportedException();
    }

    public abstract class PercentageDiscount
    {
        protected readonly decimal percentage;

        public virtual decimal Discount(Order order) => order.Amount * percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }

    }

    public class LimitDiscountStrategy : PercentageDiscount, IStrategy
    {
        private readonly int limit;

        public LimitDiscountStrategy(int limit, decimal percentage)
            : base(percentage)
        { 
            this.limit = limit;
        }

        public bool CanDiscount(Order order) => order.Amount > limit;

    }

    public class HappyHourDiscountStrategy : IStrategy
    {
        private readonly decimal percentage;
        private readonly TimeSpan beginHour;
        private readonly TimeSpan endHour;

        public HappyHourDiscountStrategy(
            TimeSpan beginHour,
            TimeSpan endHour,
            decimal percentage)
        {
            this.beginHour = beginHour;
            this.endHour = endHour;
            this.percentage = percentage;
        }


        public bool CanDiscount(Order order)
        {
            return order.OrderDate.TimeOfDay > beginHour
                && order.OrderDate.TimeOfDay < endHour;
        }


        public decimal Discount(Order order) => order.Amount * percentage;
    }

    public class OrderCalculator
    {
        private IStrategy strategy;

        public OrderCalculator(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        
        public decimal Calculate(Order order)
        {
            #region 

            if (order==null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            if (order.Quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(order.Quantity));
            }


            #endregion

            if (strategy.CanDiscount(order))
            {
                return order.Amount - strategy.Discount(order);
            }
            else
            {
                return order.Amount;
            }

        }
    }
}
