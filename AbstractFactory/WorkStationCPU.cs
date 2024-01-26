using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WorkStationCPU:ICPU
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing complex operation using Workstation CPU");
        }
    }
}
