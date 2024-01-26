using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class ConsumeElectric
    {
        public void consumeElectric(I220V plug)
        {
            plug.use220V();
            plug.Consume();
            Console.WriteLine("Electric is consumed");
        }
    }
}
