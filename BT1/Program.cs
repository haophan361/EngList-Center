using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var company = new Company();
            var dev = new Developer("Alice");
            var intern = new Intern("Bob");
            var manager = new Manager("Carol");
            manager.addSubordinate(dev);
            manager.addSubordinate(intern);
            company.addEmployee(manager);
            company.addEmployee(intern);
            company.addEmployee(dev);
            company.StartWorkDay();
        }
    }
}