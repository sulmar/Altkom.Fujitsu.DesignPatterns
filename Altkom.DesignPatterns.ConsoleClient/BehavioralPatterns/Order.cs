using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.BehavioralPatterns
{
    public abstract class Base
    {

    }

    public class Order : Base
    {
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Amount => Quantity * Price;


    }
}
