using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class PhoNamGanFactory : IAbstractPhoFactory
    {
        public IPho createPho()
        {
            return new PhoNamGan();
        }
        public ISauce createSauce()
        {
            return new TuongOt();
        }
    }
}
