using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.StructuralPatterns.FacadePattern
{
    // Facade
    public interface IWashMachine
    {
        void Start();

        void Stop();
    }

    public interface IEngine
    {
        void Start();
        void Stop();
    }

    public interface IPump
    {
        void Start();
        void Stop();
    }

    public interface IHeater
    {
        void SetTemperature(float temp);
    }

    public class MyHeater : IHeater
    {
        private float temp;

        public void SetTemperature(float temp)
        {
            this.temp = temp;
        }
    }

    public class MyPump : IPump
    {
        private bool isActive;

        public void Start()
        {
            isActive = true;
        }

        public void Stop()
        {
            isActive = false;
        }
    }


    public class MyEngine : IEngine
    {
        private bool isRunning;

        public void Start()
        {
            isRunning = true;
        }

        public void Stop()
        {
            isRunning = false;
        }
    }

    public class MyWashMachine : IWashMachine
    {
        private IEngine engine;
        private IPump pump;
        private IHeater heater;

        public MyWashMachine(
            IEngine engine, 
            IPump pump, 
            IHeater heater)
        {
            this.engine = engine;
            this.pump = pump;
            this.heater = heater;
        }

        public void Start()
        {
            pump.Start();

            Thread.Sleep(TimeSpan.FromSeconds(2));

            heater.SetTemperature(40);

            engine.Start();

            Thread.Sleep(TimeSpan.FromSeconds(20));

            heater.SetTemperature(20);
            engine.Stop();
            pump.Stop();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
