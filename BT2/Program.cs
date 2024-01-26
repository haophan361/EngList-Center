using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MicroUsbPhone android=new MicroUsbPhone();
            ILightningIphone adapter = new LightningToMicroUsbAdapter(android);
            PhoneReacharger reacharger = new PhoneReacharger();
            reacharger.RechargeLinghtningPhone(adapter);
            Console.ReadKey();
        }
    }
}