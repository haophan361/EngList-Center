using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxList
{
    public class Employee:EventArgs
    {
        private int EmloyeeID;
        public Employee(int EmloyeeID) 
        {
            this.EmloyeeID = EmloyeeID;
        }
        public int EmployeeID
        { get { return this.EmloyeeID; } }

    }
}
