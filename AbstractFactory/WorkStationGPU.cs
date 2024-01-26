using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WorkStationGPU:IGPU
    {
        public void Render()
        {
            Console.WriteLine("Rendering high - quaility graphics using Workstation GPU");
        }
    }
}
