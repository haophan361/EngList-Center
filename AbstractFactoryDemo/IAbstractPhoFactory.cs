using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    public interface IAbstractPhoFactory
    {
        IPho createPho();
        ISauce createSauce();
    }
}
