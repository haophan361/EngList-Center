using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    public class SuiteRoom: Room
    {
        public SuiteRoom(int number): base(number) { }
        public override void CleanRoom()
        {
            Console.WriteLine("SuiteRoom" + Number + " is cleaned");
        }
        public override bool BookRoom(DateTime date)
        {
            return base.BookRoom(date);
        }
    }
}
