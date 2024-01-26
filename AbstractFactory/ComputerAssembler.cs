using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ComputerAssembler
    {
        private ICPU cpu;
        private IGPU gpu;
        public ComputerAssembler(IComputerFactory factory)
        {
            cpu=factory.CreateCPU();
            gpu=factory.CreateGPU();
        }
        public void AssembleComputer()
        {
            cpu.PerformOperation();
            gpu.Render();
        }
    }
}
