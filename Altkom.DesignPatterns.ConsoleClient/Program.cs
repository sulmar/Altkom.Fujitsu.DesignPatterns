using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientTest();
        }

        static void ClientTest()
        {
            Service service1 = new Service();
            Console.WriteLine(service1.Get());

            if (service1==null)
            {
                service1 = new Service();
            }

            Console.WriteLine(service1.Get());


        }
    }
}
