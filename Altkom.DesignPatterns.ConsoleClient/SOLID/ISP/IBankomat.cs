using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.SOLID.ISP
{
    interface IBankomat
    {
        void Wyplac(decimal amount);
        decimal Saldo();
        void Wplac(decimal amount);
    }


    interface IWplatomat 
    {
        void Wplac(decimal amount);
    }

    interface IWyplatomat
    {
        void Wyplac(decimal amount);
    }

    interface ISaldomat
    {
        decimal Saldo();
    }

    class SecondBankomat : IWyplatomat, IWplatomat
    {
        private decimal saldo;

        public void Wplac(decimal amount)
        {
            saldo = +amount;
        }

        public void Wyplac(decimal amount)
        {
            saldo = -amount;
        }
    }




    class MyBankomat : IBankomat
    {
        private decimal saldo;

        public decimal Saldo()
        {
            return saldo;
        }

        public void Wplac(decimal amount)
        {
            throw new NotSupportedException();
        }

        public void Wyplac(decimal amount)
        {
            saldo = saldo - amount;
        }
    }


}
