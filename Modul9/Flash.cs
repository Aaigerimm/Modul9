using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;
        public Flash(string name, string model, double usbSpeed, double memorySize)
        {
            Name = name;
            Model = model;
            this.usbSpeed = usbSpeed;
            this.memorySize = memorySize;
        }
        public override double GetMemory()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to Flash memory. Data Size: {dataSize} Gb");
        }

        public override void GetFreeSpaceInfo()
        {
            Console.WriteLine($"Free space on Flash memory: {GetMemory()} Gb");
        }
        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Information about Flash memory: {Name}, {Model}, Speed USB: {usbSpeed} Giga/sec");
        }

    }
}
