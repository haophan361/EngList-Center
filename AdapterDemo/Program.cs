using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            plug110V device=new plug110V();
            I220V adapter=new Plug110VTo220V(device);
            ConsumeElectric consume=new ConsumeElectric();
            consume.consumeElectric(adapter);

        }
    }
}