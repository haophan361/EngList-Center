using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class Intern:Employee
    {
        public Intern(string name) : base(name) { }
        public override void Work()
        {
            Console.WriteLine(Name + " is learning and assisting");
        }
    }
}
