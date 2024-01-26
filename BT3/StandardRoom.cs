using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class StandardRoom :Room
    {
        public StandardRoom(int number):base(number) { }
        public override void CleanRoom()
        { 
            Console.WriteLine("Standardroom" + Number + "is cleaned");
        }
    }
}
