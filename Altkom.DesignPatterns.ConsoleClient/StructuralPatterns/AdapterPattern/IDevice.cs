using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.DesignPatterns.ConsoleClient.StructuralPatterns.AdapterPattern
{
    public interface IDevice
    {
        void Start();
        void Stop();

        bool IsRunning { get; }
    }

    public class DeviceAdapter : IDevice
    {
        private Device device;

        public DeviceAdapter()
        {
            device = new Device();
        }

        public bool IsRunning => device.isActive;

        public void Start()
        {
            device.Init();
            device.Run();
        }

        public void Stop()
        {
            device.Stop();
            device.Release();
        }
    }

}
