using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class Company
    {
        private List<IEmployee> emloyees;
        public Company()
        {
            emloyees = new List<IEmployee>();
        }
        public void addEmployee(IEmployee employee)
        {
            emloyees.Add(employee);
        }
        public void StartWorkDay()
        {
            foreach(var employee in emloyees)
            {
                employee.Work();
                if(employee is IManager manager)
                {
                    manager.Manage();
                }
            }
        }
    }
}
