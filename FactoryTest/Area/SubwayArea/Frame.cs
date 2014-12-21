using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest.Area
{
    class Frame: AbstractArea
    {
        internal int coordX;
        internal int coordY;
        internal string name;
        public Frame(int x = 0, int y = 0, string nameIn = "simple case") {
            coordX = x;
            coordY = y;
            name = nameIn;
        }

       public string AbstractArea.Name
        {
            get
            {

                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
