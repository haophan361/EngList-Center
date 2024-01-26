using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxList
{
    public class CheckBoxList
    {
        public delegate void LayThongTinHandler(CheckBoxList sender, Employee e);
        public event LayThongTinHandler getinfo;
        private List<Employee> Employees;
        public CheckBoxList()
        {
            Employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void ThaoTacLayID(int id)
        {
            Employee listid = new Employee(id);
            if(getinfo != null)
            {
                getinfo(this,listid);
            }
        }
        public bool kiemtra(Employee id)
        {
            foreach (var employee in Employees)
            {
                if (employee.EmployeeID == id.EmployeeID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
