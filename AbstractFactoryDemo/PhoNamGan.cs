using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class PhoNamGan : IPho
    {
        public string getType()
        {
            return "Pho co gan";
        }
    }
}
