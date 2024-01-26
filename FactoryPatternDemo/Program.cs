using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VehicleFactory factory = new VehicleFactory();
            IVehicle mycar = factory.createIvehicle("car");
            mycar.Drive();
            IVehicle mymotorbyke = factory.createIvehicle("motorbike");
            mymotorbyke.Drive();
            Console.ReadKey();
        }
    }
}