using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Modul9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[]
            {
            new Flash("FlDr", "Model009", 5.0, 88),
            new DVD("DVD-SH", "LiteOn", 5.0, true),
            new HDD("ExHDD", "Seagate", 4.0, 4, 800)
                };
            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
            }
            double dataSize = 565;
            foreach (var device in devices)
            {
                device.CopyData(dataSize);
            }
            Console.WriteLine($"Total memory: {totalMemory} Gb");
            double copySpeed = 5;
            double copyTime = dataSize / copySpeed;
            Console.WriteLine($"Time, to copy elements: {copyTime} sec");
            double totalDataSize = dataSize;
            foreach (var device in devices)
            {
                double deviceMemory = device.GetMemory();
                double devicesNeeded = Math.Ceiling(totalDataSize / deviceMemory);
                Console.WriteLine($"To transfer data, you will need {devicesNeeded} type device {device.GetType().Name}");
                Console.ReadKey();
            }
        }
    }
}
