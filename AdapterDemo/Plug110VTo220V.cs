using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class Plug110VTo220V :I220V
    {
        private readonly plug110V PLug110V;
        public Plug110VTo220V( plug110V PLug110V )
        {
            this.PLug110V = PLug110V;
        }
        public void Consume()
        {
            PLug110V.Consume110V();
        }
        public void use220V()
        {
            Console.WriteLine("Adapter converts 220V to 110V");
            PLug110V.Plug110V();
        }
    }
}
