using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.CreationalPatterns.SingletonPattern
{
    public class Service
    {
        private static Service instance;

        public static Service Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Service();
                }

                return instance;
            }
        }


        public string Get()
        {
            return "Hello World";
        }

        // Zabezpieczenie
        protected Service()
        {

        }


    }
}
