using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class PhoneReacharger
    {
        public void RechargeLinghtningPhone(ILightningIphone phone)
        {
            phone.UseLightning();
            phone.Recharge();
            Console.WriteLine("Phone is recharged");
        }
    }
}
