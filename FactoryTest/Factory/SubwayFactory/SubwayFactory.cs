using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryTest.Access;
using FactoryTest.Area;

namespace FactoryTest.Factory
{
    class SubwayFactory: AbstractMapFactory
    {
        public SubwayFactory() { }
        internal override AbstractAccess GenerateAccess()
        { 
            return new Tunnel();
        }

        internal override AbstractArea GenerateArea()
        {
            return new Wall();
        }
    }
}
