using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthWindDataContext dbs= new NorthWindDataContext();
            var Customers = from p in dbs.Customers select p.CustomerID where 
            foreach( var product in Customers )
            {
                Console.WriteLine(product);
            }
        }
    }
}
