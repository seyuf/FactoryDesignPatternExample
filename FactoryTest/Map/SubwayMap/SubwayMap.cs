using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryTest.Factory;

namespace FactoryTest.Map
{
    class SubwayMap:AbstractMap
    {
        internal SubwayFactory subFactory;
        public SubwayMap(){
            subFactory = new SubwayFactory();
        }

        internal override void AddAccess(Access.AbstractAccess accessIn)
        {
            //a venir creer les couloir/autres a partir du xml
            accessList.Add(subFactory.GenerateAccess());
        }

        internal override void AddArea(Area.AbstractArea areaIn)
        {
            //a venir creer les murs/autres a partir du xml
            areaList.Add(subFactory.GenerateArea());
        }

    }
}
