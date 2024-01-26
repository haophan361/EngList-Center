using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class NuocMam : ISauce
    {
        public void getTaste()
        {
            Console.WriteLine("Co vi man man");
        }
    }
}
