using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PCCPU:ICPU
    {
        public void PerformOperation()
        {
            Console.WriteLine("Performing operation using PC CPU");
        }
    }
}
