using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class TuongOt : ISauce
    {
        public void getTaste()
        {
            Console.WriteLine("Co vi cay cay");
        }
    }
}
