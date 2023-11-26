using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    class DVD : Storage
    {
        private double readWriteSpeed;
        private bool isDoubleLayer;
        public DVD(string name, string model, double readWriteSpeed, bool isDoubleLayer)
        {
            Name = name;
            Model = model;
            this.readWriteSpeed = readWriteSpeed;
            this.isDoubleLayer = isDoubleLayer;
        }
        public override double GetMemory()
        {
            return isDoubleLayer ? 4.0 : 6.7;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Burn data to a DVD. Data Size: {dataSize} Gb");
        }

        public override void GetFreeSpaceInfo()
        {
            Console.WriteLine($"Free space on DVD storage: {GetMemory()} Gb");
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Information about DVD-disk: {Name}, {Model}, Read/write speed: {readWriteSpeed} Giga/sec");
        }
    }
}
