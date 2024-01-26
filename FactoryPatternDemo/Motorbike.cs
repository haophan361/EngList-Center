using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class Motorbike :IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a motorbike");
        }
    }
}
