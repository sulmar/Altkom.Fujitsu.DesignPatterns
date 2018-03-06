using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.CreationalPatterns.PrototypePattern
{
   
    public class Invoice : ICloneable
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreateDate { get; set; }

        public object Clone()
        {
            //Invoice copyInvoice = new Invoice
            //{
            //    Id = this.Id,
            //    Number = this.Number,
            //    Amount = this.Amount,
            //    CreateDate = this.CreateDate
            //};

            //return copyInvoice;

            return this.MemberwiseClone();
        }


    }
}
