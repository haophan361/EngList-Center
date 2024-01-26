using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class Manager :Employee,IManager
    {
        private List<IEmployee> subordinates;
        public Manager(string name):base (name)
        {
            subordinates = new List<IEmployee>();
        }
        public override void Work()
        {
            Console.WriteLine(Name + " is strategizing");
        }
        public void Manage()
        {
            Console.WriteLine(Name + " is managing Emloyees");
            foreach(var emloyee in subordinates)
            {
                emloyee.Work();
            }
        }
        public void addSubordinate(IEmployee emloyee)
        {
            subordinates.Add(emloyee);
        }
    }
}
