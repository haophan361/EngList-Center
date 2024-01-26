using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class Developer:Employee
    {
        public Developer(string name) : base(name) { }
        public override void Work()
        {
            Console.WriteLine(Name + " is Writing code");
        }
    }
}
