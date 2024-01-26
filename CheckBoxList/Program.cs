using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CheckBoxList checkBoxList = new CheckBoxList();
            GetInfo info = new GetInfo(checkBoxList);
            Employee emp1 = new Employee(1);
            Employee emp2 = new Employee(2);
            Employee emp3 = new Employee(3);
            Employee emp4 = new Employee(4);
            Employee emp5 = new Employee(5);
            checkBoxList.AddEmployee(emp1);
            checkBoxList.AddEmployee(emp2);
            checkBoxList.AddEmployee(emp3);
            checkBoxList.AddEmployee(emp4);
            checkBoxList.AddEmployee(emp5);
            checkBoxList.ThaoTacLayID(2);
            checkBoxList.ThaoTacLayID(3);
            checkBoxList.ThaoTacLayID(6);
        }
    }
}