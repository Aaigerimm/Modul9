using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    class HDD : Storage
    {
        private double usbSpeed;
        private int partitionCount;
        private double partitionSize;
        public HDD(string name, string model, double usbSpeed, int partitionCount, double partitionSize)
        {
            Name = name;
            Model = model;
            this.usbSpeed = usbSpeed;
            this.partitionCount = partitionCount;
            this.partitionSize = partitionSize;
        }
        public override double GetMemory()
        {
            return partitionCount * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Transferring data to a removable HDD. Data Size: {dataSize} Gb");
        }

        public override void GetFreeSpaceInfo()
        {
            Console.WriteLine($"Free space on removable HDD: {GetMemory()} Gb");
        }
        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Information about removable HDD: {Name}, {Model}, speed USB: {usbSpeed} Giga/sec, Number of sections: {partitionCount}");
        }
    }
}
