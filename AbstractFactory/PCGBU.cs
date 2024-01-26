using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PCGBU:IGPU
    {
        public void Render()
        {
            Console.WriteLine("Render using PC GBU");
        }
    }
}
