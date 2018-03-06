using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.StructuralPatterns.AdapterPattern
{
    public class Device
    {
        public bool isActive;

        public void Init()
        {
            isActive = true;
        }

        public void Run()
        {
            if (isActive)
            {
                Console.WriteLine("Running...");
            }
        }

        public void Stop()
        {
            if (isActive)
            {
                isActive = false;
            }
        }

        public void Release()
        {
            isActive = false;
        }


    }
}
