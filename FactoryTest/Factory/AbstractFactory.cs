using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryTest.Area;
using FactoryTest.Access;

namespace FactoryTest.Factory
{
    class AbstractMapFactory
    {
        public AbstractMapFactory() { 
        }
        abstract internal AbstractArea GenerateArea();
        abstract internal AbstractAccess GenerateAccess();
    }
}
