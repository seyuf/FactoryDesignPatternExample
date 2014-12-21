using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using FactoryTest.Area;
using FactoryTest.Access;

namespace FactoryTest.Map
{
    class AbstractMap
    {
        internal List<AbstractArea> areaList;
        internal List<AbstractAccess> accessList;
        public AbstractMap() {
            areaList = new List<AbstractArea>();
            accessList = new List<AbstractAccess>();
        }

        internal abstract void AddArea(AbstractArea areaIn);

        internal abstract void AddAccess(AbstractAccess accessIn);
    }
}
