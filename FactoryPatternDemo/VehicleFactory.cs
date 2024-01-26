using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class VehicleFactory
    {
        public IVehicle createIvehicle(string type)
        {
            switch (type)
            {
                case "car":
                {
                        return new Car();
                        break;
                }
                case "motorbike":
                {
                    return new Motorbike();
                    break;
                }
                default:
                {
                    throw new ArgumentException("Invalid vehicle type "+nameof(type));
                }
            }
        }
    }
}
