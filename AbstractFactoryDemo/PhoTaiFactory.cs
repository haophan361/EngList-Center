using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public class PhoTaiFactory : IAbstractPhoFactory
    {
        public IPho createPho()
        {
            return new PhoTai();
        }
        public ISauce createSauce()
        {
            return new NuocMam();
        }
    }
}
