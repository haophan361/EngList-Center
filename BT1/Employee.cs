using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public abstract class Employee: IEmployee
    {
        public string Name { get; set; }
        protected Employee(string name) 
        {
            Name = name;
        }
        public abstract void Work();
    }
}
