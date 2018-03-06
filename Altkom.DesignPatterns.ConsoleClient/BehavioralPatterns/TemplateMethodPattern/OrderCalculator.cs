using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns.TemplateMethodPattern
{
    public class LimitOrderCalculator : OrderCalculator
    {
        private readonly decimal limit;
        private readonly float percentage;

        public LimitOrderCalculator(decimal limit, float percentage)
        {
            this.limit = limit;
            this.percentage = percentage;
        }

        public override bool CanDiscount(Order order) => order.Amount > limit;

        public override decimal Discount(Order order) => order.Amount * (decimal) percentage;
    }

    public abstract class OrderCalculator
    {
        public abstract bool CanDiscount(Order order);

        public abstract decimal Discount(Order order);

        public decimal Calculate(Order order)
        {
            if (CanDiscount(order))
            {
                return order.Amount - Discount(order);
            }
            else
            {
                return order.Amount;
            }
        }
    }
}
