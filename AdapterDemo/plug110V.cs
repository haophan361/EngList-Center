using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class plug110V
    {
        public void Consume110V()
        {
            Console.WriteLine("Using 110V");
        }
        public void Plug110V()
        {
            Console.WriteLine("Using plug 110V ");
        }
    }
}
